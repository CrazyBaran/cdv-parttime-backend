using Cdv.JakubPartTime.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Cdv.JakubPartTime.Permissions
{
    public class JakubPartTimePermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(JakubPartTimePermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(JakubPartTimePermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<JakubPartTimeResource>(name);
        }
    }
}
