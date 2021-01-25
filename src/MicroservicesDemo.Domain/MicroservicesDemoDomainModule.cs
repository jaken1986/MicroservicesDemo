using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace MicroservicesDemo
{
    [DependsOn(
        typeof(AbpDddDomainModule),
        typeof(MicroservicesDemoDomainSharedModule)
    )]
    public class MicroservicesDemoDomainModule : AbpModule
    {

    }
}
