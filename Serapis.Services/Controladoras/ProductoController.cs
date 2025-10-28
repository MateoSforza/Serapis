using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serapis.Data;
using Serapis.Modelo;

namespace Serapis.Controladoras
{
    public class ProductoController
    {
        private readonly SerapisDbContext _context;

        public ProductoController(SerapisDbContext context)
        {
            _context = context;
        }

        public List<Producto> ObtenerProductos(string filtro = "")
        {
            return _context.Productos
                .Where(p => string.IsNullOrEmpty(filtro) ||
                            p.Nombre.Contains(filtro) ||
                            p.Codigo.Contains(filtro))
                .OrderBy(p => p.Nombre)
                .ToList();
        }

        public Producto? ObtenerProductoPorId(int id)
        {
            return _context.Productos.Find(id);
        }

        public string AgregarProducto(Producto producto)
        {
            try
            {
                _context.Productos.Add(producto);
                _context.SaveChanges();
                return "OK";
            }
            catch (Exception ex)
            {
                return $"Error al agregar el producto: {ex.Message}";
            }
        }

        // 📌 Modificar producto existente
        public string ModificarProducto(Producto producto)
        {
            try
            {
                var prodExistente = _context.Productos.Find(producto.Id);
                if (prodExistente == null) return "Producto no encontrado.";

                prodExistente.Nombre = producto.Nombre;
                prodExistente.Codigo = producto.Codigo;
                prodExistente.Precio = producto.Precio;
                prodExistente.Stock = producto.Stock;
                prodExistente.Laboratorio = producto.Laboratorio;
                prodExistente.FechaVencimiento = producto.FechaVencimiento;
                prodExistente.RequiereReceta = producto.RequiereReceta;
                prodExistente.Activo = producto.Activo;

                _context.SaveChanges();
                return "OK";
            }
            catch (Exception ex)
            {
                return $"Error al modificar el producto: {ex.Message}";
            }
        }

        // 📌 Baja lógica (Activo = false)
        public string BajaLogicaProducto(int productoId)
        {
            try
            {
                var prod = _context.Productos.Find(productoId);
                if (prod == null) return "Producto no encontrado.";

                prod.Activo = false;
                _context.SaveChanges();
                return "OK";
            }
            catch (Exception ex)
            {
                return $"Error al desactivar el producto: {ex.Message}";
            }
        }
    }
}
