using Bestora.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Bestora.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class BestoraController : AbpControllerBase
{
    protected BestoraController()
    {
        LocalizationResource = typeof(BestoraResource);
    }
}
