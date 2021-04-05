using Volo.Abp.Settings;

namespace Abdelmneim.NoTenancy.Settings
{
    public class NoTenancySettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(NoTenancySettings.MySetting1));
        }
    }
}
