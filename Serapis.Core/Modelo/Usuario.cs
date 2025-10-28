using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serapis.Modelo
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty; // Email único para el usuario
        public string ContraseñaHash { get; set; } = string.Empty; // Guardamos el hash
        public string Rol { get; set; } = "Empleado"; // "Admin" o "Empleado"
        public bool Activo { get; set; } = true; // Indica si el usuario está activo

        public bool EsAdmin => Rol.Equals("Admin", StringComparison.OrdinalIgnoreCase);
    }
}

