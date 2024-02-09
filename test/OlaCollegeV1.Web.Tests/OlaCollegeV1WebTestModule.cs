using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using OlaCollegeV1.EntityFrameworkCore;
using OlaCollegeV1.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace OlaCollegeV1.Web.Tests
{
    [DependsOn(
        typeof(OlaCollegeV1WebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class OlaCollegeV1WebTestModule : AbpModule
    {
        public OlaCollegeV1WebTestModule(OlaCollegeV1EntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(OlaCollegeV1WebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(OlaCollegeV1WebMvcModule).Assembly);
        }
    }
}