using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Serapis.Servicios;
using Serapis.Datos;
using Serapis.Modelo;
using Serapis.Controladores;

namespace Serapis.Vista
{
    public partial class LoginControl : UserControl
    {
        private readonly UsuarioController _usuarioController;

        // Evento que notifica login exitoso
        public event Action<Usuario>? LoginExitoso;

        public LoginControl(UsuarioController usuarioController)
        {
            InitializeComponent();
            _usuarioController = usuarioController;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtUsuario.Text.Trim();
            string contraseña = txtContraseña.Text;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(contraseña))
            {
                MessageBox.Show("Complete todos los campos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var usuario = _usuarioController.ObtenerUsuarios()
                                          .FirstOrDefault(u => u.Email.Equals(email, StringComparison.OrdinalIgnoreCase) && u.Activo);

            if (usuario == null)
            {
                MessageBox.Show("Usuario no encontrado o inactivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!HashHelper.VerificarHash(contraseña, usuario.ContraseñaHash))
            {
                MessageBox.Show("Contraseña incorrecta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SesionActual.UsuarioLogueado = usuario;

            SesionActual.UsuarioId = usuario.Id;
            SesionActual.NombreUsuario = usuario.Nombre;
            SesionActual.Rol = usuario.Rol;

            // Login exitoso
            LoginExitoso?.Invoke(usuario);
        }

        private void txtUsuario_Click(object sender, EventArgs e)
        {
            lblError.Visible = false;
        }

        private void txtContraseña_Click(object sender, EventArgs e)
        {
            lblError.Visible = false;
        }
    }
}
