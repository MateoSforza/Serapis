using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serapis.Datos;
using Serapis.Modelo;

namespace Serapis.Controladoras
{
    public class LaboratorioController
    {
        private readonly SerapisDbContext _context;

        public LaboratorioController(SerapisDbContext context)
        {
            _context = context;
        }

        public List<Producto> ObtenerProductos()
        {
            return _context.Productos.Where(p => p.Activo).ToList();
        }

        public void RegistrarProducto(string nombre, string codigo, decimal precio, int stock, DateTime fechaVencimiento, string laboratorio, bool requiereReceta)
        {
            var producto = new Producto
            {
                Nombre = nombre,
                Codigo = codigo,
                Precio = precio,
                Stock = stock,
                FechaVencimiento = fechaVencimiento,
                Laboratorio = laboratorio,
                RequiereReceta = requiereReceta,
                Activo = true
            };

            _context.Productos.Add(producto);
            _context.SaveChanges();
        }

        public void DesactivarProducto(int productoId)
        {
            var producto = _context.Productos.FirstOrDefault(p => p.Id == productoId);
            if (producto != null)
            {
                producto.Activo = false;
                _context.SaveChanges();
            }
        }
    }
}
