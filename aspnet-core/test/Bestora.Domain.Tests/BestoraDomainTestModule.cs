using Volo.Abp.Modularity;

namespace Bestora;

[DependsOn(
    typeof(BestoraDomainModule),
    typeof(BestoraTestBaseModule)
)]
public class BestoraDomainTestModule : AbpModule
{

}
