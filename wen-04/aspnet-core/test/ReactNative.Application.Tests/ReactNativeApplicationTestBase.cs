using Volo.Abp.Modularity;

namespace ReactNative;

public abstract class ReactNativeApplicationTestBase<TStartupModule> : ReactNativeTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
