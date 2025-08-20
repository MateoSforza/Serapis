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
    public partial class PanelConfiguracionControl : UserControl
    {
        private readonly Usuario _usuario;
        private readonly ConfiguracionController _controller;


        public PanelConfiguracionControl(Usuario usuario, SerapisDbContext context)
        {
            InitializeComponent();
            _usuario = usuario;
            _controller = new ConfiguracionController(context);

            CargarDatosUsuario();
        }

        private void CargarDatosUsuario()
        {
            lblNombre.Text = _usuario.Nombre;
            lblRol.Text = _usuario.Rol;
        }

        private void btnCambiarContraseña_Click(object sender, EventArgs e)
        {
            var nuevaPass = txtCambiar.Text.Trim();
            var confirmarPass = txtConfirmar.Text.Trim();

            if (string.IsNullOrWhiteSpace(nuevaPass))
            {
                MessageBox.Show("La contraseña no puede estar vacía");
                return;
            }

            if (nuevaPass != confirmarPass)
            {
                MessageBox.Show("Las contraseñas no coinciden");
                return;
            }

            try
            {
                _controller.CambiarContraseña(_usuario.Id, nuevaPass);
                MessageBox.Show("Contraseña actualizada correctamente");
                txtCambiar.Clear();
                txtConfirmar.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
