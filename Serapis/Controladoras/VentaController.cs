using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serapis.Modelo;
using Serapis.Datos;
using Serapis.Servicios;

namespace Serapis.Controladores
{
    public class VentaController
    {
        private readonly SerapisDbContext _context;

        public VentaController(SerapisDbContext context)
        {
            _context = context;
        }

        public List<Cliente> ObtenerClientesActivos()
        {
            return _context.Clientes.Where(c => c.Activo).ToList();
        }

        public List<Producto> ObtenerProductos(string filtro = "")
        {
            return _context.Productos
                .Where(p => p.Activo &&
                            (string.IsNullOrEmpty(filtro) ||
                             p.Nombre.Contains(filtro) ||
                             p.Codigo.Contains(filtro)))
                .ToList();
        }

        public Producto? ObtenerProductoPorId(int id)
        {
            return _context.Productos.Find(id);
        }

        public bool ValidarStock(Producto producto, int cantidad)
        {
            if (cantidad > producto.Stock) return false;
            return true;
        }

        // Valida si requiere receta
        public bool ValidarReceta(Producto producto, bool tieneReceta)
        {
            return !producto.RequiereReceta || tieneReceta;
        }

        public string RegistrarVenta(int? clienteId, List<ItemVenta> carrito, string? receta = null)
        {
            if (!carrito.Any())
                return "El carrito está vacío.";

            if(SesionActual.UsuarioLogueado == null)
                return "Usuario no logueado.";

            var venta = new Venta
            {
                Fecha = DateTime.Now,
                ClienteId = clienteId,
                UsuarioId= SesionActual.UsuarioLogueado.Id,
                Total = 0,
                ItemsVenta = new List<ItemVenta>()
            };

            foreach (var item in carrito)
            {
                var producto = _context.Productos.Find(item.ProductoId);
                if (producto == null) return $"Producto con ID {item.ProductoId} no encontrado.";
                if (producto.Stock < item.Cantidad) return $"Stock insuficiente para {producto.Nombre}";

                producto.Stock -= item.Cantidad;

                venta.ItemsVenta.Add(new ItemVenta
                {
                    ProductoId = item.ProductoId,
                    Cantidad = item.Cantidad,
                    PrecioUnitario = item.PrecioUnitario
                });

                venta.Total += item.Cantidad * item.PrecioUnitario;
            }

            if (!string.IsNullOrEmpty(receta))
            {
                venta.Receta = new Receta
                {
                    Detalle = receta,
                    Fecha = DateTime.Now
                };
            }

            _context.Ventas.Add(venta);
            _context.SaveChanges();

            return "OK";
        }
    }
}

