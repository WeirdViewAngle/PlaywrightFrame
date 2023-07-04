namespace PlaywriteFramework.Elements.Pages
{
    public class BasePage
    {
        protected readonly IPage Page;
        protected readonly string PageLocator;

        protected BasePage(IPage page, string pageDefiningElementLocator)
        {
            Page = page;
            PageLocator = pageDefiningElementLocator;
        }

        public static async Task<BasePage> CreateAsync(IPage page, string pageDefiningElementLocator)
        {
            var basePage = new BasePage(page, pageDefiningElementLocator);
            await basePage.AssertThatPageOpened();
            return basePage;
        }

        public async Task AssertThatPageOpened()
        {
            await Page.WaitForLoadStateAsync(LoadState.DOMContentLoaded);
            await Page.CheckAsync(PageLocator, new PageCheckOptions() { Timeout = 10.0f });
        }
    }
}
