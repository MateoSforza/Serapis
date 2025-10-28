using System.Threading.Tasks;
using Serapis.Modelo;

namespace Serapis.Services.Printing
{
    // Abstract Factory/Builder: salida de impresión/PDF
    public interface IImpresionFactura
    {
        Task<string> GenerarPdfAsync(Factura factura, string rutaDestino);
    }
}
