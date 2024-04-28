using Wen01.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Wen01.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class Wen01Controller : AbpControllerBase
{
    protected Wen01Controller()
    {
        LocalizationResource = typeof(Wen01Resource);
    }
}
