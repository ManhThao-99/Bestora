using System;
using System.Collections.Generic;
using System.Text;
using Bestora.Localization;
using Volo.Abp.Application.Services;

namespace Bestora;

/* Inherit your application services from this class.
 */
public abstract class BestoraAppService : ApplicationService
{
    protected BestoraAppService()
    {
        LocalizationResource = typeof(BestoraResource);
    }
}
