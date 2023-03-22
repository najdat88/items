using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace Najd.Md.Items;

[DependsOn(
    typeof(AbpVirtualFileSystemModule)
    )]
public class ItemsInstallerModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<ItemsInstallerModule>();
        });
    }
}
