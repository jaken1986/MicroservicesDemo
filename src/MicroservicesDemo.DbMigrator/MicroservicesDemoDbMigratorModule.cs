using MicroservicesDemo.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace MicroservicesDemo.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(MicroservicesDemoEntityFrameworkCoreDbMigrationsModule),
        typeof(MicroservicesDemoApplicationContractsModule)
        )]
    public class MicroservicesDemoDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
