using Najd.Md.Items.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Najd.Md.Items;

public abstract class ItemsController : AbpControllerBase
{
    protected ItemsController()
    {
        LocalizationResource = typeof(ItemsResource);
    }
}
