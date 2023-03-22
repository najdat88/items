using Volo.Abp.Reflection;

namespace Najd.Md.Items.Permissions;

public class ItemsPermissions
{
    public const string GroupName = "Items";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(ItemsPermissions));
    }
}
