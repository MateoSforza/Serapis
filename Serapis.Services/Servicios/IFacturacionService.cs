using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Serapis.Modelo;

namespace Serapis.Controladoras
{
    // Facade: orquesta todo el proceso de facturación
    public interface IFacturacionService
    {
        Task<Factura> FacturarVentaAsync(int ventaId, TipoComprobante tipo, string puntoVenta, IEnumerable<(MedioPago medio, decimal monto)> pagos, int? clienteId = null);
        Task<Factura> GenerarNotaCreditoAsync(int facturaId, string motivo, IEnumerable<(MedioPago medio, decimal monto)> devoluciones);
    }
}
