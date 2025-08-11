using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Bestora.Data;

/* This is used if database provider does't define
 * IBestoraDbSchemaMigrator implementation.
 */
public class NullBestoraDbSchemaMigrator : IBestoraDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
