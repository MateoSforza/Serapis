using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Serapis.Modelo;
using Serapis.Datos;

namespace Serapis.Vista
{
    public partial class FormProveedores : Form
    {
        private readonly SerapisDbContext _context;

        public FormProveedores(SerapisDbContext context)
        {
            InitializeComponent();
            _context = context;
            CargarProveedores();
        }

        private void FormProveedores_Load(object sender, EventArgs e)
        {
            cbxEstado.Items.Add("Activo");
            cbxEstado.Items.Add("Inactivo");
            cbxEstado.SelectedIndex = 0; // Por defecto, mostrar solo activos
            CargarProveedores();
        }

        private void CargarProveedores(bool incluirInactivos = false)
        {
            var proveedores = incluirInactivos
                ? _context.Proveedores.ToList()
                : _context.Proveedores.Where(p => p.Activo).ToList();

            dgvProveedores.DataSource = _context.Proveedores.Select(p => new
            {
                p.Id,
                p.Nombre,
                p.Cuit,
                p.Rubro,
                p.Telefono,
                p.Email,
                Estado = p.Activo ? "Activo" : "Inactivo"
            }).ToList();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtCuit.Text))
            {
                MessageBox.Show("Nombre y CUIT son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var proveedor = new Proveedor
            {
                Nombre = txtNombre.Text,
                Cuit = txtCuit.Text,
                Rubro = txtRubro.Text,
                Telefono = txtTelefono.Text,
                Email = txtEmail.Text,
                Activo = true
            };

            _context.Proveedores.Add(proveedor);
            _context.SaveChanges();
            MessageBox.Show("Proveedor agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CargarProveedores();
            LimpiarCampos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvProveedores.CurrentRow?.DataBoundItem is not null)
            {
                int id = (int)dgvProveedores.CurrentRow.Cells["Id"].Value;
                var proveedor = _context.Proveedores.FirstOrDefault(p => p.Id == id && p.Activo);
                if (proveedor != null)
                {
                    if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtCuit.Text))
                    {
                        MessageBox.Show("Nombre y CUIT son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    proveedor.Nombre = txtNombre.Text;
                    proveedor.Cuit = txtCuit.Text;
                    proveedor.Rubro = txtRubro.Text;
                    proveedor.Telefono = txtTelefono.Text;
                    proveedor.Email = txtEmail.Text;


                    _context.SaveChanges();
                    MessageBox.Show("Proveedor modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarProveedores();
                    LimpiarCampos();
                }
            }
        }
        private void cbxEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool mostrarInactivos = cbxEstado.SelectedItem?.ToString() == "Inactivo";
            CargarProveedores(mostrarInactivos);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvProveedores.CurrentRow?.DataBoundItem is not null)
            {
                int id = (int)dgvProveedores.CurrentRow.Cells["Id"].Value;
                var proveedor = _context.Proveedores.FirstOrDefault(p => p.Id == id);
                if (proveedor != null && proveedor.Activo)
                {
                    proveedor.Activo = false;
                    _context.SaveChanges();
                    MessageBox.Show("Proveedor eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarProveedores(cbxEstado.SelectedItem?.ToString()== "Inactivos");
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Proveedor no encontrado o dado de baja.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void dgvProveedores_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProveedores.CurrentRow?.DataBoundItem is not null)
            {
                txtNombre.Text = dgvProveedores.CurrentRow.Cells["Nombre"].Value.ToString();
                txtCuit.Text = dgvProveedores.CurrentRow.Cells["Cuit"].Value.ToString();
                txtRubro.Text = dgvProveedores.CurrentRow.Cells["Rubro"].Value.ToString();
                txtTelefono.Text = dgvProveedores.CurrentRow.Cells["Telefono"].Value.ToString();
                txtEmail.Text = dgvProveedores.CurrentRow.Cells["Email"].Value.ToString();
            }
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtCuit.Clear();
            txtRubro.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            dgvProveedores.ClearSelection();
        }

    }
}
