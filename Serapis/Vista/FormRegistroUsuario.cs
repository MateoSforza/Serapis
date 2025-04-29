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
    public partial class FormRegistroUsuario : Form
    {
        private readonly SerapisDbContext _context;

        public FormRegistroUsuario(SerapisDbContext context)
        {
            InitializeComponent();
            _context = context;

            cbxRol.Items.Add("Empleado");
            cbxRol.Items.Add("Admin");
            cbxRol.SelectedIndex = 0; // Selecciona el primer elemento por defecto
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string nombre = txtUsuario.Text.Trim();
            string contraseña = txtContraseña.Text;
            string rol = cbxRol.SelectedItem.ToString();

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(contraseña))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(_context.Usuarios.Any(u => u.Nombre == nombre))
            {
                MessageBox.Show("El nombre de usuario ya existe. Por favor, elija otro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var nuevoUsuario= new Usuario
            {
                Nombre = nombre,
                Contraseña = HashHelper.CalcularHash(contraseña),
                Rol = rol
            };

            _context.Usuarios.Add(nuevoUsuario);
            _context.SaveChanges();

            MessageBox.Show($"Usuario '{nombre}' registrado como '{rol}'.");
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtUsuario.Clear();
            txtContraseña.Clear();
            cbxRol.SelectedIndex = 0; // Resetea al primer elemento
        }
    }
}
