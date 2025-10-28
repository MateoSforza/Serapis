using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Serapis.Data
{
    public class SerapisDbContextFactory : IDesignTimeDbContextFactory<SerapisDbContext>
    {
        public SerapisDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<SerapisDbContext>();

            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true)
                .Build();

            var connectionString = config.GetConnectionString("DefaultConnection")
                                   ?? "Server=(localdb)\\MSSQLLocalDB;Database=SerapisDb;Trusted_Connection=True;MultipleActiveResultSets=true";

            builder.UseSqlServer(connectionString);

            return new SerapisDbContext(builder.Options);
        }
    }
}
