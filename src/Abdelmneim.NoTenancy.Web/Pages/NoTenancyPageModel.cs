using Abdelmneim.NoTenancy.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Abdelmneim.NoTenancy.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class NoTenancyPageModel : AbpPageModel
    {
        protected NoTenancyPageModel()
        {
            LocalizationResourceType = typeof(NoTenancyResource);
        }
    }
}