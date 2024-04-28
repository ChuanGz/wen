using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace ReactNative.Data;

/* This is used if database provider does't define
 * IReactNativeDbSchemaMigrator implementation.
 */
public class NullReactNativeDbSchemaMigrator : IReactNativeDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
