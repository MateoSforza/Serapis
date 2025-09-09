using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serapis.Modelo
{
    public class Receta
    {
        public int Id { get; set; }
        public string Detalle { get; set; } = string.Empty;
        public DateTime Fecha { get; set; } = DateTime.Now;
        public string? Medico { get; set; }

        public int VentaId { get; set; }
        public Venta Venta { get; set; }
    }

}