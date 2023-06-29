using Microsoft.Playwright;

namespace PlaywriteFramework.Elements.Pages
{
    public class BasePage
    {
        protected readonly IPage page;
        private readonly string pageLocator;

        public BasePage(IPage page, string pageDefiningElementLocator)
        {
            this.page = page;
            pageLocator = pageDefiningElementLocator;
        }

        public async Task WaitForPageOpenedAsync()
        {
            await page.WaitForLoadStateAsync(LoadState.DOMContentLoaded);
            await page.CheckAsync(pageLocator, new PageCheckOptions() { Timeout = 10.0f });
        }
    }
}
