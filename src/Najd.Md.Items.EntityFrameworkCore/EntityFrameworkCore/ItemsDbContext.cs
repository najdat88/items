using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Najd.Md.Items.EntityFrameworkCore;

[ConnectionStringName(ItemsDbProperties.ConnectionStringName)]
public class ItemsDbContext : AbpDbContext<ItemsDbContext>, IItemsDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */

    public ItemsDbContext(DbContextOptions<ItemsDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureItems();
    }
}
