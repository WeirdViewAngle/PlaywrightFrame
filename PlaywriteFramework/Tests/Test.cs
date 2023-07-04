using PlaywriteFramework.Elements.Pages;
using PlaywriteFramework.Steps;
using PlaywriteFramework.Utils.Enums;

namespace PlaywriteFramework.Tests
{
    public class Test : BaseTest
    {
        private GogolPageSteps gogolPageSteps; 
        private GogolSearchResultsPageSteps gogolSearchResultsSteps;

        public Test(BrowserEnum browserType) : base(browserType)
        {
        }

        [SetUp]
        public override async Task SetUp()
        {
            await base.SetUp();
            gogolPageSteps = await GogolPageSteps.CreateAsync(Page);
            gogolSearchResultsSteps = await GogolSearchResultsPageSteps.CreateAsync(Page);
        }

        [Test]
        public async Task GoogleSearchTestAsync()
        {
            await gogolPageSteps.TypeTextAndSearch("dgf");

            // Assert that at least one search result appears
            var firstResult = await Page.QuerySelectorAsync(".g");
            Assert.That(firstResult, Is.Not.Null);
        }

        
    }
}
