using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serapis.Data;
using Serapis.Modelo;
using Serapis.Servicios;

namespace Serapis.Controladoras
{
    public class ConfiguracionController
    {
        private readonly SerapisDbContext _context;

        public ConfiguracionController(SerapisDbContext context)
        {
            _context = context;
        }

        // Cambiar la contraseña de un usuario
        public void CambiarContraseña(int usuarioId, string nuevaContraseña)
        {
            var usuario = _context.Usuarios.FirstOrDefault(u => u.Id == usuarioId);
            if (usuario == null)
                throw new Exception("Usuario no encontrado");

            usuario.ContraseñaHash = HashHelper.CalcularHash(nuevaContraseña);
            _context.SaveChanges();
        }

        // Obtener datos del usuario logueado (puede usarse para mostrar en panel)
        public Usuario ObtenerUsuario(int usuarioId)
        {
            return _context.Usuarios.FirstOrDefault(u => u.Id == usuarioId)
                   ?? throw new Exception("Usuario no encontrado");
        }
    }
}
