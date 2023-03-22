using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Najd.Md.Items;

[Dependency(ReplaceServices = true)]
public class ItemsBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Items";
}
