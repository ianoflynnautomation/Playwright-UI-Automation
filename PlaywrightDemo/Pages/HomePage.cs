using Microsoft.Playwright;
using System.Threading.Tasks;

namespace PlaywrightDemo.Pages
{
    public class HomePage
    {
        private readonly IPage _page;

        public HomePage(IPage page)
        {
            _page = page;
        }

        public async Task<string> Title() => await _page.InnerTextAsync("text=Products");
    }
}
