using FluentAssertions;
using PlaywrightDemo.Models;
using PlaywrightDemo.Pages;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace PlaywrightDemo.Tests.UI.Features
{
    [Binding]
    public class LoginSteps
    {
        private readonly LoginPage _loginPage;
        private readonly HomePage _homePage;
        public LoginSteps(LoginPage homepage, HomePage homePage)
        {
            _loginPage = homepage;
            _homePage = homePage;
        }

        [Given(@"I navigate to the website home page")]
        public async Task GivenINavigateToTheWebsiteHomePageAsync()
        {
            await _loginPage.GoTo(); 
        }

        [When(@"I login with a valid users credentials")]
        public async Task WhenILoginWithAValidUsersCredentialsAsync(Table table)
        {         
            var testData = table.CreateInstance<User>();
            await _loginPage.Login(testData.UserName, testData.Password);
        }

        [Then(@"the user should be logged in successfully")]
        public async Task ThenTheUserShouldBeLoggedInSuccessfully()
        {
            string expectedTitle = await _homePage.Title();
            expectedTitle.Should().Be("PRODUCTS");
        }
    }
}
