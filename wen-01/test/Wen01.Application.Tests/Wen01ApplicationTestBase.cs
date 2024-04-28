using Volo.Abp.Modularity;

namespace Wen01;

public abstract class Wen01ApplicationTestBase<TStartupModule> : Wen01TestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
