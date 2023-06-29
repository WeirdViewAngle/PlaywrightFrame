using Microsoft.Playwright;

namespace PlaywriteFramework.Elements.Pages
{
    public class GogolPage : BasePage
    {
        private readonly string searchLocator = "input[name=q]";
        private readonly string luckButtonLocator = "";

        public GogolPage(IPage page) : base(page, "locator")
        {
        }

        public async Task TypeTextToSearchField(string text)
        {
            await page.TypeAsync(searchLocator, text);
        }

        public async Task PressLuckButton()
        {
            await page.ClickAsync(luckButtonLocator);
        }
    }
}
