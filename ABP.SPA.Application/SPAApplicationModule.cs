using System.Reflection;
using Abp.Modules;

namespace ABP.SPA
{
    [DependsOn(typeof(SPACoreModule))]
    public class SPAApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
