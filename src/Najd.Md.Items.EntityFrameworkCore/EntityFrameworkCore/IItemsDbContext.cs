using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Najd.Md.Items.EntityFrameworkCore;

[ConnectionStringName(ItemsDbProperties.ConnectionStringName)]
public interface IItemsDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */
}
