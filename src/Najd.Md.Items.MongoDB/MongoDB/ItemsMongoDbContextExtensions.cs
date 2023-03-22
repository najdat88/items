using Volo.Abp;
using Volo.Abp.MongoDB;

namespace Najd.Md.Items.MongoDB;

public static class ItemsMongoDbContextExtensions
{
    public static void ConfigureItems(
        this IMongoModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));
    }
}
