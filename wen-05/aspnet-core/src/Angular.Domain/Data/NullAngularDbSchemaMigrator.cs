using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Angular.Data;

/* This is used if database provider does't define
 * IAngularDbSchemaMigrator implementation.
 */
public class NullAngularDbSchemaMigrator : IAngularDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
