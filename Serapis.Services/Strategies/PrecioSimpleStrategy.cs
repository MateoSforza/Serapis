using Serapis.Modelo;

namespace Serapis.Services.Strategies
{
    // Strategy: Subtotal simple (sumatoria de cantidad * precio unitario)
    public class PrecioSimpleStrategy : IPrecioStrategy
    {
        public decimal CalcularSubtotal(Venta venta)
        {
            decimal subtotal = 0m;
            foreach (var i in venta.ItemsVenta)
            {
                subtotal += i.Cantidad * i.PrecioUnitario;
            }
            return subtotal;
        }
    }
}
