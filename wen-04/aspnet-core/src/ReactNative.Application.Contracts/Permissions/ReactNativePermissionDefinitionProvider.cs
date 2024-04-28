using ReactNative.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace ReactNative.Permissions;

public class ReactNativePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(ReactNativePermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(ReactNativePermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<ReactNativeResource>(name);
    }
}
