using MicroservicesDemo.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace MicroservicesDemo
{
    public abstract class MicroservicesDemoController : AbpController
    {
        protected MicroservicesDemoController()
        {
            LocalizationResource = typeof(MicroservicesDemoResource);
        }
    }
}
