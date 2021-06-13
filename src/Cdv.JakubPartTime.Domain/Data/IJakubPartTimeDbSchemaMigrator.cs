using System.Threading.Tasks;

namespace Cdv.JakubPartTime.Data
{
    public interface IJakubPartTimeDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
