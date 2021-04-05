using Abdelmneim.NoTenancy.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Abdelmneim.NoTenancy
{
    [DependsOn(
        typeof(NoTenancyEntityFrameworkCoreTestModule)
        )]
    public class NoTenancyDomainTestModule : AbpModule
    {

    }
}