using MicroservicesDemo.Localization;
using Volo.Abp.Application.Services;

namespace MicroservicesDemo
{
    public abstract class MicroservicesDemoAppService : ApplicationService
    {
        protected MicroservicesDemoAppService()
        {
            LocalizationResource = typeof(MicroservicesDemoResource);
            ObjectMapperContext = typeof(MicroservicesDemoApplicationModule);
        }
    }
}
