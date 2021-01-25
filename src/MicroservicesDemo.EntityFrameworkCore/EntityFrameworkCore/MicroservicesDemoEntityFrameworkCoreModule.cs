using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace MicroservicesDemo.EntityFrameworkCore
{
    [DependsOn(
        typeof(MicroservicesDemoDomainModule),
        typeof(AbpEntityFrameworkCoreModule)
    )]
    public class MicroservicesDemoEntityFrameworkCoreModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<MicroservicesDemoDbContext>(options =>
            {
                /* Add custom repositories here. Example:
                 * options.AddRepository<Question, EfCoreQuestionRepository>();
                 */
            });
        }
    }
}