using Cdv.JakubPartTime.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Cdv.JakubPartTime.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class JakubPartTimeController : AbpController
    {
        protected JakubPartTimeController()
        {
            LocalizationResource = typeof(JakubPartTimeResource);
        }
    }
}