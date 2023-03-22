using System.Threading.Tasks;
using Volo.Abp.UI.Navigation;

namespace Najd.Md.Items.Web.Menus;

public class ItemsMenuContributor : IMenuContributor
{
    public async Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
        if (context.Menu.Name == StandardMenus.Main)
        {
            await ConfigureMainMenuAsync(context);
        }
    }

    private Task ConfigureMainMenuAsync(MenuConfigurationContext context)
    {
        //Add main menu items.
        context.Menu.AddItem(new ApplicationMenuItem(ItemsMenus.Prefix, displayName: "Items", "~/Items", icon: "fa fa-globe"));

        return Task.CompletedTask;
    }
}
