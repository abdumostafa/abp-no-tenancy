using Volo.Abp.Account;
using Volo.Abp.AutoMapper;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement;
namespace Abdelmneim.NoTenancy
{
    [DependsOn(
        typeof(NoTenancyDomainModule),
        typeof(AbpAccountApplicationModule),
        typeof(NoTenancyApplicationContractsModule),
        typeof(AbpIdentityApplicationModule),
        typeof(AbpPermissionManagementApplicationModule),
        typeof(AbpFeatureManagementApplicationModule)
        )]
    public class NoTenancyApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddMaps<NoTenancyApplicationModule>();
            });
        }
    }
}
