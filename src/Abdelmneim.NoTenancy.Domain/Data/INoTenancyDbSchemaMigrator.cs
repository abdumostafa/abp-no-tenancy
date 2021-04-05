using System.Threading.Tasks;

namespace Abdelmneim.NoTenancy.Data
{
    public interface INoTenancyDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
