using Serapis.Controladoras;
using Serapis.Data;
using System;
using System.Windows.Forms;

namespace Serapis.Vista
{
    public partial class PanelReportesControl : UserControl
    {
        private readonly ReportesController _reportesController;

        public PanelReportesControl(SerapisDbContext context)
        {
            InitializeComponent();
            _reportesController = new ReportesController(context);
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            DateTime desde = dtpDesde.Value.Date;
            DateTime hasta = dtpHasta.Value.Date;

            lblTotalVentas.Text = $"Ventas: ${_reportesController.ObtenerTotalVentas(desde, hasta):N2}";
            lblTotalCompras.Text = $"Compras: ${_reportesController.ObtenerTotalCompras(desde, hasta):N2}";

            dgvVentasClientes.DataSource = _reportesController.ObtenerVentasPorCliente(desde, hasta);
            dgvCompras.DataSource = _reportesController.ObtenerCompras(desde, hasta);
        }
    }
}
