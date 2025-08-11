using Volo.Abp.Modularity;

namespace Bestora;

[DependsOn(
    typeof(BestoraApplicationModule),
    typeof(BestoraDomainTestModule)
)]
public class BestoraApplicationTestModule : AbpModule
{

}
