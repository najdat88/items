using Najd.Md.Items.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Najd.Md.Items.Permissions;

public class ItemsPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(ItemsPermissions.GroupName, L("Permission:Items"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<ItemsResource>(name);
    }
}
