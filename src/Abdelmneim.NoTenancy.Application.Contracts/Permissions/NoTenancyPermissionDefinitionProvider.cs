using Abdelmneim.NoTenancy.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Abdelmneim.NoTenancy.Permissions
{
    public class NoTenancyPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(NoTenancyPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(NoTenancyPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<NoTenancyResource>(name);
        }
    }
}
