using Abp.Web.Mvc.Controllers;

namespace Activity.Web.Controllers
{
    /// <summary>
    /// Derive all Controllers from this class.
    /// </summary>
    public abstract class ActivityControllerBase : AbpController
    {
        protected ActivityControllerBase()
        {
            LocalizationSourceName = ActivityConsts.LocalizationSourceName;
        }
    }
}