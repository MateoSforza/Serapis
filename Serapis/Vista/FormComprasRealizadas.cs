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
            CargarCompras();
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
        }

        private void btnVerDetalle_Click(object sender, EventArgs e)
        {
            if(dgvCompras.SelectedRows.Count== 0)
            {
                MessageBox.Show("Por favor, seleccione una compra para ver los detalles.");
                return;
            }

            int idCompra = (int)dgvCompras.SelectedRows[0].Cells["ID"].Value;

            var compra = _context.Compras
                .Include(c => c.ItemsCompra)
                .ThenInclude(i => i.Producto)
                .FirstOrDefault(c => c.Id == idCompra);

            if(compra!= null)
            {
                string detalle = $"Compra #{compra.Id} - {compra.Fecha:dd/MM/yyyy}\n\n";
                foreach(var item in compra.ItemsCompra)
                {
                    detalle += $"- {item.Producto.Nombre} x{item.Cantidad}\n";
                }

                MessageBox.Show(detalle, "Detalle de Compra");
            }
        }
    }
}
