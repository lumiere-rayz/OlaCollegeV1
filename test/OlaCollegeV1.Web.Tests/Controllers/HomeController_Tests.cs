using System.Threading.Tasks;
using OlaCollegeV1.Models.TokenAuth;
using OlaCollegeV1.Web.Controllers;
using Shouldly;
using Xunit;

namespace OlaCollegeV1.Web.Tests.Controllers
{
    public class HomeController_Tests: OlaCollegeV1WebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}