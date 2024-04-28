using System.Threading.Tasks;

namespace Angular.Data;

public interface IAngularDbSchemaMigrator
{
    Task MigrateAsync();
}
