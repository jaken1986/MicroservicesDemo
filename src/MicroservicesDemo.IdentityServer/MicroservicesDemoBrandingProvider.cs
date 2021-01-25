﻿using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace MicroservicesDemo
{
    [Dependency(ReplaceServices = true)]
    public class MicroservicesDemoBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "MicroservicesDemo";
    }
}
