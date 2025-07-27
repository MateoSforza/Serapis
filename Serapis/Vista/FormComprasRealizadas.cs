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
using Microsoft.EntityFrameworkCore;

namespace Serapis.Vista
{
    public partial class FormComprasRealizadas : Form
    {
        private readonly SerapisDbContext _context;

        public FormComprasRealizadas(SerapisDbContext context)
        {
            InitializeComponent();
            _context = context;
            CargarProveedores();
            CargarProductos();
            CargarCompras();
        }


        private void CargarProveedores()
        {
            cbxProveedores.DataSource = _context.Proveedores.ToList();
            cbxProveedores.DisplayMember = "Nombre";
            cbxProveedores.ValueMember = "Id";
            cbxProveedores.SelectedIndex = -1;
        }

        private void CargarProductos()
        {
            var productos = _context.Productos
                .Where(p => p.Activo)
                .Select(p => new
                {
                    p.Id,
                    p.Nombre,
                    PrecioUnitario = p.Precio,
                    Cantidad = 0
                }).ToList();

            dgvProductosCompra.DataSource = productos;
            dgvProductosCompra.Columns["Id"].Visible = false;
            dgvProductosCompra.Columns["Cantidad"].ReadOnly = false;
            dgvProductosCompra.Columns["PrecioUnitario"].ReadOnly = false;
            dgvProductosCompra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void btnVerDetalle_Click(object sender, EventArgs e)
        {
            if (dgvCompras.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione una compra para ver los detalles.");
                return;
            }

            int idCompra = (int)dgvCompras.SelectedRows[0].Cells["ID"].Value;

            var compra = _context.Compras
                .Include(c => c.ItemsCompra)
                .ThenInclude(i => i.Producto)
                .FirstOrDefault(c => c.Id == idCompra);

            if (compra != null)
            {
                string detalle = $"Compra #{compra.Id} - {compra.Fecha:dd/MM/yyyy}\nProveedor: {compra.Proveedor?.Nombre}\n\n";
                foreach (var item in compra.ItemsCompra)
                {
                    detalle += $"- {item.Producto.Nombre} x{item.Cantidad} u. (${item.PrecioUnitario} c/u)\n";
                }

                MessageBox.Show(detalle, "Detalle de Compra", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRegistrarCompra_Click(object sender, EventArgs e)
        {
            if (cbxProveedores.SelectedItem is not Proveedor proveedor)
            {
                MessageBox.Show("Por favor, seleccione un proveedor.");
                return;
            }

            var items = new List<ItemCompra>();
            foreach (DataGridViewRow row in dgvProductosCompra.Rows)
            {
                int cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);
                if (cantidad > 0)
                {
                    int productoId = Convert.ToInt32(row.Cells["Id"].Value);
                    decimal precioUnitario = Convert.ToDecimal(row.Cells["PrecioUnitario"].Value);
                    items.Add(new ItemCompra
                    {
                        ProductoId = productoId,
                        Cantidad = cantidad,
                        PrecioUnitario = precioUnitario
                    });

                    var producto = _context.Productos.Find(productoId);
                    producto.Stock += cantidad;
                }
            }

            if (!items.Any())
            {
                MessageBox.Show("Debe agregar al menos un producto a la compra.");
                return;
            }

            var compra = new Compra
            {
                Fecha = DateTime.Now,
                ProveedorId = proveedor.Id,
                ItemsCompra = items
            };

            _context.Compras.Add(compra);
            _context.SaveChanges();

            MessageBox.Show("Compra registrada exitosamente.");
            CargarCompras();
            CargarProductos();

            cbxProveedores.SelectedIndex = -1;
            foreach (DataGridViewRow row in dgvProductosCompra.Rows)
            {
                row.Cells["Cantidad"].Value = 0;
            }

        }

        private void CargarCompras()
        {
            var compras = _context.Compras
                .Include(c => c.Proveedor)
                .Include(c => c.ItemsCompra)
                .ThenInclude(i => i.Producto)
                .OrderByDescending(c => c.Fecha)
                .ToList();

            dgvCompras.DataSource = compras.Select(c => new
            {
                ID = c.Id,
                Fecha = c.Fecha.ToString("dd/MM/yyyy HH:mm"),
                Proveedor = c.Proveedor.Nombre,
                CantidadItems = c.ItemsCompra.Count
            }).ToList();

            dgvCompras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCompras.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCompras.ReadOnly = true;
            dgvCompras.MultiSelect = false;
        }

        private void btnFiltroFecha_Click(object sender, EventArgs e)
        {
            DateTime desde= dtpDesde.Value.Date;
            DateTime hasta = dtpHasta.Value.Date.AddDays(1).AddTicks(-1);

            var compras=_context.Compras
                .Include(c => c.Proveedor)
                .Include(c => c.ItemsCompra)
                .ThenInclude(i => i.Producto)
                .Where(c => c.Fecha >= desde && c.Fecha <= hasta)
                .OrderByDescending(c => c.Fecha)
                .ToList();

            dgvCompras.DataSource = compras.Select(c => new
            {
                ID = c.Id,
                Fecha = c.Fecha.ToString("dd/MM/yyyy HH:mm"),
                Proveedor = c.Proveedor.Nombre,
                CantidadItems = c.ItemsCompra.Count
            }).ToList();
        }
    }
}
