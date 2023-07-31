using PlaywriteFramework.Steps;
using PlaywriteFramework.Utils.Enums;

namespace PlaywriteFramework.Tests
{
    public class Test : BaseTestUI
    {
        public Test(BrowserEnum browserType) : base(browserType)
        {
        }

        [Test]
        public async Task GoogleSearchTestAsync()
        {
            var gololPageSteps = await GetGogolPageSteps();
            await gololPageSteps.TypeTextAndSearch("dgf");

            // Assert that at least one search result appears
            var firstResult = await Page.QuerySelectorAsync(".g");
            Assert.That(firstResult, Is.Not.Null);
        }


        private async Task<GogolPageSteps> GetGogolPageSteps() => await GogolPageSteps.CreateAsync(Page);
        private async Task<GogolSearchResultsPageSteps> GetGogolSearchResultsPageSteps() => await GogolSearchResultsPageSteps.CreateAsync(Page);
    }
}
