using System.Threading.Tasks;
using MicroservicesDemo.Localization;
using Volo.Abp.UI.Navigation;

namespace MicroservicesDemo.Blazor.Host
{
    public class MicroservicesDemoHostMenuContributor : IMenuContributor
    {
        public Task ConfigureMenuAsync(MenuConfigurationContext context)
        {
            if(context.Menu.DisplayName != StandardMenus.Main)
            {
                return Task.CompletedTask;
            }

            var l = context.GetLocalizer<MicroservicesDemoResource>();

            context.Menu.Items.Insert(
                0,
                new ApplicationMenuItem(
                    "MicroservicesDemo.Home",
                    l["Menu:Home"],
                    "/",
                    icon: "fas fa-home"
                )
            );

            return Task.CompletedTask;
        }
    }
}
