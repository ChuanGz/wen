using Angular.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Angular.Permissions;

public class AngularPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(AngularPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(AngularPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<AngularResource>(name);
    }
}
