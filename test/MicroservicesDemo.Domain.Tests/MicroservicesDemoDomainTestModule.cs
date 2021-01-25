using MicroservicesDemo.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace MicroservicesDemo
{
    [DependsOn(
        typeof(MicroservicesDemoEntityFrameworkCoreTestModule)
        )]
    public class MicroservicesDemoDomainTestModule : AbpModule
    {

    }
}