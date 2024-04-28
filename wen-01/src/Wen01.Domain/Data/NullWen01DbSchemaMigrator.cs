using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Wen01.Data;

/* This is used if database provider does't define
 * IWen01DbSchemaMigrator implementation.
 */
public class NullWen01DbSchemaMigrator : IWen01DbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
