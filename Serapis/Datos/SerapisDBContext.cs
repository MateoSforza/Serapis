using Microsoft.EntityFrameworkCore;
using Serapis.Modelo;
using Serapis.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Serapis.Datos
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

        // 👇 Este es el método clave que soluciona tu error
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configura la relación uno a uno entre Venta y Receta
            modelBuilder.Entity<Venta>()
                .HasOne(v => v.Receta)
                .WithOne(r => r.Venta)
                .HasForeignKey<Venta>(v => v.RecetaId)
                .OnDelete(DeleteBehavior.SetNull); // Opcional: evita error al borrar receta
        }
    }

    public static class DbInitializer
    {
        public static void Inicializar(SerapisDbContext context)
        {
            // Asegura que la base esté creada
            context.Database.EnsureCreated();

            // Si ya existe un admin, no hace nada
            if (context.Usuarios.Any(u => u.Nombre == "admin@admin.com"))
                return;

            var admin = new Usuario
            {
                Nombre = "admin@admin.com",
                Contraseña = HashHelper.CalcularHash("admin"),
                Rol = "Admin"
            };

            context.Usuarios.Add(admin);
            context.SaveChanges();
        }
    }
}
