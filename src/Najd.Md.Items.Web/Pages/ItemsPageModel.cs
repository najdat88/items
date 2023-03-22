using Najd.Md.Items.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Najd.Md.Items.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class ItemsPageModel : AbpPageModel
{
    protected ItemsPageModel()
    {
        LocalizationResourceType = typeof(ItemsResource);
        ObjectMapperContext = typeof(ItemsWebModule);
    }
}
