using System.Threading.Tasks;

namespace Wen01.Data;

public interface IWen01DbSchemaMigrator
{
    Task MigrateAsync();
}
