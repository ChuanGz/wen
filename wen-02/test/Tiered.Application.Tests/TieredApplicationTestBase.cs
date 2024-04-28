using Volo.Abp.Modularity;

namespace Tiered;

public abstract class TieredApplicationTestBase<TStartupModule> : TieredTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
