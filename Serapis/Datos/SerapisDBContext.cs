using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Serapis.Modelo;
using Serapis.Servicios;

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
