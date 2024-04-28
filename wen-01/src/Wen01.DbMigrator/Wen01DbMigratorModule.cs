using Wen01.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Wen01.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(Wen01EntityFrameworkCoreModule),
    typeof(Wen01ApplicationContractsModule)
    )]
public class Wen01DbMigratorModule : AbpModule
{
}
