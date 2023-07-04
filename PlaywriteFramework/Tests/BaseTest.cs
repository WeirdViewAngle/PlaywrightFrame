using Microsoft.Playwright;
using PlaywriteFramework.Utils;
using PlaywriteFramework.Utils.Enums;

namespace PlaywriteFramework.Tests
{
    [TestFixtureSource(typeof(EnumProvider<BrowserEnum>), nameof(EnumProvider<BrowserEnum>.GetEnum))]
    public class BaseTest
    {
        protected IBrowserContext context;
        public static IBrowser Browser { get; set; }
        public static IPage Page { get; set; }

        private readonly BrowserEnum browserEnum;

        public BaseTest(BrowserEnum browserType)
        {
            browserEnum = browserType;
        }


        [SetUp]
        public async virtual Task SetUp()
        {
            try
            {
                Browser = await BrowserFactory.GetBrowser(browserEnum);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception during setup: {ex}");
                throw;
            }

            context = await Browser.NewContextAsync();

            Page = await context.NewPageAsync();

            // Go to google.com
            await Page.GotoAsync("https://www.google.com");
        }

        [TearDown]
        public async Task TearDown()
        {
            await context.CloseAsync();
        }
    }
}