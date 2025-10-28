using Serapis.Modelo;

namespace Serapis.Services.Strategies
{
    // Strategy: c�lculo de precios/coberturas
    public interface IPrecioStrategy
    {
        decimal CalcularSubtotal(Venta venta);
    }
}
