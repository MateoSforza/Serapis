using System;
using System.Collections.Generic;

namespace Serapis.Modelo
{
    // Entidad de facturación. Se asocia 1:1 con Venta y 1:N con Pagos.
    public class Factura
    {
        public int Id { get; set; }
        public int VentaId { get; set; }
        public Venta Venta { get; set; } = null!;

        public TipoComprobante Tipo { get; set; }
        public string PuntoVenta { get; set; } = "0001"; // 4 dígitos
        public long Numero { get; set; } // correlativo

        public decimal Subtotal { get; set; }
        public decimal Iva { get; set; }
        public decimal Total { get; set; }

        public string? Cae { get; set; } // Simulado
        public DateTime? CaeVencimiento { get; set; }

        public DateTime FechaEmision { get; set; } = DateTime.Now;

        public int? ClienteId { get; set; }
        public Cliente? Cliente { get; set; }

        public List<PagoFactura> Pagos { get; set; } = new();

        // Para notas de crédito
        public int? FacturaOrigenId { get; set; }
        public Factura? FacturaOrigen { get; set; }
        public bool EsNotaCredito => Tipo == TipoComprobante.NotaCreditoA || Tipo == TipoComprobante.NotaCreditoB || Tipo == TipoComprobante.NotaCreditoC;
    }
}
