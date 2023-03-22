using Volo.Abp.Modularity;

namespace Najd.Md.Items;

[DependsOn(
    typeof(ItemsApplicationModule),
    typeof(ItemsDomainTestModule)
    )]
public class ItemsApplicationTestModule : AbpModule
{

}
