using Volo.Abp.Modularity;

namespace ReactNative;

[DependsOn(
    typeof(ReactNativeApplicationModule),
    typeof(ReactNativeDomainTestModule)
)]
public class ReactNativeApplicationTestModule : AbpModule
{

}
