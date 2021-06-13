using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace Cdv.JakubPartTime.EntityFrameworkCore
{
    [DependsOn(
        typeof(JakubPartTimeEntityFrameworkCoreModule)
        )]
    public class JakubPartTimeEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<JakubPartTimeMigrationsDbContext>();
        }
    }
}
