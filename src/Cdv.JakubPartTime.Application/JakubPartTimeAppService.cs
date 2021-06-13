using System;
using System.Collections.Generic;
using System.Text;
using Cdv.JakubPartTime.Localization;
using Volo.Abp.Application.Services;

namespace Cdv.JakubPartTime
{
    /* Inherit your application services from this class.
     */
    public abstract class JakubPartTimeAppService : ApplicationService
    {
        protected JakubPartTimeAppService()
        {
            LocalizationResource = typeof(JakubPartTimeResource);
        }
    }
}
