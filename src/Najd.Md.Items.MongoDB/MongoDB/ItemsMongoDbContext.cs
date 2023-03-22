using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Najd.Md.Items.MongoDB;

[ConnectionStringName(ItemsDbProperties.ConnectionStringName)]
public class ItemsMongoDbContext : AbpMongoDbContext, IItemsMongoDbContext
{
    /* Add mongo collections here. Example:
     * public IMongoCollection<Question> Questions => Collection<Question>();
     */

    protected override void CreateModel(IMongoModelBuilder modelBuilder)
    {
        base.CreateModel(modelBuilder);

        modelBuilder.ConfigureItems();
    }
}
