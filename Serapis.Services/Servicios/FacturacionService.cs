using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Serapis.Controladoras;
using Serapis.Data;
using Serapis.Modelo;
using Serapis.Services.Adapters;
using Serapis.Services.Printing;
using Serapis.Services.Strategies;

namespace Serapis.Services
{
    // Facade: orquesta el proceso de facturar una venta
    public class FacturacionService : IFacturacionService
    {
        private readonly SerapisDbContext _context;
        private readonly IAfipAdapter _afip;
        private readonly IImpresionFactura _impresion;
        private readonly IPrecioStrategy _precioStrategy;
        private readonly IImpuestosStrategy _impuestosStrategy;

        public FacturacionService(
            SerapisDbContext context,
            IAfipAdapter afip,
            IImpresionFactura impresion,
            IPrecioStrategy precioStrategy,
            IImpuestosStrategy impuestosStrategy)
        {
            _context = context;
            _afip = afip;
            _impresion = impresion;
            _precioStrategy = precioStrategy;
            _impuestosStrategy = impuestosStrategy;
        }

        public async Task<Factura> FacturarVentaAsync(int ventaId, TipoComprobante tipo, string puntoVenta, IEnumerable<(MedioPago medio, decimal monto)> pagos, int? clienteId = null)
        {
            using var tx = await _context.Database.BeginTransactionAsync();
            var venta = await _context.Ventas
                .Include(v => v.ItemsVenta)
                .FirstOrDefaultAsync(v => v.Id == ventaId);
            if (venta == null) throw new InvalidOperationException($"Venta {ventaId} no encontrada");

            // Strategy: calcular subtotal e IVA
            var subtotal = _precioStrategy.CalcularSubtotal(venta);
            var condicion = await _context.Clientes.Where(c => c.Id == clienteId).Select(c => c.Activo).FirstOrDefaultAsync();
            var iva = _impuestosStrategy.CalcularIva(venta, subtotal, CondicionIva.ConsumidorFinal, tipo); // TODO: mapear desde cliente real
            var total = subtotal + iva;

            // Número correlativo (simplificado)
            long numero = await _context.Facturas.Where(f => f.PuntoVenta == puntoVenta).Select(f => (long?)f.Numero).MaxAsync() ?? 0;
            numero++;

            var factura = new Factura
            {
                VentaId = venta.Id,
                Tipo = tipo,
                PuntoVenta = puntoVenta,
                Numero = numero,
                Subtotal = subtotal,
                Iva = iva,
                Total = total,
                ClienteId = clienteId
            };

            await _context.Facturas.AddAsync(factura);
            await _context.SaveChangesAsync();

            // Pagos
            foreach (var p in pagos)
            {
                await _context.PagosFactura.AddAsync(new PagoFactura
                {
                    FacturaId = factura.Id,
                    Medio = p.medio,
                    Monto = p.monto
                });
            }
            await _context.SaveChangesAsync();

            // Adapter: AFIP (simulado)
            var (cae, venc) = await _afip.AutorizarAsync(puntoVenta, numero, total);
            factura.Cae = cae;
            factura.CaeVencimiento = venc;
            await _context.SaveChangesAsync();

            await tx.CommitAsync();
            return factura;
        }

        public async Task<Factura> GenerarNotaCreditoAsync(int facturaId, string motivo, IEnumerable<(MedioPago medio, decimal monto)> devoluciones)
        {
            using var tx = await _context.Database.BeginTransactionAsync();
            var origen = await _context.Facturas.Include(f => f.Pagos).FirstOrDefaultAsync(f => f.Id == facturaId);
            if (origen == null) throw new InvalidOperationException("Factura original no encontrada");

            var puntoVenta = origen.PuntoVenta;
            long numero = await _context.Facturas.Where(f => f.PuntoVenta == puntoVenta).Select(f => (long?)f.Numero).MaxAsync() ?? 0;
            numero++;

            var tipoNC = origen.Tipo switch
            {
                TipoComprobante.FacturaA => TipoComprobante.NotaCreditoA,
                TipoComprobante.FacturaB => TipoComprobante.NotaCreditoB,
                _ => TipoComprobante.NotaCreditoC
            };

            var notaCredito = new Factura
            {
                VentaId = origen.VentaId,
                Tipo = tipoNC,
                PuntoVenta = puntoVenta,
                Numero = numero,
                Subtotal = -origen.Subtotal,
                Iva = -origen.Iva,
                Total = -origen.Total,
                ClienteId = origen.ClienteId,
                FacturaOrigenId = origen.Id
            };

            await _context.Facturas.AddAsync(notaCredito);
            await _context.SaveChangesAsync();

            foreach (var d in devoluciones)
            {
                await _context.PagosFactura.AddAsync(new PagoFactura
                {
                    FacturaId = notaCredito.Id,
                    Medio = d.medio,
                    Monto = -Math.Abs(d.monto)
                });
            }
            await _context.SaveChangesAsync();

            await tx.CommitAsync();
            return notaCredito;
        }
    }
}
