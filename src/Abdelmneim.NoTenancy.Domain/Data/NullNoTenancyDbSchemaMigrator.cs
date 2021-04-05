using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Abdelmneim.NoTenancy.Data
{
    /* This is used if database provider does't define
     * INoTenancyDbSchemaMigrator implementation.
     */
    public class NullNoTenancyDbSchemaMigrator : INoTenancyDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}