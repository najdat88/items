using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Najd.Md.Items.MongoDB;

[ConnectionStringName(ItemsDbProperties.ConnectionStringName)]
public interface IItemsMongoDbContext : IAbpMongoDbContext
{
    /* Define mongo collections here. Example:
     * IMongoCollection<Question> Questions { get; }
     */
}
