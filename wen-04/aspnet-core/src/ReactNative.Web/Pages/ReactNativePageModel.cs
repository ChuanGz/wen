using ReactNative.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace ReactNative.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class ReactNativePageModel : AbpPageModel
{
    protected ReactNativePageModel()
    {
        LocalizationResourceType = typeof(ReactNativeResource);
    }
}
