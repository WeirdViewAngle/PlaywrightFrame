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
            {
                await CreateBrowserAsync(browserType);
            }

            return _browser;
        }

        private async static Task CreateBrowserAsync(BrowserEnum browserType)
        {
            playwright = await Playwright.CreateAsync();
            IBrowser browser;

            switch (browserType)
            {
                case BrowserEnum.Chromium:
                    browser = await playwright.Chromium.LaunchAsync(
                        new BrowserTypeLaunchOptions { Headless = false });
                    break;
                case BrowserEnum.Firefox:
                    browser = await playwright.Firefox.LaunchAsync(
                        new BrowserTypeLaunchOptions { Headless = false });
                    break;
                case BrowserEnum.Webkit:
                    browser = await playwright.Webkit.LaunchAsync(
                        new BrowserTypeLaunchOptions { Headless = false });
                    break;
                default:
                    throw new ArgumentException("Invalid browser type");
            }

            _browser = browser;
        }

        public async static Task CloseAsync()
        {
            await _browser.CloseAsync();
            playwright.Dispose();
        }

    }
}
