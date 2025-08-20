using Serapis.Controladores;
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
    public partial class PanelUsuariosControl : UserControl
    {
        private readonly UsuarioController _usuarioController;
        private List<Usuario> _usuarios;

        public PanelUsuariosControl(UsuarioController usuarioController)
        {
            InitializeComponent();
            _usuarioController = usuarioController;
            _usuarios = new List<Usuario>();
            CargarUsuarios();
        }

        private void CargarUsuarios()
        {
            _usuarios = _usuarioController.ObtenerUsuarios();
            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = _usuarios;

            if (dgvUsuarios.Columns["ContraseñaHash"] != null)
                dgvUsuarios.Columns["ContraseñaHash"].Visible = false;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            var nombre = txtNombre.Text.Trim();
            var email= txtEmail.Text.Trim();
            var contraseña = txtContraseña.Text;
            var rol = cbxRol.SelectedItem?.ToString() ?? "Empleado";

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(contraseña))
            {
                MessageBox.Show("Complete todos los campos.");
                return;
            }

            _usuarioController.RegistrarUsuario(nombre, email, contraseña, rol);
            LimpiarFormulario();
            CargarUsuarios();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                int id = (int)dgvUsuarios.SelectedRows[0].Cells["Id"].Value;
                _usuarioController.EliminarUsuario(id); // baja lógica
                CargarUsuarios();
            }
        }

        private void LimpiarFormulario()
        {
            txtNombre.Text = "";
            txtEmail.Text = "";
            txtContraseña.Text = "";
            cbxRol.SelectedIndex = -1;
        }
    }
}
