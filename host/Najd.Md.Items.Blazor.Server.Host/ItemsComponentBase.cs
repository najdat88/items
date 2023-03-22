using Najd.Md.Items.Localization;
using Volo.Abp.AspNetCore.Components;

namespace Najd.Md.Items.Blazor.Server.Host;

public abstract class ItemsComponentBase : AbpComponentBase
{
    protected ItemsComponentBase()
    {
        LocalizationResource = typeof(ItemsResource);
    }
}
