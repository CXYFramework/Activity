using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using Activity.EntityFramework;

namespace Activity
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(ActivityCoreModule))]
    public class ActivityDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
