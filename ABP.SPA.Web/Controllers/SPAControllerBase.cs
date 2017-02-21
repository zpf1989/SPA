using Abp.Web.Mvc.Controllers;

namespace ABP.SPA.Web.Controllers
{
    /// <summary>
    /// Derive all Controllers from this class.
    /// </summary>
    public abstract class SPAControllerBase : AbpController
    {
        protected SPAControllerBase()
        {
            LocalizationSourceName = SPAConsts.LocalizationSourceName;
        }
    }
}