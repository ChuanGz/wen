using System.Threading.Tasks;

namespace Tiered.Data;

public interface ITieredDbSchemaMigrator
{
    Task MigrateAsync();
}
