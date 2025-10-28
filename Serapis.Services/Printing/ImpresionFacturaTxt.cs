using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Serapis.Modelo;

namespace Serapis.Services.Printing
{
    // Builder/Factory: implementación mínima que "simula" un PDF (archivo .txt) para demo
    public class ImpresionFacturaTxt : IImpresionFactura
    {
        public async Task<string> GenerarPdfAsync(Factura factura, string rutaDestino)
        {
            Directory.CreateDirectory(Path.GetDirectoryName(rutaDestino)!);
            var sb = new StringBuilder();
            sb.AppendLine("SERAPIS - Comprobante");
            sb.AppendLine($"Tipo: {factura.Tipo}");
            sb.AppendLine($"PV: {factura.PuntoVenta} Nro: {factura.Numero:00000000}");
            sb.AppendLine($"Fecha: {factura.FechaEmision:dd/MM/yyyy HH:mm}");
            sb.AppendLine($"Cliente: {(factura.Cliente != null ? factura.Cliente.Nombre + " " + factura.Cliente.Apellido : "Consumidor Final")}");
            sb.AppendLine(new string('-', 40));
            sb.AppendLine($"Subtotal: {factura.Subtotal:C}");
            sb.AppendLine($"IVA: {factura.Iva:C}");
            sb.AppendLine($"Total: {factura.Total:C}");
            sb.AppendLine(new string('-', 40));
            sb.AppendLine($"CAE: {factura.Cae}");
            sb.AppendLine($"Vto CAE: {factura.CaeVencimiento:dd/MM/yyyy}");

            await File.WriteAllTextAsync(rutaDestino, sb.ToString(), Encoding.UTF8);
            return rutaDestino;
        }
    }
}
