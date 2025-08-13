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
    public partial class FormVenta : Form
    {
        private readonly SerapisDbContext _context;
        private List<ItemVenta> carrito = new List<ItemVenta>();

        public FormVenta(SerapisDbContext context)
        {
            InitializeComponent();
            _context = context;
            CargarClientes();
            CargarProductos();

            chkRequiereReceta.CheckedChanged += chkRequiereReceta_CheckedChanged;
            lblReceta.Visible = false;
            txtReceta.Visible = false;
        }

        private void CargarClientes()
        {
            var clientes = _context.Clientes
                .Where(c => c.Activo)
                .Select(c => new
                {
                    c.Id,
                    NombreCompleto = c.Nombre + " " + c.Apellido
                })
                .ToList();

            cbxCliente.DataSource = clientes;
            cbxCliente.DisplayMember = "NombreCompleto";
            cbxCliente.ValueMember = "Id";
            cbxCliente.SelectedIndex = -1;
        }

        private void CargarProductos(string filtro = "")
        {
            var productos = _context.Productos
                .Where(p => p.Activo &&
                            (string.IsNullOrEmpty(filtro) ||
                             p.Nombre.Contains(filtro) ||
                             p.Codigo.Contains(filtro)))
                .Select(p => new
                {
                    p.Id,
                    p.Nombre,
                    p.Codigo,
                    p.Precio,
                    p.Stock,
                    p.RequiereReceta
                })
                .ToList();

            dgvCatalogo.DataSource = productos;
            dgvCatalogo.Columns["Id"].Visible = false;
            dgvCatalogo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarProductos(txtBuscar.Text.Trim());
        }
    
        private void LimpiarFormulario()
        {
            cbxCliente.SelectedIndex = -1;
            txtReceta.Clear();
            CargarProductos();
        }

        private void dgvCatalogo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int productoId = Convert.ToInt32(dgvCatalogo.Rows[e.RowIndex].Cells["Id"].Value);
                var producto = _context.Productos.FirstOrDefault(p => p.Id == productoId);
                if (producto == null) return;

                string input = Microsoft.VisualBasic.Interaction.InputBox($"Ingrese la cantidad para {producto.Nombre} (Stock disponible: {producto.Stock}):", "Cantidad del Producto", "1");

                if (int.TryParse(input, out int cantidad) && cantidad > 0)
                {
                    if (cantidad > producto.Stock)
                    {
                        MessageBox.Show("No hay suficiente stock.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (producto.RequiereReceta && !chkRequiereReceta.Checked)
                    {
                        MessageBox.Show($"El producto {producto.Nombre} requiere receta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    var newItem = new ItemVenta
                    {
                        ProductoId = productoId,
                        Cantidad = cantidad,
                        PrecioUnitario = producto.Precio
                    };

                    carrito.Add(newItem);
                    CargarDetalle();
                }
            }
        }

        private void CargarDetalle()
        {
            var detalle = carrito
                .Join(_context.Productos,
                item => item.ProductoId,
                prod => prod.Id,
                (item, prod) => new
                {
                    prod.Id,
                    prod.Nombre,
                    item.Cantidad,
                    item.PrecioUnitario,
                    Subtotal = item.Cantidad * item.PrecioUnitario
                })
                .ToList();

            dgvCarrito.DataSource = detalle;
            dgvCarrito.Columns["Id"].Visible = false;

            lblTotal.Text = detalle.Sum(d => d.Subtotal).ToString("C");
        }

        private void btnQuitarProducto_Click(object sender, EventArgs e)
        {
            if(dgvCarrito.CurrentRow!= null)
            {
                int prodId= (int)dgvCarrito.CurrentRow.Cells["Id"].Value;
                carrito.RemoveAll(c => c.ProductoId == prodId);
                CargarDetalle();
            }
        }
        
        private void btnRegistrarVenta_Click(object sender, EventArgs e)
        {
            try
            {
                if(!carrito.Any())
                {
                    MessageBox.Show("No hay productos en el carrito.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int? clienteId = cbxCliente.SelectedValue as int?;
                string recetaTexto = txtReceta.Text.Trim();

                var venta = new Venta
                {
                    ClienteId = clienteId,
                    Fecha = DateTime.Now,
                    Total = carrito.Sum(c=> c.Cantidad *c.PrecioUnitario),
                    ItemsVenta=carrito.ToList(),
                    Receta = chkRequiereReceta.Checked
                    ? new Receta
                    {
                        Detalle = recetaTexto,
                        Fecha = DateTime.Now
                    }
                    : null
                };

                foreach (var item in carrito)
                {
                    var prod = _context.Productos.First(p => p.Id == item.ProductoId);
                    prod.Stock -= item.Cantidad; // Actualiza el stock del producto
                }

                _context.Ventas.Add(venta);
                _context.SaveChanges();
                MessageBox.Show("Venta registrada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                carrito.Clear(); // Limpia el carrito después de registrar la venta
                CargarDetalle();
                CargarProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar la venta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                LimpiarFormulario();
            }
        }
        
        private void chkRequiereReceta_CheckedChanged(object sender, EventArgs e)
        {
            bool visible = chkRequiereReceta.Checked;
            lblReceta.Visible = visible;
            txtReceta.Visible = visible;
        }
    }
}
