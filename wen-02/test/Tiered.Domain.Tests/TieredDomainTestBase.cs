using Volo.Abp.Modularity;

namespace Tiered;

/* Inherit from this class for your domain layer tests. */
public abstract class TieredDomainTestBase<TStartupModule> : TieredTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
