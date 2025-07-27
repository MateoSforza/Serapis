using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serapis.Modelo
{
    public class Venta
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Total { get; set; }

        public int? ClienteId { get; set; }
        public Cliente? Cliente { get; set; }

        // Relación con Receta
        public int? RecetaId { get; set; }
        public Receta? Receta { get; set; }

        public List<ItemVenta> ItemsVenta { get; set; } = new();
    }
}

