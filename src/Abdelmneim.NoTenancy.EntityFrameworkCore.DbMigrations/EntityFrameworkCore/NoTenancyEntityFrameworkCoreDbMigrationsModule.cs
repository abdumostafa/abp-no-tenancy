using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace Abdelmneim.NoTenancy.EntityFrameworkCore
{
    [DependsOn(
        typeof(NoTenancyEntityFrameworkCoreModule)
        )]
    public class NoTenancyEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<NoTenancyMigrationsDbContext>();
        }
    }
}
