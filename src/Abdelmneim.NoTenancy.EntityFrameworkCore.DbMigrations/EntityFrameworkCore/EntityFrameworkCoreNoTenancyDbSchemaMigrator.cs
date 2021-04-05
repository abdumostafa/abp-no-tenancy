using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Abdelmneim.NoTenancy.Data;
using Volo.Abp.DependencyInjection;

namespace Abdelmneim.NoTenancy.EntityFrameworkCore
{
    public class EntityFrameworkCoreNoTenancyDbSchemaMigrator
        : INoTenancyDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreNoTenancyDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the NoTenancyMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<NoTenancyMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}