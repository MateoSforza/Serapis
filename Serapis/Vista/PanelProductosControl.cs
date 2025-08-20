using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Serapis.Datos;
using Serapis.Modelo;
using Serapis.Controladoras;

namespace Serapis.Vista
{
    public partial class PanelProductosControl : UserControl
    {
        private readonly ProductoController _productoController;

        public PanelProductosControl(SerapisDbContext context)
        {
            InitializeComponent();
            _productoController = new ProductoController(context);

            CargarProductos();

            txtBuscar.TextChanged += txtBuscar_TextChanged;
            chkInactivos.CheckedChanged += chkInactivos_CheckedChanged;
        }

        private void CargarProductos(string filtro = "")
        {
            var productos = _productoController.ObtenerProductos(filtro);

            if (!chkInactivos.Checked)
                productos = productos.Where(p => p.Activo).ToList();

            dgvProductos.DataSource = productos.Select(p => new
            {
                p.Id,
                p.Nombre,
                p.Codigo,
                p.Precio,
                p.Stock,
                p.Laboratorio,
                p.FechaVencimiento,
                RequiereReceta = p.RequiereReceta ? "Sí" : "No",
                Activo = p.Activo ? "Sí" : "No"
            }).ToList();

            if (dgvProductos.Columns["Id"] != null)
                dgvProductos.Columns["Id"].Visible = false;

            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void chkInactivos_CheckedChanged(object sender, EventArgs e)
        {
            CargarProductos(txtBuscar.Text.Trim());
        }
        
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarProductos(txtBuscar.Text.Trim());
        }
        
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var producto = new Producto
            {
                Nombre = txtNombre.Text,
                Codigo = txtCodigo.Text,
                Precio = decimal.TryParse(txtPrecio.Text, out var p) ? p : 0,
                Stock = int.TryParse(txtStock.Text, out var s) ? s : 0,
                FechaVencimiento = dtpFdv.Value,
                Laboratorio = txtLaboratorio.Text,
                RequiereReceta = chkRequiereReceta.Checked,
                Activo = true
            };

            string res = _productoController.AgregarProducto(producto);
            if (res == "OK")
            {
                MessageBox.Show("Producto agregado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
                CargarProductos();
            }
            else
            {
                MessageBox.Show(res, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow == null) return;

            int id = (int)dgvProductos.CurrentRow.Cells["Id"].Value;
            var producto = _productoController.ObtenerProductoPorId(id);
            if (producto != null)
            {
                txtNombre.Text = producto.Nombre;
                txtCodigo.Text = producto.Codigo;
                txtPrecio.Text = producto.Precio.ToString();
                txtStock.Text = producto.Stock.ToString();
                txtLaboratorio.Text = producto.Laboratorio;
                dtpFdv.Value = producto.FechaVencimiento;
                chkRequiereReceta.Checked = producto.RequiereReceta;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow == null) return;

            int id = (int)dgvProductos.CurrentRow.Cells["Id"].Value;
            var producto = new Producto
            {
                Id = id,
                Nombre = txtNombre.Text.Trim(),
                Codigo = txtCodigo.Text.Trim(),
                Precio = decimal.TryParse(txtPrecio.Text, out var p) ? p : 0,
                Stock = int.TryParse(txtStock.Text, out var s) ? s : 0,
                Laboratorio = txtLaboratorio.Text.Trim(),
                FechaVencimiento = dtpFdv.Value,
                RequiereReceta = chkRequiereReceta.Checked,
                Activo = true
            };

            string res = _productoController.ModificarProducto(producto);
            if (res == "OK")
            {
                MessageBox.Show("Producto modificado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
                CargarProductos();
            }
            else
            {
                MessageBox.Show(res, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow == null) return;

            int id = (int)dgvProductos.CurrentRow.Cells["Id"].Value;
            string res = _productoController.BajaLogicaProducto(id);
            if (res == "OK")
            {
                MessageBox.Show("Producto dado de baja.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarProductos();
            }
            else
            {
                MessageBox.Show(res, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarFormulario()
        {
            txtNombre.Clear();
            txtCodigo.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
            txtLaboratorio.Clear();
            chkRequiereReceta.Checked = false;
            dtpFdv.Value = DateTime.Now;
        }

        private void dgvProductos_SelectionChanged(object sender, EventArgs e)
        {
        }
    }
}
