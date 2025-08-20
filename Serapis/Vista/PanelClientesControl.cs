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
    public partial class PanelClientesControl : UserControl
    {
        private readonly ClienteController _clienteController;

        public PanelClientesControl(SerapisDbContext context)
        {
            InitializeComponent();
            _clienteController = new ClienteController(context);

            CargarClientes();

            txtBuscar.TextChanged += txtBuscar_TextChanged;
            chkInactivos.CheckedChanged += chkInactivos_CheckedChanged;
        }

        private void CargarClientes(string filtro = "")
        {
            var clientes = _clienteController.ObtenerClientes(filtro);

            if (!chkInactivos.Checked)
                clientes = clientes.Where(c => c.Activo).ToList();

            dgvClientes.DataSource = clientes.Select(c => new
            {
                c.Id,
                NombreCompleto = c.Nombre + " " + c.Apellido,
                c.DNI,
                c.Telefono,
                c.Email,
                Activo = c.Activo ? "Sí" : "No"
            }).ToList();

            if (dgvClientes.Columns["Id"] != null)
                dgvClientes.Columns["Id"].Visible = false;

            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarClientes(txtBuscar.Text.Trim());
        }

        private void chkInactivos_CheckedChanged(object sender, EventArgs e)
        {
            CargarClientes(txtBuscar.Text.Trim());
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var cliente = new Cliente
            {
                Nombre = txtNombre.Text.Trim(),
                Apellido = txtApellido.Text.Trim(),
                DNI = txtDNI.Text.Trim(),
                Telefono = txtTelefono.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                ObraSocial = txtObraSocial.Text.Trim(),
                Activo = true
            };

            string res = _clienteController.AgregarCliente(cliente);
            if (res == "OK")
            {
                MessageBox.Show("Cliente agregado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarClientes();
            }
            else
            {
                MessageBox.Show(res, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow == null) return;

            int id = (int)dgvClientes.CurrentRow.Cells["Id"].Value;
            var cliente = new Cliente
            {
                Id = id,
                Nombre = txtNombre.Text.Trim(),
                Apellido = txtApellido.Text.Trim(),
                DNI = txtDNI.Text.Trim(),
                Telefono = txtTelefono.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                ObraSocial = txtObraSocial.Text.Trim(),
                Activo = true
            };

            string res = _clienteController.ModificarCliente(cliente);
            if (res == "OK")
            {
                MessageBox.Show("Cliente modificado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarClientes();
            }
            else
            {
                MessageBox.Show(res, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow == null) return;

            int id = (int)dgvClientes.CurrentRow.Cells["Id"].Value;
            string res = _clienteController.BajaLogicaCliente(id);
            if (res == "OK")
            {
                MessageBox.Show("Cliente dado de baja.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarClientes();
            }
            else
            {
                MessageBox.Show(res, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow == null) return;

            int id = (int)dgvClientes.CurrentRow.Cells["Id"].Value;
            var cliente = _clienteController.ObtenerClientePorId(id);
            if (cliente != null)
            {
                txtNombre.Text = cliente.Nombre;
                txtApellido.Text = cliente.Apellido;
                txtDNI.Text = cliente.DNI;
                txtTelefono.Text = cliente.Telefono;
                txtEmail.Text = cliente.Email;
                txtObraSocial.Text = cliente.ObraSocial;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtDNI.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            txtBuscar.Clear();
            txtObraSocial.Clear();
        }
    }
}
