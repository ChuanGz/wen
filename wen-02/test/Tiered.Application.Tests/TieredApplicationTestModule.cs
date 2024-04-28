using Volo.Abp.Modularity;

namespace Tiered;

[DependsOn(
    typeof(TieredApplicationModule),
    typeof(TieredDomainTestModule)
)]
public class TieredApplicationTestModule : AbpModule
{

}
