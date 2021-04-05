using Volo.Abp.Modularity;

namespace Abdelmneim.NoTenancy
{
    [DependsOn(
        typeof(NoTenancyApplicationModule),
        typeof(NoTenancyDomainTestModule)
        )]
    public class NoTenancyApplicationTestModule : AbpModule
    {

    }
}