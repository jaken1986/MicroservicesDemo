using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace MicroservicesDemo.EntityFrameworkCore
{
    public class MicroservicesDemoHttpApiHostMigrationsDbContext : AbpDbContext<MicroservicesDemoHttpApiHostMigrationsDbContext>
    {
        public MicroservicesDemoHttpApiHostMigrationsDbContext(DbContextOptions<MicroservicesDemoHttpApiHostMigrationsDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ConfigureMicroservicesDemo();
        }
    }
}
