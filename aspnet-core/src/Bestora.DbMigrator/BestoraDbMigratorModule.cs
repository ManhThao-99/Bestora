using Bestora.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Bestora.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(BestoraEntityFrameworkCoreModule),
    typeof(BestoraApplicationContractsModule)
    )]
public class BestoraDbMigratorModule : AbpModule
{
}
