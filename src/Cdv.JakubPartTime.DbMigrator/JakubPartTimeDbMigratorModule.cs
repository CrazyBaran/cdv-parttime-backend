using Cdv.JakubPartTime.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Cdv.JakubPartTime.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(JakubPartTimeEntityFrameworkCoreDbMigrationsModule),
        typeof(JakubPartTimeApplicationContractsModule)
        )]
    public class JakubPartTimeDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
