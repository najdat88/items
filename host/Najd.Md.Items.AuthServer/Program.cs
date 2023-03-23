using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;
using Serilog.Events;

namespace Najd.Md.Items;

public class Program
{
    public async static Task<int> Main(string[] args)
    {
        // https://github.com/abpframework/abp/issues/11437
        AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        // https://github.com/abpframework/abp/issues/1387#issuecomment-506645119
        Volo.Abp.FeatureManagement.AbpFeatureManagementDbProperties.DbTablePrefix = "auth";
        Volo.Abp.Identity.AbpIdentityDbProperties.DbTablePrefix = "auth";
        Volo.Abp.TenantManagement.AbpTenantManagementDbProperties.DbTablePrefix = "auth";
        Volo.Abp.PermissionManagement.AbpPermissionManagementDbProperties.DbTablePrefix = "auth";
        Volo.Abp.AuditLogging.AbpAuditLoggingDbProperties.DbTablePrefix = "core";
        Volo.Abp.SettingManagement.AbpSettingManagementDbProperties.DbTablePrefix = "core";

        Log.Logger = new LoggerConfiguration()
#if DEBUG
            .MinimumLevel.Debug()
#else
            .MinimumLevel.Information()
#endif
            .MinimumLevel.Override("Microsoft", LogEventLevel.Information)
            .MinimumLevel.Override("Microsoft.EntityFrameworkCore", LogEventLevel.Warning)
            .Enrich.FromLogContext()
            .WriteTo.Async(c => c.File("Logs/logs.txt"))
            .WriteTo.Async(c => c.Console())
            .CreateLogger();

        try
        {
            Log.Information("Starting web host.");
            var builder = WebApplication.CreateBuilder(args);
            builder.Host.AddAppSettingsSecretsJson()
                .UseAutofac()
                .UseSerilog();
            await builder.AddApplicationAsync<ItemsAuthServerModule>();
            var app = builder.Build();
            await app.InitializeApplicationAsync();
            await app.RunAsync();
            return 0;
        }
        catch (Exception ex)
        {
            if (ex is HostAbortedException)
            {
                throw;
            }

            Log.Fatal(ex, "Host terminated unexpectedly!");
            return 1;
        }
        finally
        {
            Log.CloseAndFlush();
        }
    }
}
