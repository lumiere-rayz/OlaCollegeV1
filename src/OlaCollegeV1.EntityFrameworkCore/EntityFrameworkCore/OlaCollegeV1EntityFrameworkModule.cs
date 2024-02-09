using Abp.EntityFrameworkCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Zero.EntityFrameworkCore;
using OlaCollegeV1.EntityFrameworkCore.Seed;

namespace OlaCollegeV1.EntityFrameworkCore
{
    [DependsOn(
        typeof(OlaCollegeV1CoreModule), 
        typeof(AbpZeroCoreEntityFrameworkCoreModule))]
    public class OlaCollegeV1EntityFrameworkModule : AbpModule
    {
        /* Used it tests to skip dbcontext registration, in order to use in-memory database of EF Core */
        public bool SkipDbContextRegistration { get; set; }

        public bool SkipDbSeed { get; set; }

        public override void PreInitialize()
        {
            if (!SkipDbContextRegistration)
            {
                Configuration.Modules.AbpEfCore().AddDbContext<OlaCollegeV1DbContext>(options =>
                {
                    if (options.ExistingConnection != null)
                    {
                        OlaCollegeV1DbContextConfigurer.Configure(options.DbContextOptions, options.ExistingConnection);
                    }
                    else
                    {
                        OlaCollegeV1DbContextConfigurer.Configure(options.DbContextOptions, options.ConnectionString);
                    }
                });
            }
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(OlaCollegeV1EntityFrameworkModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            if (!SkipDbSeed)
            {
                SeedHelper.SeedHostDb(IocManager);
            }
        }
    }
}
