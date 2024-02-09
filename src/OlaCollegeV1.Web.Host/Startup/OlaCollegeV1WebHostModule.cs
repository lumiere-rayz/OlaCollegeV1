using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using OlaCollegeV1.Configuration;

namespace OlaCollegeV1.Web.Host.Startup
{
    [DependsOn(
       typeof(OlaCollegeV1WebCoreModule))]
    public class OlaCollegeV1WebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public OlaCollegeV1WebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(OlaCollegeV1WebHostModule).GetAssembly());
        }
    }
}
