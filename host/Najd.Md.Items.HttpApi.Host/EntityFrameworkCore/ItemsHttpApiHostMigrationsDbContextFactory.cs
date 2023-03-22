using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Najd.Md.Items.EntityFrameworkCore;

public class ItemsHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<ItemsHttpApiHostMigrationsDbContext>
{
    public ItemsHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<ItemsHttpApiHostMigrationsDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Items"));

        return new ItemsHttpApiHostMigrationsDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
