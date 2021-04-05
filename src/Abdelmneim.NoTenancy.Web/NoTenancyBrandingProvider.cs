using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Abdelmneim.NoTenancy.Web
{
    [Dependency(ReplaceServices = true)]
    public class NoTenancyBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "NoTenancy";
    }
}
