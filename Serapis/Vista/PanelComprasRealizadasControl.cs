using Serapis.Controladoras;
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
    public partial class PanelComprasRealizadasControl : UserControl
    {
        private readonly CompraController _compraController;

        public PanelComprasRealizadasControl(CompraController compraController)
        {
            InitializeComponent();
            _compraController = compraController;

            CargarProveedoresFiltro();
            CargarCompras();
        }

        private void CargarProveedoresFiltro()
        {
            var proveedores = _compraController.ObtenerProveedores();
            cmbProveedor.DataSource = proveedores;
            cmbProveedor.DisplayMember = "Nombre";
            cmbProveedor.ValueMember = "Id";
            cmbProveedor.SelectedIndex = -1; // nada seleccionado por defecto
        }

        private void CargarCompras(int? proveedorId = null, DateTime? desde = null, DateTime? hasta = null)
        {
            var compras = _compraController.ObtenerCompras(proveedorId, desde, hasta);

            dgvCompras.DataSource = compras.Select(c => new
            {
                c.Id,
                Proveedor = c.Proveedor.Nombre,
                Fecha = c.Fecha.ToShortDateString(),
                Total = c.Total.ToString("C")
            }).ToList();

            dgvCompras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnFiltroFecha_Click(object sender, EventArgs e)
        {
            int? proveedorId = cmbProveedor.SelectedIndex >= 0 ? (int?)cmbProveedor.SelectedValue : null;
            DateTime? desde = dtpDesde.Checked ? dtpDesde.Value.Date : null;
            DateTime? hasta = dtpHasta.Checked ? dtpHasta.Value.Date : null;

            CargarCompras(proveedorId, desde, hasta);
        }

        private void btnVerDetalle_Click(object sender, EventArgs e)
        {
            if (dgvCompras.CurrentRow != null)
            {
                int compraId = (int)dgvCompras.CurrentRow.Cells["Id"].Value;
                var detalles = _compraController.ObtenerDetalleCompra(compraId);

                string mensaje = string.Join(Environment.NewLine, detalles.Select(d =>
                    $"{d.Cantidad} x {d.Producto.Nombre} @ {d.PrecioUnitario:C} = {d.Subtotal:C}"));

                MessageBox.Show(mensaje, "Detalle de Compra");
            }
        }
    }
}
