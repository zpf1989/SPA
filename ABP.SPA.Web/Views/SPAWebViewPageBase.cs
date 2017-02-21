using Abp.Web.Mvc.Views;

namespace ABP.SPA.Web.Views
{
    public abstract class SPAWebViewPageBase : SPAWebViewPageBase<dynamic>
    {

    }

    public abstract class SPAWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected SPAWebViewPageBase()
        {
            LocalizationSourceName = SPAConsts.LocalizationSourceName;
        }
    }
}