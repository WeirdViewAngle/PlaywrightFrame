using Microsoft.Playwright;
using PlaywriteFramework.Elements.Pages;

namespace PlaywriteFramework.Steps
{
    public  class GogolPageSteps
    {
        private readonly GogolPage gogolPage;

        public GogolPageSteps(IPage page)
        {
            gogolPage = new GogolPage(page);
        }

        public async Task TypeTextAndPressLuckButtonAsync(string text)
        {
            await gogolPage.TypeTextToSearchField(text);
            await gogolPage.PressLuckButton();
        }
    }
}
