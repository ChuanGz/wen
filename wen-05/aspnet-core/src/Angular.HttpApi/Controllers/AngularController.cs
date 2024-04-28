using Angular.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Angular.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class AngularController : AbpControllerBase
{
    protected AngularController()
    {
        LocalizationResource = typeof(AngularResource);
    }
}
