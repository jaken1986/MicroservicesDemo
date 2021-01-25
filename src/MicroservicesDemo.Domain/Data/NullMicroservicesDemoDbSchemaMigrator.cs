using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace MicroservicesDemo.Data
{
    /* This is used if database provider does't define
     * IMicroservicesDemoDbSchemaMigrator implementation.
     */
    public class NullMicroservicesDemoDbSchemaMigrator : IMicroservicesDemoDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}