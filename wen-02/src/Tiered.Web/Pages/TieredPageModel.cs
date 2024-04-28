using Tiered.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Tiered.Web.Pages;

public abstract class TieredPageModel : AbpPageModel
{
    protected TieredPageModel()
    {
        LocalizationResourceType = typeof(TieredResource);
    }
}
