using Microsoft.Playwright;
using PlaywriteFramework.Utils.Enums;

namespace PlaywriteFramework.Utils
{
    public static class BrowserFactory
    {
        private static readonly object _lock = new();
        private static IPlaywright _playwright;

        public async static Task<IBrowser> CreateBrowserAsync(BrowserEnum browser)
        {
            lock (_lock)
            {
                _playwright ??= Playwright.CreateAsync().GetAwaiter().GetResult();
            }

            var browserOptions = new BrowserTypeLaunchOptions() { Headless = false };

            return browser switch
            {
                BrowserEnum.Chromium => await _playwright.Chromium.LaunchAsync(browserOptions),
                BrowserEnum.Firefox => await _playwright.Firefox.LaunchAsync(browserOptions),
                BrowserEnum.Webkit => await _playwright.Webkit.LaunchAsync(browserOptions),
                _ => throw new ArgumentOutOfRangeException(),
            };
        }
    }
}
