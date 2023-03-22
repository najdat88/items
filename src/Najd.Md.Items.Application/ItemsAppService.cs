using Najd.Md.Items.Localization;
using Volo.Abp.Application.Services;

namespace Najd.Md.Items;

public abstract class ItemsAppService : ApplicationService
{
    protected ItemsAppService()
    {
        LocalizationResource = typeof(ItemsResource);
        ObjectMapperContext = typeof(ItemsApplicationModule);
    }
}
