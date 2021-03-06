﻿using System.Reflection;
using Abp.Application.Services;
using Abp.Modules;
using Abp.WebApi;
using Abp.WebApi.Controllers.Dynamic.Builders;

namespace Activity
{
    [DependsOn(typeof(AbpWebApiModule), typeof(ActivityApplicationModule))]
    public class ActivityWebApiModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            DynamicApiControllerBuilder
                .ForAll<IApplicationService>(typeof(ActivityApplicationModule).Assembly, "app")
                .Build();
        }
    }
}
