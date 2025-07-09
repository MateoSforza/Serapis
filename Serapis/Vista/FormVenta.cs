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
    public partial class FormVenta : Form
    {
        private readonly SerapisDbContext _context;

        public FormVenta(SerapisDbContext context)
        {
            InitializeComponent();
            _context = context;
            CargarClientes();
            CargarProductos();
        }

        private void CargarClientes()
        {
            var clientes = _context.Clientes
                .Select(c => new
                {
                    c.Id,
                    NombreCompleto = c.Nombre + " " + c.Apellido
                })
                .ToList();

            cbxCliente.DataSource = clientes;
            cbxCliente.DisplayMember = "NombreCompleto";
            cbxCliente.ValueMember = "Id";
            cbxCliente.SelectedIndex = -1; // Ninguno seleccionado por defecto
        }

        private void CargarProductos()
        {
            var productos = _context.Productos
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

            dgvProductos.DataSource = productos;
            dgvProductos.Columns["Id"].Visible = false;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void FormVenta_Load(object sender, EventArgs e)
        {
            cbxCliente.DataSource = _context.Clientes.ToList();
            cbxCliente.DisplayMember = "Nombre";
            cbxCliente.ValueMember = "Id";

            dgvProductos.Columns.Add("Producto", "Producto");
            dgvProductos.Columns.Add("Cantidad", "Cantidad");
            dgvProductos.Columns.Add("PrecioUnitario", "Precio unitario");


        }

        private void btnRegistrarVenta_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Validación de cliente (puede ser opcional)
                int? clienteId = cbxCliente.SelectedValue as int?;

                // 2. Validación de receta
                string recetaTexto = txtReceta.Text.Trim();

                // 3. Obtener productos seleccionados del DataGridView
                var itemsVenta = new List<ItemVenta>();
                decimal total = 0;

                foreach (DataGridViewRow row in dgvProductos.Rows)
                {
                    if (row.IsNewRow) continue;

                    var productoId = Convert.ToInt32(row.Cells["Id"].Value);
                    var cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);

                    var producto = _context.Productos.FirstOrDefault(p => p.Id == productoId);
                    if (producto == null)
                    {
                        MessageBox.Show("Producto no encontrado.");
                        return;
                    }

                    // 4. Validar stock
                    if (producto.Stock < cantidad)
                    {
                        MessageBox.Show($"Stock insuficiente para {producto.Nombre}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // 5. Validar receta si es obligatoria
                    if (producto.RequiereReceta && string.IsNullOrEmpty(recetaTexto))
                    {
                        MessageBox.Show($"El producto {producto.Nombre} requiere una receta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // 6. Armar item
                    var item = new ItemVenta
                    {
                        ProductoId = producto.Id,
                        Cantidad = cantidad,
                        PrecioUnitario = producto.Precio
                    };

                    itemsVenta.Add(item);
                    total += producto.Precio * cantidad;
                }

                if (itemsVenta.Count == 0)
                {
                    MessageBox.Show("No se han agregado productos.");
                    return;
                }

                // 7. Crear venta
                var nuevaVenta = new Venta
                {
                    ClienteId = clienteId, // Puede ser null
                    Fecha = DateTime.Now,
                    Total = total,
                    Receta = recetaTexto,
                    ItemsVenta = itemsVenta
                };

                // 8. Guardar en la base de datos
                _context.Ventas.Add(nuevaVenta);

                // 9. Actualizar stock
                foreach (var item in itemsVenta)
                {
                    var prod = _context.Productos.First(p => p.Id == item.ProductoId);
                    prod.Stock -= item.Cantidad;
                }

                _context.SaveChanges();
                MessageBox.Show("Venta registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void LimpiarFormulario()
        {
            cbxCliente.SelectedIndex = -1;
            txtReceta.Clear();
            dgvProductos.DataSource = null;
            CargarProductos();
        }

    }
}
