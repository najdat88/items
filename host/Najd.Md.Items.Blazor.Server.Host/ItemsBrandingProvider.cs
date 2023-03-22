using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Najd.Md.Items.Blazor.Server.Host;

[Dependency(ReplaceServices = true)]
public class ItemsBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Items";
}
