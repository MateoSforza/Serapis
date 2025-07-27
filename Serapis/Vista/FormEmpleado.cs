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
    public partial class FormEmpleado : Form
    {
        private readonly SerapisDbContext _context;
        private readonly Usuario _usuario;

        public FormEmpleado(SerapisDbContext context, Usuario usuario)
        {
            InitializeComponent();
            _context = context;
            _usuario = usuario;
            this.Text = $"Empleado, {_usuario.Nombre}";
            lblNombre.Text = $"Bienvenido, {_usuario.Nombre}";
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            var formClientes = new FormClientes(_context);
            formClientes.ShowDialog();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            var formProductos = new FormProductos(_context);
            formProductos.ShowDialog();
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            var formVenta = new FormVenta(_context);
            formVenta.ShowDialog();
        }

        private void btnRegistrarCompra_Click(object sender, EventArgs e)
        {
            var formRegistrarCompra = new FormRegistrarCompra(_context);
            formRegistrarCompra.ShowDialog();
        }

        private void btnVerCompra_Click(object sender, EventArgs e)
        {
            var formVerCompra = new FormComprasRealizadas(_context);
            formVerCompra.ShowDialog();
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            var formProveedores = new FormProveedores(_context);
            formProveedores.ShowDialog();
        }
    }
}
