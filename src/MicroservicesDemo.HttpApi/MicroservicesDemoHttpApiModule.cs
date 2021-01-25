﻿using Localization.Resources.AbpUi;
using MicroservicesDemo.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace MicroservicesDemo
{
    [DependsOn(
        typeof(MicroservicesDemoApplicationContractsModule),
        typeof(AbpAspNetCoreMvcModule))]
    public class MicroservicesDemoHttpApiModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            PreConfigure<IMvcBuilder>(mvcBuilder =>
            {
                mvcBuilder.AddApplicationPartIfNotExists(typeof(MicroservicesDemoHttpApiModule).Assembly);
            });
        }

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Get<MicroservicesDemoResource>()
                    .AddBaseTypes(typeof(AbpUiResource));
            });
        }
    }
}
