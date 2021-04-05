using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Localization;
using Abdelmneim.NoTenancy.Localization;
using Volo.Abp.UI.Navigation;

namespace Abdelmneim.NoTenancy.Web.Menus
{
    public class NoTenancyMenuContributor : IMenuContributor
    {
        public async Task ConfigureMenuAsync(MenuConfigurationContext context)
        {
            if (context.Menu.Name == StandardMenus.Main)
            {
                await ConfigureMainMenuAsync(context);
            }
        }

        private async Task ConfigureMainMenuAsync(MenuConfigurationContext context)
        {
            var l = context.GetLocalizer<NoTenancyResource>();

            context.Menu.Items.Insert(0, new ApplicationMenuItem(NoTenancyMenus.Home, l["Menu:Home"], "~/"));
        }
    }
}
