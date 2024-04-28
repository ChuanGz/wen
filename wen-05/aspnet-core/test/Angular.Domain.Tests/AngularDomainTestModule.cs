using Volo.Abp.Modularity;

namespace Angular;

[DependsOn(
    typeof(AngularDomainModule),
    typeof(AngularTestBaseModule)
)]
public class AngularDomainTestModule : AbpModule
{

}
