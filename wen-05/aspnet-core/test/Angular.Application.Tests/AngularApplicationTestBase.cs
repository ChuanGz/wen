using Volo.Abp.Modularity;

namespace Angular;

public abstract class AngularApplicationTestBase<TStartupModule> : AngularTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
