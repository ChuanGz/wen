using System;
using System.Collections.Generic;
using System.Text;
using Tiered.Localization;
using Volo.Abp.Application.Services;

namespace Tiered;

/* Inherit your application services from this class.
 */
public abstract class TieredAppService : ApplicationService
{
    protected TieredAppService()
    {
        LocalizationResource = typeof(TieredResource);
    }
}
