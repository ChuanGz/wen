using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Tiered.Data;

/* This is used if database provider does't define
 * ITieredDbSchemaMigrator implementation.
 */
public class NullTieredDbSchemaMigrator : ITieredDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
