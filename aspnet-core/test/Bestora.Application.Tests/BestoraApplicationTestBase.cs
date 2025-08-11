using Volo.Abp.Modularity;

namespace Bestora;

public abstract class BestoraApplicationTestBase<TStartupModule> : BestoraTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
