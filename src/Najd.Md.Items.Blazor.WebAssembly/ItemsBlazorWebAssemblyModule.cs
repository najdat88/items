using Volo.Abp.AspNetCore.Components.WebAssembly.Theming;
using Volo.Abp.Modularity;

namespace Najd.Md.Items.Blazor.WebAssembly;

[DependsOn(
    typeof(ItemsBlazorModule),
    typeof(ItemsHttpApiClientModule),
    typeof(AbpAspNetCoreComponentsWebAssemblyThemingModule)
    )]
public class ItemsBlazorWebAssemblyModule : AbpModule
{

}
