using PlaywriteFramework.Elements.Pages;
using PlaywriteFramework.Steps;

namespace PlaywriteFramework.Tests
{
    public class Test : BaseTest
    {
        private GogolPageSteps gogolPageSteps = new();

        [Test]
        public async Task GoogleSearchTestAsync()
        {

            // Type "Microsoft Playwright for .NET" into the search box and press Enter
            await page.TypeAsync("input[name=q]", "Microsoft Playwright for .NET");
            await page.PressAsync("input[name=q]", "Enter");

            // Wait for the results to load
            await page.WaitForNavigationAsync();

            // Assert that at least one search result appears
            var firstResult = await page.QuerySelectorAsync(".g");
            Assert.That(firstResult, Is.Not.Null);
        }

        [Test]
        public async Task GoogleSearchTestAsync2()
        {
            // Go to google.com
            var pageTo = new GogolPage(page);
            await pageTo.WaitForPageOpenedAsync();
        }
    }
}
