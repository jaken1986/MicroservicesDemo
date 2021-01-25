using MicroservicesDemo.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace MicroservicesDemo.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class MicroservicesDemoController : AbpController
    {
        protected MicroservicesDemoController()
        {
            LocalizationResource = typeof(MicroservicesDemoResource);
        }
    }
}