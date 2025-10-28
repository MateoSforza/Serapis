using System;
using System.Threading.Tasks;

namespace Serapis.Services.Adapters
{
    // Adapter: AFIP simulado
    public class AfipSimuladoAdapter : IAfipAdapter
    {
        public Task<(string cae, DateTime vencimiento)> AutorizarAsync(string puntoVenta, long numero, decimal total)
        {
            // Genera un CAE simulado (14 dígitos) y vencimiento a 10 días
            var cae = Guid.NewGuid().ToString("N").Substring(0, 14);
            var venc = DateTime.Now.Date.AddDays(10);
            return Task.FromResult((cae, venc));
        }
    }
}
