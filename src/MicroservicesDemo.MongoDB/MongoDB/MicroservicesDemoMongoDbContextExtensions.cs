using System;
using Volo.Abp;
using Volo.Abp.MongoDB;

namespace MicroservicesDemo.MongoDB
{
    public static class MicroservicesDemoMongoDbContextExtensions
    {
        public static void ConfigureMicroservicesDemo(
            this IMongoModelBuilder builder,
            Action<AbpMongoModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new MicroservicesDemoMongoModelBuilderConfigurationOptions(
                MicroservicesDemoDbProperties.DbTablePrefix
            );

            optionsAction?.Invoke(options);
        }
    }
}