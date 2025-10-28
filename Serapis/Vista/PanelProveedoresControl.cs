using Serapis.Modelo;
using Serapis.Controladores;
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
using Serapis.Data;

namespace Serapis.Vista
{
    public partial class PanelProveedoresControl : UserControl
    {
        private readonly ProveedoresController _proveedoresController;

        public PanelProveedoresControl(SerapisDbContext context)
        {
            InitializeComponent();
            _proveedoresController = new ProveedoresController(context);

            CargarProveedores();

            btnAgregar.Click += btnAgregar_Click;
            btnModificar.Click += btnModificar_Click;
            btnEliminar.Click += btnEliminar_Click;
            btnCargar.Click += btnCargar_Click;
        }

        private void CargarProveedores(bool mostrarInactivos = false)
        {
            dgvProveedores.DataSource = _proveedoresController.FiltrarProveedores(mostrarInactivos);
            dgvProveedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var proveedor = new Proveedor
            {
                Nombre = txtNombre.Text.Trim(),
                Telefono = txtTelefono.Text.Trim(),
                Email = txtEmail.Text.Trim(),
            };

            var resultado = _proveedoresController.AgregarProveedor(proveedor);
            if (resultado == "OK")
            {
                MessageBox.Show("Proveedor agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
                CargarProveedores();
            }
            else
            {
                MessageBox.Show(resultado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvProveedores.CurrentRow == null) return;

            int id = (int)dgvProveedores.CurrentRow.Cells["Id"].Value;
            var proveedor = _proveedoresController.ObtenerProveedorPorId(id);
            if (proveedor == null) return;

            proveedor.Nombre = txtNombre.Text.Trim();
            proveedor.Telefono = txtTelefono.Text.Trim();
            proveedor.Email = txtEmail.Text.Trim();

            var resultado = _proveedoresController.ModificarProveedor(proveedor);
            if (resultado == "OK")
            {
                MessageBox.Show("Proveedor modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
                CargarProveedores();
            }
            else
            {
                MessageBox.Show(resultado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvProveedores.CurrentRow == null) return;

            int id = (int)dgvProveedores.CurrentRow.Cells["Id"].Value;
            var resultado = _proveedoresController.EliminarProveedor(id);
            if (resultado == "OK")
            {
                MessageBox.Show("Proveedor eliminado (baja lógica).", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
                CargarProveedores();
            }
            else
            {
                MessageBox.Show(resultado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if(dgvProveedores.CurrentRow == null) return;

            int id = (int)dgvProveedores.CurrentRow.Cells["Id"].Value;
            var resultado = _proveedoresController.EliminarProveedor(id);
            if (resultado == "OK")
            {
                MessageBox.Show("Proveedor eliminado (baja lógica).", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
                CargarProveedores();
            }
            else
            {
                MessageBox.Show(resultado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LimpiarFormulario()
        {
            txtNombre.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
        }
    }
}
