using System.Threading.Tasks;
using Serapis.Modelo;

namespace Serapis.Services.Printing
{
    // Abstract Factory/Builder: salida de impresi�n/PDF
    public interface IImpresionFactura
    {
        Task<string> GenerarPdfAsync(Factura factura, string rutaDestino);
    }
}
