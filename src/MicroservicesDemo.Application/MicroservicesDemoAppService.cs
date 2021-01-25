using System;
using System.Collections.Generic;
using System.Text;
using MicroservicesDemo.Localization;
using Volo.Abp.Application.Services;

namespace MicroservicesDemo
{
    /* Inherit your application services from this class.
     */
    public abstract class MicroservicesDemoAppService : ApplicationService
    {
        protected MicroservicesDemoAppService()
        {
            LocalizationResource = typeof(MicroservicesDemoResource);
        }
    }
}
