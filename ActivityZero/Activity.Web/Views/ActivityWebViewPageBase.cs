using Abp.Web.Mvc.Views;

namespace Activity.Web.Views
{
    public abstract class ActivityWebViewPageBase : ActivityWebViewPageBase<dynamic>
    {

    }

    public abstract class ActivityWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected ActivityWebViewPageBase()
        {
            LocalizationSourceName = ActivityConsts.LocalizationSourceName;
        }
    }
}