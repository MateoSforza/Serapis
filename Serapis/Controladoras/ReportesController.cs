using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serapis.Datos;

namespace Serapis.Controladoras
{
    public class ReportesController
    {
        private readonly SerapisDbContext _context;

        public ReportesController(SerapisDbContext context)
        {
            _context = context;
        }

        // Total de ventas en un período
        public decimal ObtenerTotalVentas(DateTime desde, DateTime hasta)
        {
            return _context.Ventas
                .Where(v => v.Fecha >= desde && v.Fecha <= hasta)
                .Sum(v => (decimal?)v.Total) ?? 0;
        }

        // Total de compras en un período
        public decimal ObtenerTotalCompras(DateTime desde, DateTime hasta)
        {
            return _context.Compras
                .Where(c => c.Fecha >= desde && c.Fecha <= hasta)
                .Sum(c => (decimal?)c.Total) ?? 0;
        }

        // Productos con stock crítico (ejemplo: menos de 10 unidades)
        public object ObtenerProductosCriticos(int limite = 10)
        {
            return _context.Productos
                .Where(p => p.Stock <= limite && p.Activo)
                .Select(p => new
                {
                    p.Id,
                    p.Nombre,
                    p.Codigo,
                    p.Stock
                })
                .ToList();
        }

        // Ventas agrupadas por cliente
        public object ObtenerVentasPorCliente(DateTime desde, DateTime hasta)
        {
            return _context.Ventas
                .Where(v => v.Fecha >= desde && v.Fecha <= hasta)
                .GroupBy(v => v.Cliente.Nombre)
                .Select(g => new
                {
                    Cliente = g.Key,
                    Total = g.Sum(v => v.Total)
                })
                .ToList();
        }
    }
}
