using Volo.Abp.Modularity;

namespace Angular;

[DependsOn(
    typeof(AngularApplicationModule),
    typeof(AngularDomainTestModule)
)]
public class AngularApplicationTestModule : AbpModule
{

}
