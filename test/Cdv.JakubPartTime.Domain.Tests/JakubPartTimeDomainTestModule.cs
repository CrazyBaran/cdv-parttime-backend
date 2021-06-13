using Cdv.JakubPartTime.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Cdv.JakubPartTime
{
    [DependsOn(
        typeof(JakubPartTimeEntityFrameworkCoreTestModule)
        )]
    public class JakubPartTimeDomainTestModule : AbpModule
    {

    }
}