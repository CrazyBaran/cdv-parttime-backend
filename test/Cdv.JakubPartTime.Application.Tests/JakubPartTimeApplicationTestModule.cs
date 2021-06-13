using Volo.Abp.Modularity;

namespace Cdv.JakubPartTime
{
    [DependsOn(
        typeof(JakubPartTimeApplicationModule),
        typeof(JakubPartTimeDomainTestModule)
        )]
    public class JakubPartTimeApplicationTestModule : AbpModule
    {

    }
}