using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Tiered;

[Dependency(ReplaceServices = true)]
public class TieredBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Tiered";
}
