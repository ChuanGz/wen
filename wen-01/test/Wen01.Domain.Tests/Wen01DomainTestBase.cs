using Volo.Abp.Modularity;

namespace Wen01;

/* Inherit from this class for your domain layer tests. */
public abstract class Wen01DomainTestBase<TStartupModule> : Wen01TestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
