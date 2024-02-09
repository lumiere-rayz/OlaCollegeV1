using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using OlaCollegeV1.Authorization;

namespace OlaCollegeV1
{
    [DependsOn(
        typeof(OlaCollegeV1CoreModule), 
        typeof(AbpAutoMapperModule))]
    public class OlaCollegeV1ApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<OlaCollegeV1AuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(OlaCollegeV1ApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
