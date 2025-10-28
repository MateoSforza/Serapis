using System.Threading.Tasks;

namespace Serapis.Services.Adapters
{
    // Adapter: interfaz para conectarse a AFIP (simulado)
    public interface IAfipAdapter
    {
        Task<(string cae, System.DateTime vencimiento)> AutorizarAsync(string puntoVenta, long numero, decimal total);
    }
}
