using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serapis.Modelo;
using Serapis.Datos;

namespace Serapis.Controladores
{
    public class VentaController
    {
        private readonly SerapisDbContext _context;

        public VentaController(SerapisDbContext context)
        {
            _context = context;
        }

        public string RegistrarVenta(int? clienteId, List<(int productoId, int cantidad)> items, string? receta = null)
        {
            // Validar cliente (opcional)
            Cliente? cliente = null;
            if (clienteId.HasValue)
            {
                cliente = _context.Clientes.Find(clienteId.Value);
                if (cliente == null)
                    return "Cliente no registrado.";
            }

            // Validar productos y stock
            foreach (var item in items)
            {
                var producto = _context.Productos.Find(item.productoId);
                if (producto == null)
                    return $"Producto con ID {item.productoId} no existe.";

                if (producto.Stock < item.cantidad)
                    return $"Stock insuficiente para el producto '{producto.Nombre}'.";
            }

            // Crear la venta
            var nuevaVenta = new Venta
            {
                Fecha = DateTime.Now,
                ClienteId = clienteId,
                Total = 0,
                ItemsVenta = new List<ItemVenta>()
            };

            foreach (var item in items)
            {
                var producto = _context.Productos.Find(item.productoId)!;

                var nuevoItem = new ItemVenta
                {
                    ProductoId = producto.Id,
                    Cantidad = item.cantidad,
                    PrecioUnitario = producto.Precio
                };

                nuevaVenta.ItemsVenta.Add(nuevoItem);
                producto.Stock -= item.cantidad;
                nuevaVenta.Total += producto.Precio * item.cantidad;
            }

            // (Opcional) asociar receta
            if (!string.IsNullOrEmpty(receta))
            {
                nuevaVenta.Receta = new Receta
                {
                    Detalle = receta,
                    Fecha = DateTime.Now
                };
            }

            _context.Ventas.Add(nuevaVenta);
            _context.SaveChanges();

            return "OK";
        }
    }
}

