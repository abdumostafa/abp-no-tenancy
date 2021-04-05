using System;
using System.Collections.Generic;
using System.Text;
using Abdelmneim.NoTenancy.Localization;
using Volo.Abp.Application.Services;

namespace Abdelmneim.NoTenancy
{
    /* Inherit your application services from this class.
     */
    public abstract class NoTenancyAppService : ApplicationService
    {
        protected NoTenancyAppService()
        {
            LocalizationResource = typeof(NoTenancyResource);
        }
    }
}
