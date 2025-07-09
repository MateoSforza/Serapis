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
        public DateTime Fecha { get; set; } = DateTime.Now;
        public decimal Total { get; set; }
        public bool Anulada { get; set; } = false;

        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

        public int? ClienteId { get; set; } // Puede ser null
        public Cliente? Cliente { get; set; }
        public Receta? Receta { get; set; } // Opcional, para almacenar el ticket de venta

        public List<ItemVenta> ItemsVenta { get; set; } = new();
    }
}

