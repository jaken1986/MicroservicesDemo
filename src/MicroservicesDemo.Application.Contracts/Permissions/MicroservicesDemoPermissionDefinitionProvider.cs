using MicroservicesDemo.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace MicroservicesDemo.Permissions
{
    public class MicroservicesDemoPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(MicroservicesDemoPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(MicroservicesDemoPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<MicroservicesDemoResource>(name);
        }
    }
}
