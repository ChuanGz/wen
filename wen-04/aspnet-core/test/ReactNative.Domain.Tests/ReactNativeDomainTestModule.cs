using Volo.Abp.Modularity;

namespace ReactNative;

[DependsOn(
    typeof(ReactNativeDomainModule),
    typeof(ReactNativeTestBaseModule)
)]
public class ReactNativeDomainTestModule : AbpModule
{

}
