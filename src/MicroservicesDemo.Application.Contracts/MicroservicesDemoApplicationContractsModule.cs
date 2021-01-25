using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace MicroservicesDemo
{
    [DependsOn(
        typeof(MicroservicesDemoDomainSharedModule),
        typeof(AbpDddApplicationContractsModule),
        typeof(AbpAuthorizationModule)
        )]
    public class MicroservicesDemoApplicationContractsModule : AbpModule
    {

    }
}
