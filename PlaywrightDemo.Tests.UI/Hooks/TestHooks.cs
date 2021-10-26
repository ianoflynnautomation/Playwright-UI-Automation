using BoDi;
using Microsoft.Playwright;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace PlaywrightDemo.Tests.UI.Hooks
{
    [Binding]
    public class TestHooks
    {
        private readonly IObjectContainer _objectContainer;

        public TestHooks(IObjectContainer objectContainer)
        {
            _objectContainer = objectContainer;
        }

        [BeforeScenario]
        public async Task BeforeScenarioAsync()
        {
            var playwright = await Playwright.CreateAsync();
            var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = false,
                SlowMo = 50,
            });
            var page = await browser.NewPageAsync();
            //await page.GotoAsync("https://www.saucedemo.com/");
            _objectContainer.RegisterInstanceAs(browser);
            _objectContainer.RegisterInstanceAs(page);
        }


        [AfterScenario]
        public async Task AfterScenario()
        {
            var browser = _objectContainer.Resolve<IBrowser>();
            await browser.CloseAsync();

        }
    }
}
