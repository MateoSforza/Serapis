using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serapis.Modelo
{
    public class Compra
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public int ProveedorId { get; set; }
        public Proveedor? Proveedor { get; set; } = null!;
        public List<ItemCompra> ItemsCompra { get; set; } = new();
    }
}
