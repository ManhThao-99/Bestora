using Microsoft.Extensions.Localization;
using Bestora.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Bestora;

[Dependency(ReplaceServices = true)]
public class BestoraBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<BestoraResource> _localizer;

    public BestoraBrandingProvider(IStringLocalizer<BestoraResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
