using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using OlaCollegeV1.Configuration;
using OlaCollegeV1.EntityFrameworkCore;
using OlaCollegeV1.Migrator.DependencyInjection;

namespace OlaCollegeV1.Migrator
{
    [DependsOn(typeof(OlaCollegeV1EntityFrameworkModule))]
    public class OlaCollegeV1MigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public OlaCollegeV1MigratorModule(OlaCollegeV1EntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(OlaCollegeV1MigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                OlaCollegeV1Consts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(OlaCollegeV1MigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
