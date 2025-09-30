using Serapis.Datos;
using Serapis.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serapis.Controladoras
{
    public class ClienteController
    {
        private readonly SerapisDbContext _context;

        public ClienteController(SerapisDbContext context)
        {
            _context = context;
        }

        public List<Cliente> ObtenerClientes(string filtro ="")
        {
            return _context.Clientes
                .Where(c => string.IsNullOrEmpty(filtro) ||
                            c.Nombre.Contains(filtro) ||
                            c.Apellido.Contains(filtro))
                .OrderBy(c => c.Nombre)
                .ToList();
        }

        public Cliente? ObtenerClientePorId(int id)
        {
            return _context.Clientes.Find(id);
        }

        public string AgregarCliente(Cliente cliente)
        {
            try
            {
                _context.Clientes.Add(cliente);
                _context.SaveChanges();
                return "OK";
            }
            catch (Exception ex)
            {
                return $"Error al agregar el cliente: {ex.Message}";
            }
        }

        public string ModificarCliente(Cliente cliente)
        {
            try
            {
                var existente = _context.Clientes.Find(cliente.Id);
                if (existente == null) return "Cliente no encontrado.";

                existente.Nombre = cliente.Nombre;
                existente.Apellido = cliente.Apellido;
                existente.DNI = cliente.DNI;
                existente.Telefono = cliente.Telefono;
                existente.Email = cliente.Email;
                existente.ObraSocial = cliente.ObraSocial;
                existente.Activo = cliente.Activo;

                _context.SaveChanges();
                return "OK";
            }
            catch (Exception ex)
            {
                return $"Error al modificar el cliente: {ex.Message}";
            }
        }

        public string BajaLogicaCliente(int clienteId)
        {
            try
            {
                var cliente = _context.Clientes.Find(clienteId);
                if (cliente == null) return "Cliente no encontrado.";

                cliente.Activo = false;
                _context.SaveChanges();
                return "OK";
            }
            catch (Exception ex)
            {
                return $"Error al desactivar el cliente: {ex.Message}";
            }
        }
    }
}
