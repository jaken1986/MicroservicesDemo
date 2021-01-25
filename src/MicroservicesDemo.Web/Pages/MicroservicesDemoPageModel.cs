using MicroservicesDemo.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace MicroservicesDemo.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class MicroservicesDemoPageModel : AbpPageModel
    {
        protected MicroservicesDemoPageModel()
        {
            LocalizationResourceType = typeof(MicroservicesDemoResource);
            ObjectMapperContext = typeof(MicroservicesDemoWebModule);
        }
    }
}