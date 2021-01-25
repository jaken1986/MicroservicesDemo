using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace MicroservicesDemo.EntityFrameworkCore
{
    public static class MicroservicesDemoDbContextModelCreatingExtensions
    {
        public static void ConfigureMicroservicesDemo(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(MicroservicesDemoConsts.DbTablePrefix + "YourEntities", MicroservicesDemoConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}