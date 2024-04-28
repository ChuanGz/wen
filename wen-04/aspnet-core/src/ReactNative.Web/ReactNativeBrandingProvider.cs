using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace ReactNative.Web;

[Dependency(ReplaceServices = true)]
public class ReactNativeBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "ReactNative";
}
