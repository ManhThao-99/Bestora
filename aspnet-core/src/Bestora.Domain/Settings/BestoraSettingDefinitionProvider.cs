using Volo.Abp.Settings;

namespace Bestora.Settings;

public class BestoraSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(BestoraSettings.MySetting1));
    }
}
