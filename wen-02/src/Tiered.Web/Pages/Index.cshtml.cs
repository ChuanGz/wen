using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace Tiered.Web.Pages;

public class IndexModel : TieredPageModel
{
    public void OnGet()
    {

    }

    public async Task OnPostLoginAsync()
    {
        await HttpContext.ChallengeAsync("oidc");
    }
}
