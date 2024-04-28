using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Wen01.Web;

[Dependency(ReplaceServices = true)]
public class Wen01BrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Wen01";
}
