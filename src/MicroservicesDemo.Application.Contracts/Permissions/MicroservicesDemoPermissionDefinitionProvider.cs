using MicroservicesDemo.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace MicroservicesDemo.Permissions
{
    public class MicroservicesDemoPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(MicroservicesDemoPermissions.GroupName, L("Permission:MicroservicesDemo"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<MicroservicesDemoResource>(name);
        }
    }
}