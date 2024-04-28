using Volo.Abp.Settings;

namespace Wen01.Settings;

public class Wen01SettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(Wen01Settings.MySetting1));
    }
}
