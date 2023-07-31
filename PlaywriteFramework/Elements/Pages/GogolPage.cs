using PlaywriteFramework.Elements.Pages.Base;

namespace PlaywriteFramework.Elements.Pages
{
    public class GogolPage : BasePage
    {
        private readonly string searchLocator = "//textarea[contains(@name, 'q')]";
        private readonly string luckButtonLocator = "(//input[contains(@name, 'btnI')])[last()]";
        private readonly static string pageLocator = "//*[contains(@alt, 'Google')]";

        private GogolPage(IPage page) : base(page, pageLocator)
        {
        }

        public static async Task<GogolPage> CreateAsync(IPage page)
        {
            var mainPage = new GogolPage(page);
            await mainPage.InitializeAsync();
            return mainPage;
        }

        public async Task TypeTextToSearchField(string text)
        {
            await _page.TypeAsync(searchLocator, text);
        }

        public async Task Search()
        {
            await _page.PressAsync(searchLocator, "Enter");
        }

        public async Task PressLuckButton()
        {
            await _page.ClickAsync(luckButtonLocator);
        }

        private async Task InitializeAsync()
        {
            // Perform asynchronous initialization here
        }
    }
}
