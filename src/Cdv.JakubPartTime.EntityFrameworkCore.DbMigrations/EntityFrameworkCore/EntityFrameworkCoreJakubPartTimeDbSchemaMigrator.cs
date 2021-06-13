using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Cdv.JakubPartTime.Data;
using Volo.Abp.DependencyInjection;

namespace Cdv.JakubPartTime.EntityFrameworkCore
{
    public class EntityFrameworkCoreJakubPartTimeDbSchemaMigrator
        : IJakubPartTimeDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreJakubPartTimeDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the JakubPartTimeMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<JakubPartTimeMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}