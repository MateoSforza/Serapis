using Microsoft.EntityFrameworkCore;
using Serapis.Data;
using Serapis.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serapis.Controladoras
{
    public class CompraController
    {
        private readonly SerapisDbContext _context;

        public CompraController(SerapisDbContext context)
        {
            _context = context;
        }

        // Obtener proveedores activos
        public List<Proveedor> ObtenerProveedores()
        {
            return _context.Proveedores
                           .Where(p => p.Activo)
                           .ToList();
        }

        // Obtener productos activos
        public List<Producto> ObtenerProductos()
        {
            return _context.Productos
                           .Where(p => p.Activo)
                           .ToList();
        }

        // Registrar una compra
        public void RegistrarCompra(int proveedorId, DateTime fecha, List<CompraDetalle> detalles)
        {
            if (detalles == null || !detalles.Any())
                throw new ArgumentException("La compra no puede estar vacía.");

            foreach (var detalle in detalles)
            {
                detalle.Subtotal = detalle.Cantidad * detalle.PrecioUnitario;

                // Actualizar stock del producto
                var producto = _context.Productos.FirstOrDefault(p => p.Id == detalle.ProductoId);
                if (producto != null)
                {
                    producto.Stock += detalle.Cantidad;
                }
            }

            // Crear la compra
            var compra = new Compra
            {
                ProveedorId = proveedorId,
                Fecha = fecha,
                Total = detalles.Sum(d => d.Subtotal),
                Detalles = detalles
            };

            _context.Compras.Add(compra);
            _context.SaveChanges();
        }

        public List<Compra> ObtenerCompras(int? proveedorId = null, DateTime? desde = null, DateTime? hasta = null)
        {
            var query = _context.Compras
                                .Include(c => c.Proveedor)
                                .Include(c => c.Detalles)
                                .ThenInclude(d => d.Producto)
                                .AsQueryable();

            if (proveedorId.HasValue)
                query = query.Where(c => c.ProveedorId == proveedorId.Value);

            if (desde.HasValue)
                query = query.Where(c => c.Fecha >= desde.Value);

            if (hasta.HasValue)
                query = query.Where(c => c.Fecha <= hasta.Value);

            return query.ToList();
        }

        public List<CompraDetalle> ObtenerDetalleCompra(int compraId)
        {
            return _context.Compras
                           .Include(c => c.Detalles)
                           .ThenInclude(d => d.Producto)
                           .FirstOrDefault(c => c.Id == compraId)?
                           .Detalles
                           .ToList() ?? new List<CompraDetalle>();
        }
    }
}
