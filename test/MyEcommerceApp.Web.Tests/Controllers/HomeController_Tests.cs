using System.Threading.Tasks;
using MyEcommerceApp.Models.TokenAuth;
using MyEcommerceApp.Web.Controllers;
using Shouldly;
using Xunit;

namespace MyEcommerceApp.Web.Tests.Controllers
{
    public class HomeController_Tests: MyEcommerceAppWebTestBase
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