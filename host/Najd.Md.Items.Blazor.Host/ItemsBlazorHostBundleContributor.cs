using Volo.Abp.Bundling;

namespace Najd.Md.Items.Blazor.Host;

public class ItemsBlazorHostBundleContributor : IBundleContributor
{
    public void AddScripts(BundleContext context)
    {

    }

    public void AddStyles(BundleContext context)
    {
        context.Add("main.css", true);
    }
}
