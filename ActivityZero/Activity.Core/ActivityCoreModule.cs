using System.Reflection;
using Abp.Modules;
using Abp.Zero;

namespace Activity
{
    [DependsOn(typeof(AbpZeroCoreModule))]
    public class ActivityCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            //Remove the following line to disable multi-tenancy.
            Configuration.MultiTenancy.IsEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
