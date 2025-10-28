using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Serapis.Controladoras;
using Serapis.Data;
using Serapis.Modelo;
using Serapis.Services;
using Serapis.Services.Adapters;
using Serapis.Services.Printing;
using Serapis.Services.Strategies;

namespace Serapis.Vista
{
    public partial class FormFacturar : Form
    {
        private readonly SerapisDbContext _context;
        private readonly IFacturacionService _service;
        private readonly int _ventaId;
        private readonly int? _clienteId;

        private ComboBox cmbTipo;
        private TextBox txtPuntoVenta;
        private NumericUpDown nudEfectivo;
        private NumericUpDown nudDebito;
        private NumericUpDown nudCredito;
        private Label lblTotal;
        private Button btnConfirmar;
        private Label lblEfectivo;
        private Label lblDebito;
        private Label lblCredito;

        public FormFacturar(SerapisDbContext context, int ventaId, int? clienteId)
        {
            _context = context;
            _ventaId = ventaId;
            _clienteId = clienteId;

            // Inyección simple (sin contenedor) para mantener UI liviana
            _service = new FacturacionService(
                _context,
                new AfipSimuladoAdapter(),
                new ImpresionFacturaPdf(), // PDF real
                new PrecioSimpleStrategy(),
                new IvaBasicoStrategy());

            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Text = "Facturar";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Width = 460; this.Height = 300;

            cmbTipo = new ComboBox { Left = 20, Top = 20, Width = 150, DropDownStyle = ComboBoxStyle.DropDownList };
            cmbTipo.Items.AddRange(new object[] { TipoComprobante.FacturaA, TipoComprobante.FacturaB, TipoComprobante.FacturaC });
            cmbTipo.SelectedIndex = 2; // C por defecto

            txtPuntoVenta = new TextBox { Left = 200, Top = 20, Width = 80, Text = "0001" };

            lblEfectivo = new Label { Left = 20, Top = 70, Width = 80, Text = "Efectivo:" };
            nudEfectivo = new NumericUpDown { Left = 100, Top = 66, Width = 120, DecimalPlaces = 2, Maximum = 1000000 };

            lblDebito = new Label { Left = 240, Top = 70, Width = 80, Text = "Débito:" };
            nudDebito = new NumericUpDown { Left = 300, Top = 66, Width = 120, DecimalPlaces = 2, Maximum = 1000000 };

            lblCredito = new Label { Left = 20, Top = 110, Width = 80, Text = "Crédito:" };
            nudCredito = new NumericUpDown { Left = 100, Top = 106, Width = 120, DecimalPlaces = 2, Maximum = 1000000 };

            lblTotal = new Label { Left = 20, Top = 150, Width = 400, Text = "Total: -" };

            btnConfirmar = new Button { Left = 20, Top = 200, Width = 400, Height = 40, Text = "Confirmar y Emitir" };
            btnConfirmar.Click += async (s, e) => await ConfirmarAsync();

            this.Controls.AddRange(new Control[]
            {
                cmbTipo, txtPuntoVenta, lblEfectivo, nudEfectivo, lblDebito, nudDebito, lblCredito, nudCredito, lblTotal, btnConfirmar
            });
        }

        protected override async void OnShown(EventArgs e)
        {
            base.OnShown(e);
            await CargarTotalesAsync();
        }

        private async Task CargarTotalesAsync()
        {
            // cálculo rápido con strategies del service
            var venta = _context.Ventas.First(v => v.Id == _ventaId);
            await _context.Entry(venta).Collection(v => v.ItemsVenta).LoadAsync();

            var subtotal = new PrecioSimpleStrategy().CalcularSubtotal(venta);
            var iva = new IvaBasicoStrategy().CalcularIva(venta, subtotal, CondicionIva.ConsumidorFinal, (TipoComprobante)cmbTipo.SelectedItem!);
            var total = subtotal + iva;
            lblTotal.Text = $"Total estimado: {total:C}";
        }

        private async Task ConfirmarAsync()
        {
            var pagos = new List<(MedioPago, decimal)>();
            if (nudEfectivo.Value > 0) pagos.Add((MedioPago.Efectivo, (decimal)nudEfectivo.Value));
            if (nudDebito.Value > 0) pagos.Add((MedioPago.Debito, (decimal)nudDebito.Value));
            if (nudCredito.Value > 0) pagos.Add((MedioPago.Credito, (decimal)nudCredito.Value));

            var factura = await _service.FacturarVentaAsync(
                _ventaId,
                (TipoComprobante)cmbTipo.SelectedItem!,
                txtPuntoVenta.Text.Trim(),
                pagos,
                _clienteId);

            var ruta = await new ImpresionFacturaPdf().GenerarPdfAsync(factura, System.IO.Path.Combine("C:\\Programacion\\INGENIERIA SOFTWARE\\SerapisV2\\Facturas", $"Factura_{factura.PuntoVenta}-{factura.Numero:00000000}.pdf"));

            MessageBox.Show($"Comprobante emitido:\nNro: {factura.PuntoVenta}-{factura.Numero:00000000}\nCAE: {factura.Cae}\nVto CAE: {factura.CaeVencimiento:dd/MM/yyyy}\nArchivo: {ruta}",
                "Factura", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
