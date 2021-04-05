using Abdelmneim.NoTenancy.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Abdelmneim.NoTenancy.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(NoTenancyEntityFrameworkCoreDbMigrationsModule),
        typeof(NoTenancyApplicationContractsModule)
        )]
    public class NoTenancyDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
