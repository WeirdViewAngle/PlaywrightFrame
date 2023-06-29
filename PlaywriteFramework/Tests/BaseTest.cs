using Microsoft.Playwright;
using PlaywriteFramework.Utils;

namespace PlaywriteFramework.Tests
{
    public class BaseTest
    {
        protected IPlaywright playwright;
        protected IBrowser browser;
        protected IBrowserContext context;
        protected IPage page;

        [SetUp]
        public async Task TestSetUp()
        {
            try
            {
                var browser = BrowserFactory.GetBrowser();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception during setup: {ex}");
                throw;
            }

            context = await browser.NewContextAsync();
            page = await context.NewPageAsync();

            // Go to google.com
            await page.GotoAsync("https://www.google.com");
        }

        [TearDown]
        public async Task TestTearDown()
        {
            await context.CloseAsync();
        }
    }
}