using Najd.Md.Items;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Najd.Md.Items.EntityFrameworkCore;

public static class ItemsDbContextModelCreatingExtensions
{
    public static void ConfigureItems(
        this ModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));

        /* Configure all entities here. Example:

        builder.Entity<Question>(b =>
        {
            //Configure table & schema name
            b.ToTable(ItemsDbProperties.DbTablePrefix + "Questions", ItemsDbProperties.DbSchema);

            b.ConfigureByConvention();

            //Properties
            b.Property(q => q.Title).IsRequired().HasMaxLength(QuestionConsts.MaxTitleLength);

            //Relations
            b.HasMany(question => question.Tags).WithOne().HasForeignKey(qt => qt.QuestionId);

            //Indexes
            b.HasIndex(q => q.CreationTime);
        });
        */
        #region | Item |
        builder.Entity<Item>(b =>
        {
            b.ToTable(ItemsDbProperties.DbTablePrefix + "item", ItemsDbProperties.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props
            b.Property(p => p.Id).HasColumnName("id");
            //b.Property(p => p.ExtraProperties).HasColumnName("extra_properties");
            b.Property(p => p.IsDeleted).HasColumnName("is_deleted");
            b.Property(p => p.CreationTime).HasColumnName("creation_time");
            b.Property(p => p.CreatorId).HasColumnName("creator_id");


            //Relations
            //b.HasMany(question => question.ItemCategories).WithOne().HasForeignKey(qt => qt.Item_Id);
            //b.HasMany(question => question.ItemPrices).WithOne().HasForeignKey(qt => qt.Item_Id);
            //b.HasMany(question => question.ItemFiles).WithOne().HasForeignKey(qt => qt.Item_Id);

        });
        builder.Entity<ItemObject>(b =>
        {
            b.ToTable(ItemsDbProperties.DbTablePrefix + "item_object", ItemsDbProperties.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props
            b.Property(p => p.Id).HasColumnName("id");
            //b.Property(p => p.ExtraProperties).HasColumnName("extra_properties");
            b.Property(p => p.IsDeleted).HasColumnName("is_deleted");
            b.Property(p => p.CreationTime).HasColumnName("creation_time");
            b.Property(p => p.CreatorId).HasColumnName("creator_id");
        });
        builder.Entity<ItemType>(b =>
        {
            b.ToTable(ItemsDbProperties.DbTablePrefix + "item_type", ItemsDbProperties.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props
            b.Property(p => p.Id).HasColumnName("id");
            //b.Property(p => p.ExtraProperties).HasColumnName("extra_properties");
            b.Property(p => p.IsDeleted).HasColumnName("is_deleted");
            b.Property(p => p.CreationTime).HasColumnName("creation_time");
            b.Property(p => p.CreatorId).HasColumnName("creator_id");
        });
        builder.Entity<Items.Attribute>(b =>
        {
            b.ToTable(ItemsDbProperties.DbTablePrefix + "attribute", ItemsDbProperties.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props
            b.Property(p => p.Id).HasColumnName("id");
            //b.Property(p => p.ExtraProperties).HasColumnName("extra_properties");
            b.Property(p => p.IsDeleted).HasColumnName("is_deleted");
            b.Property(p => p.CreationTime).HasColumnName("creation_time");
            b.Property(p => p.CreatorId).HasColumnName("creator_id");
        });
        builder.Entity<AttributeSet>(b =>
        {
            b.ToTable(ItemsDbProperties.DbTablePrefix + "attribute_set", ItemsDbProperties.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props
            b.Property(p => p.Id).HasColumnName("id");
            //b.Property(p => p.ExtraProperties).HasColumnName("extra_properties");
            b.Property(p => p.IsDeleted).HasColumnName("is_deleted");
            b.Property(p => p.CreationTime).HasColumnName("creation_time");
            b.Property(p => p.CreatorId).HasColumnName("creator_id");
        });
        builder.Entity<AttributeSetLineItem>(b =>
        {
            b.ToTable(ItemsDbProperties.DbTablePrefix + "attribute_set_line_item", ItemsDbProperties.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props
            b.Property(p => p.Id).HasColumnName("id");
            //b.Property(p => p.ExtraProperties).HasColumnName("extra_properties");
            b.Property(p => p.IsDeleted).HasColumnName("is_deleted");
            b.Property(p => p.CreationTime).HasColumnName("creation_time");
            b.Property(p => p.CreatorId).HasColumnName("creator_id");
        });
        builder.Entity<ItemFile>(b =>
        {
            b.ToTable(ItemsDbProperties.DbTablePrefix + "item_file", ItemsDbProperties.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props
            b.Property(p => p.Id).HasColumnName("id");
            //b.Property(p => p.ExtraProperties).HasColumnName("extra_properties");
            b.Property(p => p.IsDeleted).HasColumnName("is_deleted");
            b.Property(p => p.CreationTime).HasColumnName("creation_time");
            b.Property(p => p.CreatorId).HasColumnName("creator_id");

            // Parent Child Rrelation one-to-many
            b.HasOne<Item>(s => s.Item)
            .WithMany(g => g.ItemFiles)
            .HasForeignKey(s => s.Item_Id);

        });
        builder.Entity<ItemPrice>(b =>
        {
            b.ToTable(ItemsDbProperties.DbTablePrefix + "item_price", ItemsDbProperties.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props
            b.Property(p => p.Id).HasColumnName("id");
            //b.Property(p => p.ExtraProperties).HasColumnName("extra_properties");
            b.Property(p => p.IsDeleted).HasColumnName("is_deleted");
            b.Property(p => p.CreationTime).HasColumnName("creation_time");
            b.Property(p => p.CreatorId).HasColumnName("creator_id");


            // Parent Child Rrelation one-to-many
            b.HasOne<Item>(s => s.Item)
            .WithMany(g => g.ItemPrices)
            .HasForeignKey(s => s.Item_Id);

        });
        builder.Entity<ItemCategory>(b =>
        {
            b.ToTable(ItemsDbProperties.DbTablePrefix + "item_category", ItemsDbProperties.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props
            b.Property(p => p.Id).HasColumnName("id");
            //b.Property(p => p.ExtraProperties).HasColumnName("extra_properties");
            b.Property(p => p.IsDeleted).HasColumnName("is_deleted");
            b.Property(p => p.CreationTime).HasColumnName("creation_time");
            b.Property(p => p.CreatorId).HasColumnName("creator_id");


            // Parent Child Rrelation one-to-many
            b.HasOne<Item>(s => s.Item)
            .WithMany(g => g.ItemCategories)
            .HasForeignKey(s => s.Item_Id);

        });
        #endregion
    }
}
