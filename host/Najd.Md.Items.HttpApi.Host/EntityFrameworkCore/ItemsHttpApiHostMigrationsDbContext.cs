using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Najd.Md.Items.EntityFrameworkCore;

public class ItemsHttpApiHostMigrationsDbContext : AbpDbContext<ItemsHttpApiHostMigrationsDbContext>
{
    public ItemsHttpApiHostMigrationsDbContext(DbContextOptions<ItemsHttpApiHostMigrationsDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ConfigureItems();
    }
}
