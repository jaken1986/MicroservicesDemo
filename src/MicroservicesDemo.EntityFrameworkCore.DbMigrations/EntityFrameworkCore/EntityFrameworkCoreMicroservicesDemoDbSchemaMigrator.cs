using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MicroservicesDemo.Data;
using Volo.Abp.DependencyInjection;

namespace MicroservicesDemo.EntityFrameworkCore
{
    public class EntityFrameworkCoreMicroservicesDemoDbSchemaMigrator
        : IMicroservicesDemoDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreMicroservicesDemoDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the MicroservicesDemoMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<MicroservicesDemoMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}