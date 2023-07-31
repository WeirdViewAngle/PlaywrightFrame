using PlaywriteFramework.Utils;
using PlaywriteFramework.Utils.Enums;

namespace PlaywriteFramework.Tests
{
    [TestFixtureSource(typeof(EnumProvider<BrowserEnum>), nameof(EnumProvider<BrowserEnum>.GetEnum))]
    public class BaseTestUI
    {
        protected IBrowser Browser;
        protected IPage Page;

        public BaseTestUI(BrowserEnum browser)
        {
            BrowserType = browser;
        }

        public BrowserEnum BrowserType { get; private set; }

        [SetUp]
        public async Task Setup()
        {
            try
            {
                // Create a new Browser instance for each test
                Browser = await BrowserFactory.CreateBrowserAsync(BrowserType);
                // Create a new context from the Browser
                var context = await Browser.NewContextAsync();
                // Create a new Page from the context
                Page = await context.NewPageAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Exception during setup: {ex}");
            }
        }

        [TearDown]
        public async Task TearDown()
        {
            await Browser.CloseAsync();
        }
    }
}