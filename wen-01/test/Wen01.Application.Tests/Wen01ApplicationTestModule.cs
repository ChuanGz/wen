using Volo.Abp.Modularity;

namespace Wen01;

[DependsOn(
    typeof(Wen01ApplicationModule),
    typeof(Wen01DomainTestModule)
)]
public class Wen01ApplicationTestModule : AbpModule
{

}
