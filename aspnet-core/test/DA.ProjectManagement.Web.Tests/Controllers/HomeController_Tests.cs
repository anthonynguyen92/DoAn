using System.Threading.Tasks;
using DA.ProjectManagement.Models.TokenAuth;
using DA.ProjectManagement.Web.Controllers;
using Shouldly;
using Xunit;

namespace DA.ProjectManagement.Web.Tests.Controllers
{
    public class HomeController_Tests: ProjectManagementWebTestBase
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