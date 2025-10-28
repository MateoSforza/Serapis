using Serapis.Modelo;

namespace Serapis.Services.Strategies
{
    // Strategy: cálculo de precios/coberturas
    public interface IPrecioStrategy
    {
        decimal CalcularSubtotal(Venta venta);
    }
}
