using System.Data.Entity;
using System.Reflection;
using Abp.EntityFramework;
using Abp.Modules;
using ABP.SPA.EntityFramework;

namespace ABP.SPA
{
    [DependsOn(typeof(AbpEntityFrameworkModule), typeof(SPACoreModule))]
    public class SPADataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            Database.SetInitializer<SPADbContext>(null);
        }
    }
}
