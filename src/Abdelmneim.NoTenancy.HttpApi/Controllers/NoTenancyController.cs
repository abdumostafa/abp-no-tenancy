using Abdelmneim.NoTenancy.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Abdelmneim.NoTenancy.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class NoTenancyController : AbpController
    {
        protected NoTenancyController()
        {
            LocalizationResource = typeof(NoTenancyResource);
        }
    }
}