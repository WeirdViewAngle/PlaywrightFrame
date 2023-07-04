using Microsoft.Playwright;
using PlaywriteFramework.Utils.Enums;

namespace PlaywriteFramework.Utils
{
    public static class BrowserFactory
    {
        private static IPlaywright playwright;
        private static IBrowser? _browser = null;

        public async static Task<IBrowser> GetBrowser(
            BrowserEnum browserType = BrowserEnum.Chromium)
        {
            if (_browser == null)
                await CreateBrowserAsync(browserType);

            return _browser ?? throw new Exception("Browser instance was not created");
        }

        private async static Task CreateBrowserAsync(BrowserEnum browserType)
        {
            playwright = await Playwright.CreateAsync();

            switch (browserType)
            {
                case BrowserEnum.Chromium:
                    _browser = await playwright.Chromium.LaunchAsync(
                        new BrowserTypeLaunchOptions { Headless = false });
                    break;
                case BrowserEnum.Firefox:
                    _browser = await playwright.Firefox.LaunchAsync(
                        new BrowserTypeLaunchOptions { Headless = false });
                    break;
                case BrowserEnum.Webkit:
                    _browser = await playwright.Webkit.LaunchAsync(
                        new BrowserTypeLaunchOptions { Headless = false });
                    break;
                default:
                    throw new ArgumentException("Invalid browser type");
            }
        }

        public async static Task CloseAsync()
        {
            await _browser.CloseAsync();
            playwright.Dispose();
        }

    }
}
