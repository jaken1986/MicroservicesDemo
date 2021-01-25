using MicroservicesDemo.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace MicroservicesDemo.Web.Pages
{
    public abstract class MicroservicesDemoPageModel : AbpPageModel
    {
        protected MicroservicesDemoPageModel()
        {
            LocalizationResourceType = typeof(MicroservicesDemoResource);
        }
    }
}