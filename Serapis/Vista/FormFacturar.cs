using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Serapis.Controladoras;
using Serapis.Data;
using Serapis.Modelo;
using Serapis.Services;
using Serapis.Services.Adapters;
using Serapis.Services.Printing;
using Serapis.Services.Strategies;

namespace Serapis.UI.Vista
{
    public partial class FormFacturar : Form
    {
        private readonly SerapisDbContext _context;
        private readonly IFacturacionService _service;
        private readonly int _ventaId;
        private readonly int? _clienteId;
        private decimal _totalEstimado;

        public FormFacturar()
        {
            InitializeComponent();
        }

        public FormFacturar(SerapisDbContext context, int ventaId, int? clienteId) : this()
        {
            _context = context;
            _ventaId = ventaId;
            _clienteId = clienteId;

            _service = new FacturacionService(
                _context,
                new AfipSimuladoAdapter(),
                new ImpresionFacturaPdf(),
                new PrecioSimpleStrategy(),
                new IvaBasicoStrategy());

            InicializarControles();
        }

        private void InicializarControles()
        {
            // Configurar ComboBox de tipos
            cmbTipo.Items.Clear();
            cmbTipo.Items.Add(TipoComprobante.FacturaA);
            cmbTipo.Items.Add(TipoComprobante.FacturaB);
            cmbTipo.Items.Add(TipoComprobante.FacturaC);
            cmbTipo.SelectedIndex = 2; // FacturaC por defecto

            // Configurar punto de venta por defecto
            txtPuntoVenta.Text = "0001";

            // Conectar eventos
            cmbTipo.SelectedIndexChanged += cmbTipo_SelectedIndexChanged;
            numericUpDown1.ValueChanged += pagos_ValueChanged;
            numericUpDown2.ValueChanged += pagos_ValueChanged;
            numericUpDown3.ValueChanged += pagos_ValueChanged;
            btnConfirmar.Click += btnConfirmar_Click;

            // Cargar totales inicial
            Task.Run(async () => await CargarTotalesAsync()).Wait();
        }

        protected override async void OnShown(EventArgs e)
        {
            base.OnShown(e);
            await CargarTotalesAsync();
        }

        private async Task CargarTotalesAsync()
        {
            try
            {
                var venta = await _context.Ventas
                    .Where(v => v.Id == _ventaId)
                    .FirstOrDefaultAsync();

                if (venta == null)
                {
                    MessageBox.Show("Venta no encontrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }

                await _context.Entry(venta).Collection(v => v.ItemsVenta).LoadAsync();

                var subtotal = new PrecioSimpleStrategy().CalcularSubtotal(venta);
                var tipoSel = (cmbTipo?.SelectedItem is TipoComprobante t) ? t : TipoComprobante.FacturaC;
                var iva = new IvaBasicoStrategy().CalcularIva(venta, subtotal, CondicionIva.ConsumidorFinal, tipoSel);
                _totalEstimado = decimal.Round(subtotal + iva, 2);

                lblTotal.Text = $"Total a pagar: {_totalEstimado:C}";
                RecalcularPagos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar totales: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RecalcularPagos()
        {
            var sumaPagos = decimal.Round(numericUpDown1.Value + numericUpDown2.Value + numericUpDown3.Value, 2);
            var diferencia = decimal.Round(_totalEstimado - sumaPagos, 2);

            lblDiferencia.Text = $"Diferencia: {diferencia:C}";
            lblDiferencia.ForeColor = diferencia == 0m ? Color.DarkGreen : Color.Maroon;

            btnConfirmar.Enabled = diferencia == 0m && _totalEstimado > 0m;
        }

        private async void cmbTipo_SelectedIndexChanged(object? sender, EventArgs e)
        {
            await CargarTotalesAsync();
        }

        private void pagos_ValueChanged(object? sender, EventArgs e)
        {
            RecalcularPagos();
        }

        private async void btnConfirmar_Click(object? sender, EventArgs e)
        {
            try
            {
                var sumaPagos = decimal.Round(numericUpDown1.Value + numericUpDown2.Value + numericUpDown3.Value, 2);
                if (decimal.Round(_totalEstimado - sumaPagos, 2) != 0m)
                {
                    MessageBox.Show("La suma de los pagos debe coincidir con el total.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var pagos = new List<(MedioPago, decimal)>();
                if (numericUpDown1.Value > 0) pagos.Add((MedioPago.Efectivo, (decimal)numericUpDown1.Value));
                if (numericUpDown2.Value > 0) pagos.Add((MedioPago.Debito, (decimal)numericUpDown2.Value));
                if (numericUpDown3.Value > 0) pagos.Add((MedioPago.Credito, (decimal)numericUpDown3.Value));

                btnConfirmar.Enabled = false;
                btnConfirmar.Text = "Procesando...";

                var factura = await _service.FacturarVentaAsync(
                    _ventaId,
                    (TipoComprobante)cmbTipo.SelectedItem!,
                    txtPuntoVenta.Text.Trim(),
                    pagos,
                    _clienteId);

                var ruta = await new ImpresionFacturaPdf().GenerarPdfAsync(
                    factura,
                    System.IO.Path.Combine(
                        "C:\\Programacion\\INGENIERIA SOFTWARE\\SerapisV2\\Facturas",
                        $"Factura_{factura.PuntoVenta}-{factura.Numero:00000000}.pdf"));

                // Abrir el PDF automáticamente
                AbrirPdf(ruta);

                MessageBox.Show(
                    $"Comprobante emitido:\n\nNro: {factura.PuntoVenta}-{factura.Numero:00000000}\nCAE: {factura.Cae}\nVto CAE: {factura.CaeVencimiento:dd/MM/yyyy}\n\nArchivo guardado en:\n{ruta}",
                    "Factura Emitida",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al facturar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnConfirmar.Enabled = true;
                btnConfirmar.Text = "CONFIRMAR Y FACTURAR";
            }
        }

        private void AbrirPdf(string rutaPdf)
        {
            try
            {
                if (System.IO.File.Exists(rutaPdf))
                {
                    var psi = new System.Diagnostics.ProcessStartInfo
                    {
                        FileName = rutaPdf,
                        UseShellExecute = true
                    };
                    System.Diagnostics.Process.Start(psi);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se pudo abrir el PDF automáticamente: {ex.Message}", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
