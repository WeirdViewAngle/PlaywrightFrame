namespace PlaywriteFramework.Elements.Pages
{
    public class GogolSearchResultsPage : BasePage
    {
        private static string pageLocator = "//*[contains(@id, 'search')]//ancestor::*[contains(@id, 'rcnt')]";

        private GogolSearchResultsPage(IPage page) : base(page, pageLocator)
        {
        }

        public static async Task<GogolSearchResultsPage> CreateAsync(IPage page)
        {
            await CreateAsync(page, pageLocator);
            return new GogolSearchResultsPage(page);
        }
    }
}
