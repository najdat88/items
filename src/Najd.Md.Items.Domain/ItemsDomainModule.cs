using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace Najd.Md.Items;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(ItemsDomainSharedModule)
)]
public class ItemsDomainModule : AbpModule
{

}
