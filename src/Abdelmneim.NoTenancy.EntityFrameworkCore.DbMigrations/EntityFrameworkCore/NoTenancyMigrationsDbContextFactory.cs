using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Abdelmneim.NoTenancy.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class NoTenancyMigrationsDbContextFactory : IDesignTimeDbContextFactory<NoTenancyMigrationsDbContext>
    {
        public NoTenancyMigrationsDbContext CreateDbContext(string[] args)
        {
            NoTenancyEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<NoTenancyMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new NoTenancyMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../Abdelmneim.NoTenancy.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
