using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace MicroservicesDemo
{
    [DependsOn(
        typeof(MicroservicesDemoHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class MicroservicesDemoConsoleApiClientModule : AbpModule
    {
        
    }
}
