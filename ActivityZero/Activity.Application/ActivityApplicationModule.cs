using System.Reflection;
using Abp.AutoMapper;
using Abp.Modules;

namespace Activity
{
    [DependsOn(typeof(ActivityCoreModule), typeof(AbpAutoMapperModule))]
    public class ActivityApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
