using Angular.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Angular.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(AngularEntityFrameworkCoreModule),
    typeof(AngularApplicationContractsModule)
    )]
public class AngularDbMigratorModule : AbpModule
{
}
