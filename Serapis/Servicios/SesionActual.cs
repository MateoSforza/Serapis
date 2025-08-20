using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serapis.Datos;
using Serapis.Vista;
using Serapis.Modelo;

namespace Serapis.Servicios
{
    public static class SesionActual
    {
        public static int UsuarioId { get; set; }
        public static string NombreUsuario { get; set; }
        public static string Rol { get; set; }

        public static Usuario? UsuarioLogueado { get; set; }
    }
}
