using Volo.Abp.Modularity;

namespace MicroservicesDemo
{
    [DependsOn(
        typeof(MicroservicesDemoApplicationModule),
        typeof(MicroservicesDemoDomainTestModule)
        )]
    public class MicroservicesDemoApplicationTestModule : AbpModule
    {

    }
}