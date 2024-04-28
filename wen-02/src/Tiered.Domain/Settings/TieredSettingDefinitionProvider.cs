using Volo.Abp.Settings;

namespace Tiered.Settings;

public class TieredSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(TieredSettings.MySetting1));
    }
}
