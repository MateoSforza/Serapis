using System.IO;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Serapis.Modelo;

namespace Serapis.Services.Printing
{
    // Implementación PDF real con iTextSharp
    public class ImpresionFacturaPdf : IImpresionFactura
    {
        public Task<string> GenerarPdfAsync(Factura factura, string rutaDestino)
        {
            Directory.CreateDirectory(Path.GetDirectoryName(rutaDestino)!);
            using (var fs = new FileStream(rutaDestino, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                var doc = new Document(PageSize.A4, 36, 36, 36, 36);
                var writer = PdfWriter.GetInstance(doc, fs);

                doc.Open();

                var title = new Paragraph("SERAPIS - Comprobante", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16))
                {
                    Alignment = Element.ALIGN_CENTER
                };
                doc.Add(title);
                doc.Add(new Paragraph("\n"));

                var info = new Paragraph($"Tipo: {factura.Tipo}\nPV: {factura.PuntoVenta} Nro: {factura.Numero:00000000}\nFecha: {factura.FechaEmision:dd/MM/yyyy HH:mm}");
                doc.Add(info);
                var cliente = new Paragraph($"Cliente: {(factura.Cliente != null ? factura.Cliente.Nombre + " " + factura.Cliente.Apellido : "Consumidor Final")}");
                doc.Add(cliente);
                doc.Add(new Paragraph("\n"));

                var totales = new PdfPTable(2) { WidthPercentage = 50, HorizontalAlignment = Element.ALIGN_LEFT };
                totales.AddCell("Subtotal"); totales.AddCell(factura.Subtotal.ToString("C"));
                totales.AddCell("IVA"); totales.AddCell(factura.Iva.ToString("C"));
                totales.AddCell("Total"); totales.AddCell(factura.Total.ToString("C"));
                doc.Add(totales);

                doc.Add(new Paragraph("\n"));
                doc.Add(new Paragraph($"CAE: {factura.Cae} - Vto: {factura.CaeVencimiento:dd/MM/yyyy}"));

                doc.Close();
                writer.Close();
            }

            return Task.FromResult(rutaDestino);
        }
    }
}
