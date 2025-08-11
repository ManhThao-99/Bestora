using System.Threading.Tasks;

namespace Bestora.Data;

public interface IBestoraDbSchemaMigrator
{
    Task MigrateAsync();
}
