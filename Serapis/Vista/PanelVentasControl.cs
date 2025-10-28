using Microsoft.EntityFrameworkCore;
using Serapis.Controladores;
using Serapis.Data;
using Serapis.Modelo;
using Serapis.Servicios;
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
    public partial class PanelVentasControl : UserControl
    {
        private readonly VentaController _ventaController;
        private readonly Usuario _usuario;
        private readonly SerapisDbContext _context;
        private List<ItemVenta> carrito = new List<ItemVenta>();

        public PanelVentasControl(SerapisDbContext context, Usuario usuario)
        {
            InitializeComponent();
            _usuario = usuario;
            _context = context;
            _ventaController = new VentaController(context);

            CargarClientes();
            CargarProductos();

            chkRequiereReceta.CheckedChanged += chkRequiereReceta_CheckedChanged;
            lblReceta.Visible = false;
            txtReceta.Visible = false;
        }

        private void CargarClientes()
        {
            var clientes = _ventaController.ObtenerClientesActivos()
                .Select(c => new { c.Id, NombreCompleto = c.Nombre + " " + c.Apellido })
                .ToList();
            cbxCliente.DataSource = clientes;
            cbxCliente.DisplayMember = "NombreCompleto";
            cbxCliente.ValueMember = "Id";
            cbxCliente.SelectedIndex = -1;
        }

        private void CargarProductos(string filtro = "")
        {
            var productos = _ventaController.ObtenerProductos(filtro)
                .Select(p => new
                {
                    p.Id,
                    p.Nombre,
                    p.Codigo,
                    p.Precio,
                    p.Stock,
                    p.RequiereReceta
                }).ToList();
            dgvCatalogo.DataSource = productos;

            if (dgvCatalogo.Columns["Id"] != null)
                dgvCatalogo.Columns["Id"].Visible = false;

            dgvCatalogo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarProductos(txtBuscar.Text.Trim());
        }

        private void dgvCatalogo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int productoId = Convert.ToInt32(dgvCatalogo.Rows[e.RowIndex].Cells["Id"].Value);
            var producto = _ventaController.ObtenerProductoPorId(productoId);
            if (producto == null) return;

            using var formCantidad = new FormCantidad(producto.Stock);
            if (formCantidad.ShowDialog() == DialogResult.OK)
            {
                int cantidad = formCantidad.CantidadSeleccionada;

                if (!_ventaController.ValidarStock(producto, cantidad))
                {
                    MessageBox.Show("No hay suficiente stock.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!_ventaController.ValidarReceta(producto, chkRequiereReceta.Checked))
                {
                    MessageBox.Show($"El producto {producto.Nombre} requiere receta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                carrito.Add(new ItemVenta
                {
                    ProductoId = productoId,
                    Cantidad = cantidad,
                    PrecioUnitario = producto.Precio
                });

                CargarDetalle();
            }
        }

        private void CargarDetalle()
        {
            var detalle = carrito.Select(item =>
            {
                var producto = _ventaController.ObtenerProductoPorId(item.ProductoId);
                return new
                {
                    producto!.Id,
                    producto.Nombre,
                    item.Cantidad,
                    item.PrecioUnitario,
                    Subtotal = item.Cantidad * item.PrecioUnitario
                };
            }).ToList();

            dgvCarrito.DataSource = detalle;

            if (dgvCarrito.Columns["Id"] != null)
                dgvCarrito.Columns["Id"].Visible = false;

            lblTotal.Text = detalle.Sum(d => d.Subtotal).ToString("C");
        }

        private void btnQuitarProducto_Click(object sender, EventArgs e)
        {
            if (dgvCarrito.CurrentRow != null)
            {
                int prodId = (int)dgvCarrito.CurrentRow.Cells["Id"].Value;
                carrito.RemoveAll(c => c.ProductoId == prodId);
                CargarDetalle();
            }
        }

        private void btnConfirmarVenta_Click(object sender, EventArgs e)
        {
            if (!carrito.Any())
            {
                MessageBox.Show("No hay productos en el carrito.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int? clienteId = cbxCliente.SelectedIndex >= 0 ? (int?)cbxCliente.SelectedValue : null;
            string? recetaTexto = chkRequiereReceta.Checked ? txtReceta.Text.Trim() : null;

            var (resultado, _) = _ventaController.RegistrarVenta(clienteId, carrito, recetaTexto);

            if (resultado == "OK")
            {
                MessageBox.Show("Venta registrada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
            }
            else
            {
                MessageBox.Show(resultado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarFormulario()
        {
            cbxCliente.SelectedIndex = -1;
            txtReceta.Clear();
            chkRequiereReceta.Checked = false;
            carrito.Clear();
            CargarDetalle();
            CargarProductos();
        }

        private void chkRequiereReceta_CheckedChanged(object sender, EventArgs e)
        {
            lblReceta.Visible = chkRequiereReceta.Checked;
            txtReceta.Visible = chkRequiereReceta.Checked;
        }

        private void btnFacturar_Click(object? sender, EventArgs e)
        {
            if (!carrito.Any())
            {
                MessageBox.Show("No hay productos en el carrito.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int? clienteId = cbxCliente.SelectedIndex >= 0 ? (int?)cbxCliente.SelectedValue : null;
            string? recetaTexto = chkRequiereReceta.Checked ? txtReceta.Text.Trim() : null;

            var (resultado, ventaId) = _ventaController.RegistrarVenta(clienteId, carrito, recetaTexto);
            if (resultado != "OK" || ventaId == null)
            {
                MessageBox.Show(resultado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using var frm = new FormFacturar(_context, ventaId.Value, clienteId);
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();

            LimpiarFormulario();
        }
    }
}