using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace Najd.Md.Items.Pages;

public class IndexModel : ItemsPageModel
{
    public void OnGet()
    {

    }

    public async Task OnPostLoginAsync()
    {
        await HttpContext.ChallengeAsync("oidc");
    }
}
