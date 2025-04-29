using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Serapis.Datos;
using Serapis.Vista;

namespace Serapis
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            var builder = Host.CreateApplicationBuilder();

            builder.Configuration.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            // DbContext
            builder.Services.AddDbContext<SerapisDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            // Formularios registrados
            builder.Services.AddTransient<FormLogin>();
            builder.Services.AddTransient<FormAdmin>();
            builder.Services.AddTransient<FormEmpleado>();
            builder.Services.AddTransient<FormProductos>();

            var app = builder.Build();

            using (var scope = app.Services.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<SerapisDbContext>();
                DbInitializer.Inicializar(context);
            }

            ApplicationConfiguration.Initialize();
            var loginForm = app.Services.GetRequiredService<FormLogin>();
            Application.Run(loginForm);
        }
    }
}
