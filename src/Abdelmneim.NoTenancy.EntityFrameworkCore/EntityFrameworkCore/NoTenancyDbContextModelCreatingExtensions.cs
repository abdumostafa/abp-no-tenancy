using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace Abdelmneim.NoTenancy.EntityFrameworkCore
{
    public static class NoTenancyDbContextModelCreatingExtensions
    {
        public static void ConfigureNoTenancy(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(NoTenancyConsts.DbTablePrefix + "YourEntities", NoTenancyConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}