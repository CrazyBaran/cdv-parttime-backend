using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Cdv.JakubPartTime.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class JakubPartTimeMigrationsDbContextFactory : IDesignTimeDbContextFactory<JakubPartTimeMigrationsDbContext>
    {
        public JakubPartTimeMigrationsDbContext CreateDbContext(string[] args)
        {
            JakubPartTimeEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<JakubPartTimeMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new JakubPartTimeMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../Cdv.JakubPartTime.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
