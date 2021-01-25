using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace MicroservicesDemo.MongoDB
{
    [ConnectionStringName(MicroservicesDemoDbProperties.ConnectionStringName)]
    public interface IMicroservicesDemoMongoDbContext : IAbpMongoDbContext
    {
        /* Define mongo collections here. Example:
         * IMongoCollection<Question> Questions { get; }
         */
    }
}
