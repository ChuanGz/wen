using Volo.Abp.Modularity;

namespace Wen01;

[DependsOn(
    typeof(Wen01DomainModule),
    typeof(Wen01TestBaseModule)
)]
public class Wen01DomainTestModule : AbpModule
{

}
