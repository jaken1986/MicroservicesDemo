using JetBrains.Annotations;
using Volo.Abp.MongoDB;

namespace MicroservicesDemo.MongoDB
{
    public class MicroservicesDemoMongoModelBuilderConfigurationOptions : AbpMongoModelBuilderConfigurationOptions
    {
        public MicroservicesDemoMongoModelBuilderConfigurationOptions(
            [NotNull] string collectionPrefix = "")
            : base(collectionPrefix)
        {
        }
    }
}