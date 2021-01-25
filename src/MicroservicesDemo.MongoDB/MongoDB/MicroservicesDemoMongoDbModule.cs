using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;
using Volo.Abp.MongoDB;

namespace MicroservicesDemo.MongoDB
{
    [DependsOn(
        typeof(MicroservicesDemoDomainModule),
        typeof(AbpMongoDbModule)
        )]
    public class MicroservicesDemoMongoDbModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddMongoDbContext<MicroservicesDemoMongoDbContext>(options =>
            {
                /* Add custom repositories here. Example:
                 * options.AddRepository<Question, MongoQuestionRepository>();
                 */
            });
        }
    }
}
