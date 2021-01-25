using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace MicroservicesDemo.EntityFrameworkCore
{
    [ConnectionStringName(MicroservicesDemoDbProperties.ConnectionStringName)]
    public class MicroservicesDemoDbContext : AbpDbContext<MicroservicesDemoDbContext>, IMicroservicesDemoDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * public DbSet<Question> Questions { get; set; }
         */

        public MicroservicesDemoDbContext(DbContextOptions<MicroservicesDemoDbContext> options) 
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ConfigureMicroservicesDemo();
        }
    }
}