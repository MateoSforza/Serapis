using Microsoft.EntityFrameworkCore;
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
    public partial class PanelRegistrarComprasControl : UserControl
    {
        private readonly CompraController _compraController;
        private List<CompraDetalle> _detalles;

        public PanelRegistrarComprasControl(CompraController compraController)
        {
            InitializeComponent();
            _compraController = compraController;
            _detalles = new List<CompraDetalle>();

            CargarProductos();
            CargarProveedores();
            ConfigurarDataGridView();
            lblCostoTotal.Text = "$0.00";
        }

        private void CargarProveedores()
        {
            var proveedores = _compraController.ObtenerProveedores();
            cmbProveedor.DataSource = proveedores;
            cmbProveedor.DisplayMember = "Nombre";
            cmbProveedor.ValueMember = "Id";
        }

        private void CargarProductos()
        {
            var productos = _compraController.ObtenerProductos();
            cmbProducto.DataSource = productos;
            cmbProducto.DisplayMember = "Nombre";
            cmbProducto.ValueMember = "Id";
        }

        private void ConfigurarDataGridView()
        {
            dgvProductos.AutoGenerateColumns = false;
            dgvProductos.Columns.Clear();
            dgvProductos.Columns.Add("Producto", "Producto");
            dgvProductos.Columns.Add("Cantidad", "Cantidad");
            dgvProductos.Columns.Add("Precio", "Precio");
            dgvProductos.Columns.Add("Subtotal", "Subtotal");
        }

        private void btnAgregarItem_Click(object sender, EventArgs e)
        {
            if (cmbProducto.SelectedItem is Producto producto)
            {
                int cantidad = (int)nudCantidad.Value;
                if (cantidad <= 0)
                {
                    MessageBox.Show("Ingrese una cantidad válida.");
                    return;
                }

                var detalle = new CompraDetalle
                {
                    ProductoId = producto.Id,
                    Cantidad = cantidad,
                    PrecioUnitario = producto.Precio,
                    Subtotal = producto.Precio * cantidad
                };

                _detalles.Add(detalle);

                dgvProductos.Rows.Add(producto.Nombre, cantidad, producto.Precio, detalle.Subtotal);

                ActualizarTotal();

                nudCantidad.Value = 1; // reset cantidad
                cmbProducto.SelectedIndex = 0; // reset producto
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedRows.Count > 0)
            {
                int index = dgvProductos.SelectedRows[0].Index;

                if (index >= 0 && index < _detalles.Count)
                {
                    _detalles.RemoveAt(index);
                    dgvProductos.Rows.RemoveAt(index);
                    ActualizarTotal();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un item para eliminar.");
            }
        }

        private void btnRegistrarCompra_Click(object sender, EventArgs e)
        {
            if (cmbProveedor.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un proveedor.");
                return;
            }

            if (_detalles.Count == 0)
            {
                MessageBox.Show("Agregue al menos un item a la compra.");
                return;
            }

            int proveedorId = (int)cmbProveedor.SelectedValue;
            DateTime fecha = dtpFecha.Value;

            _compraController.RegistrarCompra(proveedorId, fecha, _detalles);

            MessageBox.Show("Compra registrada con éxito.");

            LimpiarFormulario();
        }

        private void ActualizarTotal()
        {
            decimal total = _detalles.Sum(d => d.Subtotal);
            lblCostoTotal.Text = $"Total: ${total:N2}";
        }

        private void LimpiarFormulario()
        {
            _detalles.Clear();
            dgvProductos.Rows.Clear();
            lblCostoTotal.Text = "Total: $0.00";
            nudCantidad.Value = 1;
            cmbProducto.SelectedIndex = 0;
            cmbProveedor.SelectedIndex = 0;
            dtpFecha.Value = DateTime.Now;
        }

        private void dgvItems_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
