using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace MicroservicesDemo.EntityFrameworkCore
{
    [ConnectionStringName(MicroservicesDemoDbProperties.ConnectionStringName)]
    public interface IMicroservicesDemoDbContext : IEfCoreDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * DbSet<Question> Questions { get; }
         */
    }
}