using Volo.Abp.Modularity;

namespace Tiered;

[DependsOn(
    typeof(TieredDomainModule),
    typeof(TieredTestBaseModule)
)]
public class TieredDomainTestModule : AbpModule
{

}
