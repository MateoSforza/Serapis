using Serapis.Modelo;

namespace Serapis.Services.Strategies
{
    // Strategy: IVA fijo por tipo de comprobante/condición (demo)
    public class IvaBasicoStrategy : IImpuestosStrategy
    {
        public decimal CalcularIva(Venta venta, decimal subtotal, CondicionIva condicionIva, TipoComprobante tipo)
        {
            // Demo: 21% para RI/B, 10.5% para algunos casos, 0% exento/CF en C
            decimal tasa = 0m;
            switch (condicionIva)
            {
                case CondicionIva.ResponsableInscripto:
                case CondicionIva.Monotributo:
                    tasa = tipo == TipoComprobante.FacturaC ? 0m : 0.21m;
                    break;
                case CondicionIva.Exento:
                case CondicionIva.ConsumidorFinal:
                    tasa = 0m;
                    break;
            }
            return decimal.Round(subtotal * tasa, 2);
        }
    }
}
