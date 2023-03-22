using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace Najd.Md.Items;

[DependsOn(
    typeof(ItemsApplicationContractsModule),
    typeof(AbpHttpClientModule))]
public class ItemsHttpApiClientModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(ItemsApplicationContractsModule).Assembly,
            ItemsRemoteServiceConsts.RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<ItemsHttpApiClientModule>();
        });

    }
}
