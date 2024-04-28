using Wen01.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Wen01.Permissions;

public class Wen01PermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(Wen01Permissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(Wen01Permissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<Wen01Resource>(name);
    }
}
