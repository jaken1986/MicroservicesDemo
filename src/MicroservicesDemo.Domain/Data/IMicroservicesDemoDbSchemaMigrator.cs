using System.Threading.Tasks;

namespace MicroservicesDemo.Data
{
    public interface IMicroservicesDemoDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
