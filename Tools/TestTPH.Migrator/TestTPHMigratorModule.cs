using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using TestTPH.EntityFramework;

namespace TestTPH.Migrator
{
    [DependsOn(typeof(TestTPHDataModule))]
    public class TestTPHMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<TestTPHDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}