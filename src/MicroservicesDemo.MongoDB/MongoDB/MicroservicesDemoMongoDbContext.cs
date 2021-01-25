using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace MicroservicesDemo.MongoDB
{
    [ConnectionStringName(MicroservicesDemoDbProperties.ConnectionStringName)]
    public class MicroservicesDemoMongoDbContext : AbpMongoDbContext, IMicroservicesDemoMongoDbContext
    {
        /* Add mongo collections here. Example:
         * public IMongoCollection<Question> Questions => Collection<Question>();
         */

        protected override void CreateModel(IMongoModelBuilder modelBuilder)
        {
            base.CreateModel(modelBuilder);

            modelBuilder.ConfigureMicroservicesDemo();
        }
    }
}