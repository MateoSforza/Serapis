using Microsoft.EntityFrameworkCore;
using Serapis.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using Serapis.Servicios;

namespace Serapis.Data
{
    public class SerapisDbContext : DbContext
    {
        public SerapisDbContext(DbContextOptions<SerapisDbContext> options)
            : base(options)
        {
        }

        public DbSet<Producto> Productos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<Compra> Compras { get; set; }
        public DbSet<ItemCompra> ItemsCompra { get; set; }
        public DbSet<Venta> Ventas { get; set; }
        public DbSet<ItemVenta> ItemsVenta { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Receta> Recetas { get; set; }
        public DbSet<Factura> Facturas { get; set; }
        public DbSet<PagoFactura> PagosFactura { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Relación uno a uno: FK en Receta (Receta.VentaId)
            modelBuilder.Entity<Venta>()
                .HasOne(v => v.Receta)
                .WithOne(r => r.Venta)
                .HasForeignKey<Receta>(r => r.VentaId)
                .OnDelete(DeleteBehavior.SetNull);

            // Factura 1:1 Venta (sin navegación en Venta)
            modelBuilder.Entity<Factura>()
                .HasOne(f => f.Venta)
                .WithOne()
                .HasForeignKey<Factura>(f => f.VentaId)
                .OnDelete(DeleteBehavior.Cascade);

            // Factura 1:N Pagos
            modelBuilder.Entity<PagoFactura>()
                .HasOne(p => p.Factura)
                .WithMany(f => f.Pagos)
                .HasForeignKey(p => p.FacturaId)
                .OnDelete(DeleteBehavior.Cascade);

            // Nota de crédito referencia
            modelBuilder.Entity<Factura>()
                .HasOne(f => f.FacturaOrigen)
                .WithMany()
                .HasForeignKey(f => f.FacturaOrigenId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }

    public static class DbInitializer
    {
        public static void Inicializar(SerapisDbContext context)
        {
            // Aplicar migraciones automáticamente al inicio
            context.Database.Migrate();

            if (context.Usuarios.Any(u => u.Email == "admin@admin.com"))
                return;

            var admin = new Usuario
            {
                Nombre = "admin",
                Email = "admin@admin.com",
                ContraseñaHash = HashHelper.CalcularHash("admin"),
                Rol = "Admin",
                Activo = true
            };

            context.Usuarios.Add(admin);
            context.SaveChanges();
        }
    }
}
