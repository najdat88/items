using Najd.Md.Items;
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

    #region | Item |
    public DbSet<Item> Items { get; set; }
    public DbSet<ItemObject> ItemObjects { get; set; }
    public DbSet<ItemType> ItemTypes { get; set; }
    public DbSet<Attribute> Attributes { get; set; }
    public DbSet<AttributeSet> AttributeSets { get; set; }
    public DbSet<AttributeSetLineItem> AttributeSetLineItems { get; set; }
    public DbSet<ItemFile> ItemFiles { get; set; }
    public DbSet<ItemPrice> ItemPrices { get; set; }
    public DbSet<ItemCategory> ItemCategories { get; set; }

    #endregion

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
