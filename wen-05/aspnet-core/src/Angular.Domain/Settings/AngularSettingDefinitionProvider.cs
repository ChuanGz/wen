using Volo.Abp.Settings;

namespace Angular.Settings;

public class AngularSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(AngularSettings.MySetting1));
    }
}
