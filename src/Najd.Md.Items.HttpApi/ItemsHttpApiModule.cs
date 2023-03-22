using Localization.Resources.AbpUi;
using Najd.Md.Items.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace Najd.Md.Items;

[DependsOn(
    typeof(ItemsApplicationContractsModule),
    typeof(AbpAspNetCoreMvcModule))]
public class ItemsHttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(ItemsHttpApiModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<ItemsResource>()
                .AddBaseTypes(typeof(AbpUiResource));
        });
    }
}
