﻿using System.Reflection;
using Abp.Modules;

namespace ABP.SPA
{
    public class SPACoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
