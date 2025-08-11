using Bestora.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Bestora.Permissions;

public class BestoraPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(BestoraPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(BestoraPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<BestoraResource>(name);
    }
}
