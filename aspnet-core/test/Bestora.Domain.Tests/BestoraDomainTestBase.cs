using Volo.Abp.Modularity;

namespace Bestora;

/* Inherit from this class for your domain layer tests. */
public abstract class BestoraDomainTestBase<TStartupModule> : BestoraTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
