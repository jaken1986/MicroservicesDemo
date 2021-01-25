using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace MicroservicesDemo.EntityFrameworkCore
{
    public class MicroservicesDemoHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<MicroservicesDemoHttpApiHostMigrationsDbContext>
    {
        public MicroservicesDemoHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
        {
            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<MicroservicesDemoHttpApiHostMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("MicroservicesDemo"));

            return new MicroservicesDemoHttpApiHostMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
