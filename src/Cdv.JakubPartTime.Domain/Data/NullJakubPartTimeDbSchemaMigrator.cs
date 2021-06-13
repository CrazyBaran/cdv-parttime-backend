using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Cdv.JakubPartTime.Data
{
    /* This is used if database provider does't define
     * IJakubPartTimeDbSchemaMigrator implementation.
     */
    public class NullJakubPartTimeDbSchemaMigrator : IJakubPartTimeDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}