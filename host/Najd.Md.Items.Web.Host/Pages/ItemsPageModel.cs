using Najd.Md.Items.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Najd.Md.Items.Pages;

public abstract class ItemsPageModel : AbpPageModel
{
    protected ItemsPageModel()
    {
        LocalizationResourceType = typeof(ItemsResource);
    }
}
