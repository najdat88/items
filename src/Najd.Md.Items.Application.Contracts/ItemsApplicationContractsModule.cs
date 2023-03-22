using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace Najd.Md.Items;

[DependsOn(
    typeof(ItemsDomainSharedModule),
    typeof(AbpDddApplicationContractsModule),
    typeof(AbpAuthorizationModule)
    )]
public class ItemsApplicationContractsModule : AbpModule
{

}
