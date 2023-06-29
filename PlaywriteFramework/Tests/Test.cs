using PlaywriteFramework.Elements.Pages;

namespace PlaywriteFramework.Tests
{
    public class Test : BaseTest
    {
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
        public async Task GoogleSearchTestAsync()
        {
            // Go to google.com
            var page = new GogolPage();
            page.Page.
        }
    }
}
