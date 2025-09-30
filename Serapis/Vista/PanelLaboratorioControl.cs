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
using Serapis.Controladoras;

namespace Serapis.Vista
{
    public partial class PanelLaboratorioControl : UserControl
    {
        private readonly LaboratorioController _laboratorioController;
        private readonly SerapisDbContext _context;

        public PanelLaboratorioControl(SerapisDbContext context)
        {
            InitializeComponent();
            _context = context;
            _laboratorioController = new LaboratorioController(context);
            CargarProductos();
        }

        private void CargarProductos()
        {
            dgvProductosLabo.DataSource = _laboratorioController.ObtenerProductos()
                .Select(p => new
                {
                    p.Id,
                    p.Nombre,
                    p.Codigo,
                    p.Laboratorio,
                    p.Precio,
                    p.Stock,
                    p.FechaVencimiento,
                    RequiereReceta = p.RequiereReceta ? "Sí" : "No"
                })
                .ToList();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombre.Text.Trim();
                string codigo = txtCodigo.Text.Trim();
                string laboratorio = txtLaboratorio.Text.Trim();
                decimal precio = nudPrecio.Value;
                int stock = (int)nudStock.Value;
                DateTime fechaVenc = dtpFdv.Value;
                bool requiereReceta = chkReceta.Checked;

                if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(codigo))
                {
                    MessageBox.Show("Debe completar al menos el nombre y el código.");
                    return;
                }

                _laboratorioController.RegistrarProducto(
                    nombre,
                    codigo,
                    precio,
                    stock,
                    fechaVenc,
                    laboratorio,
                    requiereReceta
                );

                MessageBox.Show("Producto agregado con éxito.");
                CargarProductos();
                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar producto: {ex.Message}");
            }
        }

        private void btnDesactivar_Click(object sender, EventArgs e)
        {
            if (dgvProductosLabo.CurrentRow != null)
            {
                int productoId = (int)dgvProductosLabo.CurrentRow.Cells["Id"].Value;
                _laboratorioController.DesactivarProducto(productoId);
                MessageBox.Show("Producto desactivado.");
                CargarProductos();
            }
        }

        // Limpiar formulario de alta
        private void LimpiarFormulario()
        {
            txtNombre.Clear();
            txtCodigo.Clear();
            txtLaboratorio.Clear();
            nudPrecio.Value = 0;
            nudStock.Value = 0;
            dtpFdv.Value = DateTime.Today;
            chkReceta.Checked = false;
        }
    }
}
