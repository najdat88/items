using Volo.Abp.AspNetCore.Components.Server.Theming;
using Volo.Abp.Modularity;

namespace Najd.Md.Items.Blazor.Server;

[DependsOn(
    typeof(AbpAspNetCoreComponentsServerThemingModule),
    typeof(ItemsBlazorModule)
    )]
public class ItemsBlazorServerModule : AbpModule
{

}
