using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using OlaCollegeV1.Configuration;
using OlaCollegeV1.Web;

namespace OlaCollegeV1.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class OlaCollegeV1DbContextFactory : IDesignTimeDbContextFactory<OlaCollegeV1DbContext>
    {
        public OlaCollegeV1DbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<OlaCollegeV1DbContext>();
            
            /*
             You can provide an environmentName parameter to the AppConfigurations.Get method. 
             In this case, AppConfigurations will try to read appsettings.{environmentName}.json.
             Use Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") method or from string[] args to get environment if necessary.
             https://docs.microsoft.com/en-us/ef/core/cli/dbcontext-creation?tabs=dotnet-core-cli#args
             */
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            OlaCollegeV1DbContextConfigurer.Configure(builder, configuration.GetConnectionString(OlaCollegeV1Consts.ConnectionStringName));

            return new OlaCollegeV1DbContext(builder.Options);
        }
    }
}
