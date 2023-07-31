using PlaywriteFramework.Elements.Pages.Base;

namespace PlaywriteFramework.Elements.Pages
{
    public class GogolSearchResultsPage : BasePage
    {
        private GogolSearchResultsPage(IPage page) : base(page, "//*[contains(@id, 'search')]//ancestor::*[contains(@id, 'rcnt')]")
        {
        }

        public static async Task<GogolSearchResultsPage> CreateAsync(IPage page)
        {
            var mainPage = new GogolSearchResultsPage(page);
            await mainPage.InitializeAsync();
            return mainPage;
        }

        private async Task InitializeAsync()
        {
            // Perform asynchronous initialization here
        }
    }
}
