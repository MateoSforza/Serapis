using System;
using System.Text;
using System.Threading.Tasks;
using Serapis.Modelo;
using Serapis.Servicios;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Linq;
using Serapis.Data;

namespace Serapis.Controladores
{
    public class UsuarioController
    {
        private readonly SerapisDbContext _context;

        public UsuarioController(SerapisDbContext context)
        {
            _context = context;
        }

        // Registrar un usuario nuevo
        public void RegistrarUsuario(string nombre, string email, string contraseña, string rol = "Empleado")
        {
            if (_context.Usuarios.Any(u => u.Nombre == nombre))
                throw new InvalidOperationException("El nombre de usuario ya existe.");

            var usuario = new Usuario
            {
                Nombre = nombre,
                Email = email,
                ContraseñaHash = HashHelper.CalcularHash(contraseña),
                Rol = rol
            };

            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
        }

        // Obtener todos los usuarios
        public List<Usuario> ObtenerUsuarios()
        {
            return _context.Usuarios.Where(u => u.Activo).ToList();
        }

        // Obtener usuario por Id
        public Usuario? ObtenerUsuarioPorId(int id)
        {
            return _context.Usuarios.FirstOrDefault(u => u.Id == id);
        }

        // Eliminar usuario (baja lógica)
        public void EliminarUsuario(int id)
        {
            var usuario = _context.Usuarios.FirstOrDefault(u => u.Id == id);
            if (usuario != null)
            {
                usuario.Activo = false; // baja lógica
                _context.SaveChanges();
            }
        }

        // Actualizar contraseña de un usuario
        public void CambiarContraseña(int id, string nuevaContraseña)
        {
            var usuario = ObtenerUsuarioPorId(id);
            if (usuario != null)
            {
                usuario.ContraseñaHash = HashHelper.CalcularHash(nuevaContraseña);
                _context.SaveChanges();
            }
        }

        // Login
        public Usuario? Login(string nombre, string contraseña)
        {
            var usuario = _context.Usuarios.FirstOrDefault(u => u.Nombre == nombre);
            if (usuario != null && HashHelper.VerificarHash(contraseña, usuario.ContraseñaHash))
            {
                return usuario;
            }
            return null;
        }
    }
}

