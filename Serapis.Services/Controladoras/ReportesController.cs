using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Serapis.Data;
using Serapis.Modelo;

namespace Serapis.Controladoras
{
    public class ReportesController
    {
        private readonly SerapisDbContext _context;

        public ReportesController(SerapisDbContext context)
        {
            _context = context;
        }

        // Total de ventas en un período
        public decimal ObtenerTotalVentas(DateTime desde, DateTime hasta)
        {
            return _context.Ventas
                .Where(v => v.Fecha >= desde && v.Fecha <= hasta)
                .Sum(v => (decimal?)v.Total) ?? 0;
        }

        // Total de compras en un período
        public decimal ObtenerTotalCompras(DateTime desde, DateTime hasta)
        {
            return _context.Compras
                .Where(c => c.Fecha >= desde && c.Fecha <= hasta)
                .Sum(c => (decimal?)c.Total) ?? 0;
        }

        // Compras realizadas en el período ("paquetes" de compras)
        public object ObtenerCompras(DateTime desde, DateTime hasta)
        {
            return _context.Compras
                .Include(c => c.Proveedor)
                .Where(c => c.Fecha >= desde && c.Fecha <= hasta)
                .Select(c => new
                {
                    c.Id,
                    Proveedor = c.Proveedor != null ? c.Proveedor.Nombre : "(s/d)",
                    Fecha = c.Fecha,
                    Total = c.Total
                })
                .OrderByDescending(c => c.Fecha)
                .ToList();
        }

        // Ventas agrupadas por cliente
        public object ObtenerVentasPorCliente(DateTime desde, DateTime hasta)
        {
            return _context.Ventas
                .Where(v => v.Fecha >= desde && v.Fecha <= hasta)
                .GroupBy(v => v.Cliente!.Nombre)
                .Select(g => new
                {
                    Cliente = g.Key,
                    Total = g.Sum(v => v.Total)
                })
                .ToList();
        }

        // Facturas emitidas en el período (para reportes)
        public object ObtenerFacturas(DateTime desde, DateTime hasta)
        {
            return _context.Facturas
                .Where(f => f.FechaEmision >= desde && f.FechaEmision <= hasta)
                .Select(f => new
                {
                    f.Id,
                    Numero = f.PuntoVenta + "-" + f.Numero.ToString("00000000"),
                    f.Tipo,
                    Fecha = f.FechaEmision,
                    Cliente = f.Cliente != null ? f.Cliente.Nombre + " " + f.Cliente.Apellido : "Consumidor Final",
                    f.Subtotal,
                    f.Iva,
                    f.Total,
                    f.Cae
                })
                .OrderByDescending(f => f.Fecha)
                .ToList();
        }

        public Factura? ObtenerFacturaPorId(int id)
        {
            return _context.Facturas
                .Include(f => f.Cliente)
                .FirstOrDefault(f => f.Id == id);
        }
    }
}
