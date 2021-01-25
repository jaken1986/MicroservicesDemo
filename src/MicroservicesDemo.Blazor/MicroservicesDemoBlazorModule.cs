using Microsoft.Extensions.DependencyInjection;
using MicroservicesDemo.Blazor.Menus;
using Volo.Abp.AspNetCore.Components.WebAssembly.Theming.Routing;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.UI.Navigation;

namespace MicroservicesDemo.Blazor
{
    [DependsOn(
        typeof(MicroservicesDemoHttpApiClientModule),
        typeof(AbpAutoMapperModule)
        )]
    public class MicroservicesDemoBlazorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAutoMapperObjectMapper<MicroservicesDemoBlazorModule>();

            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddProfile<MicroservicesDemoBlazorAutoMapperProfile>(validate: true);
            });

            Configure<AbpNavigationOptions>(options =>
            {
                options.MenuContributors.Add(new MicroservicesDemoMenuContributor());
            });

            Configure<AbpRouterOptions>(options =>
            {
                options.AdditionalAssemblies.Add(typeof(MicroservicesDemoBlazorModule).Assembly);
            });
        }
    }
}