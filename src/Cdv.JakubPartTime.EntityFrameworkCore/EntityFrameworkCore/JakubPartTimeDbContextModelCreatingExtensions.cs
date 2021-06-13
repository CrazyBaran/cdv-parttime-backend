using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace Cdv.JakubPartTime.EntityFrameworkCore
{
    public static class JakubPartTimeDbContextModelCreatingExtensions
    {
        public static void ConfigureJakubPartTime(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(JakubPartTimeConsts.DbTablePrefix + "YourEntities", JakubPartTimeConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}