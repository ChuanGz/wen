﻿using Tiered.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Tiered.Permissions;

public class TieredPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(TieredPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(TieredPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<TieredResource>(name);
    }
}
