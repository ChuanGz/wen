using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Tiered;

[Dependency(ReplaceServices = true)]
public class TieredBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Tiered";
}
