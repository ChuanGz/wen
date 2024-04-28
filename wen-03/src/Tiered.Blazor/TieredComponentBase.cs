using Tiered.Localization;
using Volo.Abp.AspNetCore.Components;

namespace Tiered.Blazor;

public abstract class TieredComponentBase : AbpComponentBase
{
    protected TieredComponentBase()
    {
        LocalizationResource = typeof(TieredResource);
    }
}
