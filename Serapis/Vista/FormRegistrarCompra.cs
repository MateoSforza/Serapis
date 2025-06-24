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
    public partial class FormRegistrarCompra : Form
    {
        private readonly SerapisDbContext _context;
        private List<ItemCompra> itemsEnCompra = new();

        public FormRegistrarCompra(SerapisDbContext context)
        {
            InitializeComponent();
            _context = context;
            CargarProveedores();
            CargarProductos();
        }

        private void CargarProveedores()
        {
            var proveedores = _context.Proveedores.ToList();
            cmbProveedor.DataSource = proveedores;
            cmbProveedor.DisplayMember = "Nombre";
            cmbProveedor.ValueMember = "Id";
        }

        private void CargarProductos()
        {
            var productos = _context.Productos.ToList();
            cmbProducto.DataSource = productos;
            cmbProducto.DisplayMember = "Nombre";
            cmbProducto.ValueMember = "Id";
        }

        private void btnAgregarItem_Click(object sender, EventArgs e)
        {
            if (cmbProducto.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un producto.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var producto = (Producto)cmbProducto.SelectedItem;
            int cantidad = (int)nudCantidad.Value;

            if (cantidad <= 0)
            {
                MessageBox.Show("La cantidad debe ser mayor a cero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var existente = itemsEnCompra.FirstOrDefault(i => i.ProductoId == producto.Id);
            if (existente != null)
            {
                existente.Cantidad += cantidad;
            }
            else
            {
                itemsEnCompra.Add(new ItemCompra
                {
                    ProductoId = producto.Id,
                    Producto = producto,
                    Cantidad = cantidad,
                });
            }

            ActualizarListaItems();
            nudCantidad.Value = 1;
        }

        private void ActualizarListaItems()
        {
            dgvItems.DataSource = null;
            dgvItems.DataSource = itemsEnCompra.Select(i => new
            {
                Producto = i.Producto.Nombre,
                Cantidad = i.Cantidad
            }).ToList();
        }

        private void btnRegistrarCompra_Click(object sender, EventArgs e)
        {
            if(cmbProveedor.SelectedItem== null || itemsEnCompra.Count==0)
            {
                MessageBox.Show("Seleccione un proveedor y agregue al menos un producto.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var proveedor = (Proveedor)cmbProveedor.SelectedItem;

            var compra = new Compra
            {
                ProveedorId = proveedor.Id,
                Fecha = DateTime.Now,
                ItemsCompra = new List<ItemCompra>()
            };

            foreach (var item in itemsEnCompra)
            {
                var productoDb= _context.Productos.FirstOrDefault(p => p.Id == item.ProductoId);
                if(productoDb!= null)
                {
                    productoDb.Stock += item.Cantidad; // Actualizar stock del producto
                }

                compra.ItemsCompra.Add(new ItemCompra
                {
                    ProductoId = item.ProductoId,
                    Cantidad = item.Cantidad,
                });
            }

            _context.Compras.Add(compra);
            _context.SaveChanges();

            MessageBox.Show("Compra registrada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
            itemsEnCompra.Clear();
            ActualizarListaItems();
            cmbProveedor.SelectedIndex = 0;
            cmbProducto.SelectedIndex = 0;
            nudCantidad.Value = 1;
        }

    }
}
