using JetBrains.Annotations;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace MicroservicesDemo.EntityFrameworkCore
{
    public class MicroservicesDemoModelBuilderConfigurationOptions : AbpModelBuilderConfigurationOptions
    {
        public MicroservicesDemoModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = "",
            [CanBeNull] string schema = null)
            : base(
                tablePrefix,
                schema)
        {

        }
    }
}