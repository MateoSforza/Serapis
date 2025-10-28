using System;

namespace Serapis.Modelo
{
    // Registro de pagos aplicados a una factura (1:N)
    public class PagoFactura
    {
        public int Id { get; set; }
        public int FacturaId { get; set; }
        public Factura Factura { get; set; } = null!;

        public MedioPago Medio { get; set; }
        public decimal Monto { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;
        public string? Detalle { get; set; }
    }
}
