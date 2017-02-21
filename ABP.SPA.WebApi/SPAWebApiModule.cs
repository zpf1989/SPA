using System.Reflection;
using Abp.Application.Services;
using Abp.Configuration.Startup;
using Abp.Modules;
using Abp.WebApi;

namespace ABP.SPA
{
    [DependsOn(typeof(AbpWebApiModule), typeof(SPAApplicationModule))]
    public class SPAWebApiModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            Configuration.Modules.AbpWebApi().DynamicApiControllerBuilder
                .ForAll<IApplicationService>(typeof(SPAApplicationModule).Assembly, "app")
                .Build();
        }
    }
}
