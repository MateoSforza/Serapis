using Serapis.Datos;
using Serapis.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serapis.Controladoras
{
    public class ProveedoresController
    {
        private readonly SerapisDbContext _context;

        public ProveedoresController(SerapisDbContext context)
        {
            _context = context;
        }

        public List<Proveedor> ObtenerProveedoresActivos()
        {
            return _context.Proveedores
                .Where(p => p.Activo)
                .ToList();
        }

        public Proveedor? ObtenerProveedorPorId(int id)
        {
            return _context.Proveedores
                .FirstOrDefault(p => p.Id == id);
        }

        public string AgregarProveedor(Proveedor proveedor)
        {
            if(string.IsNullOrWhiteSpace(proveedor.Nombre))
                return "El nombre del proveedor no puede estar vacío.";

            proveedor.Activo = true;
            _context.Proveedores.Add(proveedor);
            _context.SaveChanges();
            return "Proveedor agregado exitosamente.";
        }

        public string ModificarProveedor(Proveedor proveedor)
        {
            var existente = ObtenerProveedorPorId(proveedor.Id);
            if (existente == null)
                return "Proveedor no encontrado.";

            existente.Nombre = proveedor.Nombre;
            existente.Cuit = proveedor.Cuit;
            existente.Rubro = proveedor.Rubro;
            existente.Telefono = proveedor.Telefono;
            existente.Email = proveedor.Email;

            _context.SaveChanges();
            return "OK";
        }

        public string EliminarProveedor(int id)
        {
            var proveedor = ObtenerProveedorPorId(id);
            if (proveedor == null)
                return "Proveedor no encontrado.";

            proveedor.Activo = false;
            _context.SaveChanges();
            return "OK";
        }

        public List<Proveedor> FiltrarProveedores(bool mostrarInactivos = false)
        {
            if (mostrarInactivos)
                return _context.Proveedores.ToList();
            else
                return _context.Proveedores.Where(p => p.Activo).ToList();
        }
    }
}
