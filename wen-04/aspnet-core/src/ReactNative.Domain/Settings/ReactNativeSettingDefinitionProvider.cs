using Volo.Abp.Settings;

namespace ReactNative.Settings;

public class ReactNativeSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(ReactNativeSettings.MySetting1));
    }
}
