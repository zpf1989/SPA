using Abp.Application.Services;

namespace ABP.SPA
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class SPAAppServiceBase : ApplicationService
    {
        protected SPAAppServiceBase()
        {
            LocalizationSourceName = SPAConsts.LocalizationSourceName;
        }
    }
}