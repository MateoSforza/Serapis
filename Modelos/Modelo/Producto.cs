using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serapis.Modelo
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Codigo { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public string Laboratorio { get; set; }

        public bool Activo { get; set; } = true;
        public bool RequiereReceta { get; set; } = false;


    }
}
