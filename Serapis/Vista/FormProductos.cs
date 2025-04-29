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
using Microsoft.EntityFrameworkCore;

namespace Serapis.Vista
{
    public partial class FormProductos : Form
    {
        private readonly SerapisDbContext _context;
        public FormProductos(SerapisDbContext context)
        {
            InitializeComponent();
            _context = context;
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            var productos= cbxInactivos.Checked
                ? _context.Productos.ToList()
                : _context.Productos.Where(p => p.Activo).ToList();

            dgvProductos.DataSource = productos;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var producto = new Producto
            {
                Nombre = txtNombre.Text,
                Codigo = txtCodigo.Text,
                Precio = decimal.Parse(txtPrecio.Text),
                Stock = int.Parse(txtStock.Text),
                FechaVencimiento = dtpFdv.Value,
                Laboratorio = txtLaboratorio.Text
            };

            _context.Productos.Add(producto);
            _context.SaveChanges();
            MessageBox.Show("Producto agregado correctamente.");
            btnCargar.PerformClick();
            LimpiarCampos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow?.DataBoundItem is Producto seleccionado)
            {
                var producto = _context.Productos.First(p => p.Id == seleccionado.Id);

                producto.Nombre = txtNombre.Text;
                producto.Codigo = txtCodigo.Text;
                producto.Precio = decimal.Parse(txtPrecio.Text);
                producto.Stock = int.Parse(txtStock.Text);
                producto.FechaVencimiento = dtpFdv.Value;
                producto.Laboratorio = txtLaboratorio.Text;

                _context.SaveChanges();
                MessageBox.Show("Producto modificado correctamente.");
                btnCargar.PerformClick();
                LimpiarCampos();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow?.DataBoundItem is Producto seleccionado)
            {
                var producto = _context.Productos.First(p => p.Id == seleccionado.Id);
                producto.Activo = false;
                _context.SaveChanges();
                MessageBox.Show("Producto eliminado correctamente.");
                btnCargar.PerformClick();
                LimpiarCampos();
            }
        }

        private void dgvProductos_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvProductos.CurrentRow?.DataBoundItem is Producto seleccionado)
            {
                txtNombre.Text = seleccionado.Nombre;
                txtCodigo.Text = seleccionado.Codigo;
                txtPrecio.Text = seleccionado.Precio.ToString();
                txtStock.Text = seleccionado.Stock.ToString();
                dtpFdv.Value = seleccionado.FechaVencimiento;
                txtLaboratorio.Text = seleccionado.Laboratorio;
            }
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtCodigo.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
            dtpFdv.Value = DateTime.Today;
            txtLaboratorio.Clear();
        }
    }
}
