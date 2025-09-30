using Serapis.Controladoras;
using Serapis.Datos;
using Serapis.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            // Totales
            lblTotalVentas.Text = $"Ventas: ${_reportesController.ObtenerTotalVentas(desde, hasta):N2}";
            lblTotalCompras.Text = $"Compras: ${_reportesController.ObtenerTotalCompras(desde, hasta):N2}";

            // Productos críticos
            dgvProductosCriticos.DataSource = _reportesController.ObtenerProductosCriticos();

            // Ventas por cliente
            dgvVentasClientes.DataSource = _reportesController.ObtenerVentasPorCliente(desde, hasta);
        }
    }
}
