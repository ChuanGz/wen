using Wen01.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Wen01.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class Wen01PageModel : AbpPageModel
{
    protected Wen01PageModel()
    {
        LocalizationResourceType = typeof(Wen01Resource);
    }
}
