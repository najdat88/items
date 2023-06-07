using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Najd.Md.Items.EntityFrameworkCore;

[ConnectionStringName(ItemsDbProperties.ConnectionStringName)]
public interface IItemsDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */
    #region | Item |
    DbSet<Item> Items { get; }
    DbSet<ItemObject> ItemObjects { get; }
    DbSet<ItemType> ItemTypes { get; }
    DbSet<Attribute> Attributes { get; }
    DbSet<AttributeSet> AttributeSets { get; }
    DbSet<AttributeSetLineItem> AttributeSetLineItems { get; }
    DbSet<ItemFile> ItemFiles { get; }
    DbSet<ItemPrice> ItemPrices { get; }
    DbSet<ItemCategory> ItemCategories { get; }
    #endregion
}
