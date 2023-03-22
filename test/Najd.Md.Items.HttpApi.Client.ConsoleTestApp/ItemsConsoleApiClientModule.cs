using Volo.Abp.Autofac;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Najd.Md.Items;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(ItemsHttpApiClientModule),
    typeof(AbpHttpClientIdentityModelModule)
    )]
public class ItemsConsoleApiClientModule : AbpModule
{

}
