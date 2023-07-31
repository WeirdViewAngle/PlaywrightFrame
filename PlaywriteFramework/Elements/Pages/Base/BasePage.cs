namespace PlaywriteFramework.Elements.Pages.Base
{
    public class BasePage : IBasePage
    {
        protected volatile IPage _page;
        public string Locator { get; set; }

        public BasePage(IPage page, string locator)
        {
            _page = page;
            Locator = locator;
        }

        public async Task NavigateAsync()
        {
            await _page.GotoAsync("");
        }

        public async Task WaitForLoadedAsync()
        {
            await _page.WaitForLoadStateAsync(LoadState.DOMContentLoaded);
            await _page.WaitForSelectorAsync(Locator, new PageWaitForSelectorOptions() { Timeout = 30000 });
        }
    }
}
