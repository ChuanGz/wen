using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Angular;

[Dependency(ReplaceServices = true)]
public class AngularBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Angular";
}
