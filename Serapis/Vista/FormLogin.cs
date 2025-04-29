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
using Serapis.Servicios;

namespace Serapis.Vista
{
    public partial class FormLogin : Form
    {
        private readonly SerapisDbContext _context;

        public FormLogin(SerapisDbContext context)
        {
            InitializeComponent();
            _context = context;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string nombre = txtUsuario.Text.Trim();
            string contraseña = HashHelper.CalcularHash(txtContraseña.Text);

            var usuario = _context.Usuarios
                .FirstOrDefault(u => u.Nombre == nombre && u.Contraseña == contraseña);

            if (usuario == null)
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error de autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (usuario.Rol == "Admin")
            {
                var formAdmin = new FormAdmin(_context, usuario);
                formAdmin.Show();
            }
            else if (usuario.Rol == "Empleado")
            {
                var formEmpleado = new FormEmpleado(_context, usuario);
                formEmpleado.Show();
            }
            else
            {
                MessageBox.Show("Rol de usuario no reconocido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.Hide();
        }

    }
}
