using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;
using Microsoft.Identity.Client;

namespace Serapis.Datos
{
    public class SerapisDbContextFactory : IDesignTimeDbContextFactory<SerapisDbContext>
    {
        public SerapisDbContext CreateDbContext(string[] args)
        {
            var bulider = new DbContextOptionsBuilder<SerapisDbContext>();

            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = config.GetConnectionString("DefaultConnection");

            bulider.UseSqlServer(connectionString);

            return new SerapisDbContext(bulider.Options);
        }
    }
}
