using ReactNative.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace ReactNative.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(ReactNativeEntityFrameworkCoreModule),
    typeof(ReactNativeApplicationContractsModule)
    )]
public class ReactNativeDbMigratorModule : AbpModule
{
}
