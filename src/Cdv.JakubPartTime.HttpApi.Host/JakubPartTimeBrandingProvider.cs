using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Cdv.JakubPartTime
{
    [Dependency(ReplaceServices = true)]
    public class JakubPartTimeBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "JakubPartTime";
    }
}
