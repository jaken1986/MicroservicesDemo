using Volo.Abp.Reflection;

namespace MicroservicesDemo.Permissions
{
    public class MicroservicesDemoPermissions
    {
        public const string GroupName = "MicroservicesDemo";

        public static string[] GetAll()
        {
            return ReflectionHelper.GetPublicConstantsRecursively(typeof(MicroservicesDemoPermissions));
        }
    }
}