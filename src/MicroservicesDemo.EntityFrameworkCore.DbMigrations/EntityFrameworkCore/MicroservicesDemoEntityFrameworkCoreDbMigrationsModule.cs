using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace MicroservicesDemo.EntityFrameworkCore
{
    [DependsOn(
        typeof(MicroservicesDemoEntityFrameworkCoreModule)
        )]
    public class MicroservicesDemoEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<MicroservicesDemoMigrationsDbContext>();
        }
    }
}
