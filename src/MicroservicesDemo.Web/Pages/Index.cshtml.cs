using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace MicroservicesDemo.Web.Pages
{
    public class IndexModel : MicroservicesDemoPageModel
    {
        public void OnGet()
        {
            
        }

        public async Task OnPostLoginAsync()
        {
            await HttpContext.ChallengeAsync("oidc");
        }
    }
}