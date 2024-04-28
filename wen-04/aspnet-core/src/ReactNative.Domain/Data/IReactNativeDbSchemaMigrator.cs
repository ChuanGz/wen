using System.Threading.Tasks;

namespace ReactNative.Data;

public interface IReactNativeDbSchemaMigrator
{
    Task MigrateAsync();
}
