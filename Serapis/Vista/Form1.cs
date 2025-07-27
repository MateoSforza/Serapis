using Microsoft.EntityFrameworkCore;
using Serapis.Datos;

namespace Serapis.Vista
{
    public partial class Form1 : Form
    {
        private readonly SerapisDbContext _context;

        public Form1(SerapisDbContext context)
        {
            InitializeComponent();
            _context = context;
        }

        private void btnProductos_Click_1(object sender, EventArgs e)
        {
            var formProductos = new FormProductos(_context);
            formProductos.ShowDialog(); // o .Show() si querés que quede abierto en paralelo
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            var formProveedores = new FormProveedores(_context);
            formProveedores.ShowDialog();
        }
    }
}
