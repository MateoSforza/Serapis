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


namespace Serapis.Vista
{
    public partial class FormClientes : Form
    {
        private readonly SerapisDbContext _context;

        public FormClientes(SerapisDbContext context)
        {
            InitializeComponent();
            _context = context;
            cbxInactivos.Items.Add("Activos");
            cbxInactivos.Items.Add("Inactivos");
            cbxInactivos.SelectedIndex = 0; // Por defecto, mostrar solo activos
            CargarClientes();
        }

        private void CargarClientes(bool incluirInactivos = false)
        {
            var clientes = incluirInactivos
                ? _context.Clientes.ToList()
                : _context.Clientes.Where(c => c.Activo).ToList();

            dgvClientes.DataSource = null;
            dgvClientes.DataSource = clientes.Select(c => new
                {
                    c.Id,
                    c.Nombre,
                    c.Apellido,
                    c.Telefono,
                    c.Email,
                    c.ObraSocial,
                    Estado = c.Activo ? "Activo" : "Inactivo"
                })
                .ToList();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var cliente = new Cliente
            {
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Telefono = txtTelefono.Text,
                Email = txtEmail.Text,
                ObraSocial = txtObraSocial.Text,
                Activo = true
            };

            _context.Clientes.Add(cliente);
            _context.SaveChanges();
            CargarClientes(cbxInactivos.SelectedItem?.ToString()=="Inactivos");
            MessageBox.Show("Cliente agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpiarCampos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow?.DataBoundItem != null)
            {
                int id = (int)dgvClientes.CurrentRow.Cells["Id"].Value;
                var cliente = _context.Clientes.FirstOrDefault(c => c.Id == id);


                if (cliente != null)
                {
                    cliente.Nombre = txtNombre.Text;
                    cliente.Apellido = txtApellido.Text;
                    cliente.Telefono = txtTelefono.Text;
                    cliente.Email = txtEmail.Text;
                    cliente.ObraSocial = txtObraSocial.Text;

                    _context.SaveChanges();
                    CargarClientes(cbxInactivos.SelectedItem?.ToString() == "Inactivos");
                    LimpiarCampos();
                    MessageBox.Show("Cliente modificado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow?.DataBoundItem != null)
            {
                int id = (int)dgvClientes.CurrentRow.Cells["Id"].Value;
                var cliente = _context.Clientes.FirstOrDefault(c => c.Id == id);

                if (cliente != null && cliente.Activo)
                {
                    cliente.Activo = false;
                    _context.SaveChanges();
                    MessageBox.Show("Cliente eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarClientes(cbxInactivos.SelectedItem?.ToString() == "Inactivos");
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("El cliente ya está dado de baja.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvClientes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow?.DataBoundItem is not null)
            {
                txtNombre.Text = dgvClientes.CurrentRow.Cells["Nombre"].Value?.ToString();
                txtApellido.Text = dgvClientes.CurrentRow.Cells["Apellido"].Value?.ToString();
                txtTelefono.Text = dgvClientes.CurrentRow.Cells["Telefono"].Value?.ToString();
                txtEmail.Text = dgvClientes.CurrentRow.Cells["Email"].Value?.ToString();
                txtObraSocial.Text = dgvClientes.CurrentRow.Cells["ObraSocial"].Value?.ToString();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e) => LimpiarCampos();

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            txtObraSocial.Clear();
            dgvClientes.ClearSelection();
        }

        private void cbxInactivos_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool mostrarInactivos = cbxInactivos.SelectedItem?.ToString() == "Inactivos";
            CargarClientes(mostrarInactivos);
        }
    }
}
