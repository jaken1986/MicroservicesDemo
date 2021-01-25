using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;

namespace MicroservicesDemo
{
    [DependsOn(
        typeof(MicroservicesDemoApplicationContractsModule),
        typeof(AbpHttpClientModule))]
    public class MicroservicesDemoHttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = "MicroservicesDemo";

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(MicroservicesDemoApplicationContractsModule).Assembly,
                RemoteServiceName
            );
        }
    }
}
