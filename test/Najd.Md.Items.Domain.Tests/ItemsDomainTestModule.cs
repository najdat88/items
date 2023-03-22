using Najd.Md.Items.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Najd.Md.Items;

/* Domain tests are configured to use the EF Core provider.
 * You can switch to MongoDB, however your domain tests should be
 * database independent anyway.
 */
[DependsOn(
    typeof(ItemsEntityFrameworkCoreTestModule)
    )]
public class ItemsDomainTestModule : AbpModule
{

}
