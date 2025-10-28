using Serapis.Modelo;

namespace Serapis.Services.Strategies
{
    // Strategy: cálculo de impuestos (IVA)
    public interface IImpuestosStrategy
    {
        decimal CalcularIva(Venta venta, decimal subtotal, CondicionIva condicionIva, TipoComprobante tipo);
    }
}
