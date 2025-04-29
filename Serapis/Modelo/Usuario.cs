using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serapis.Modelo
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Contraseña { get; set; } = string.Empty;
        public string Rol { get; set; } = "Empleado"; // Puede ser "Admin" o "Empleado"
    }
}
