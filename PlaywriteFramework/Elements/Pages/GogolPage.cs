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
            await CreateAsync(page, pageLocator);
            return new GogolPage(page);
        }

        public async Task TypeTextToSearchField(string text)
        {
            await Page.TypeAsync(searchLocator, text);
        }

        public async Task Search()
        {
            await Page.PressAsync(searchLocator, "Enter");
        }

        public async Task PressLuckButton()
        {
            await Page.ClickAsync(luckButtonLocator);
        }
    }
}
