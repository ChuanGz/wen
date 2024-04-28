using Volo.Abp.Modularity;

namespace ReactNative;

/* Inherit from this class for your domain layer tests. */
public abstract class ReactNativeDomainTestBase<TStartupModule> : ReactNativeTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
