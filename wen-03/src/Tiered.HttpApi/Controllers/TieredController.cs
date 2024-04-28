using Tiered.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Tiered.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class TieredController : AbpControllerBase
{
    protected TieredController()
    {
        LocalizationResource = typeof(TieredResource);
    }
}
