using ReactNative.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace ReactNative.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class ReactNativeController : AbpControllerBase
{
    protected ReactNativeController()
    {
        LocalizationResource = typeof(ReactNativeResource);
    }
}
