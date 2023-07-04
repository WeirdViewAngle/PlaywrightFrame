using PlaywriteFramework.Elements.Pages;

namespace PlaywriteFramework.Steps
{
    public class GogolSearchResultsPageSteps : BaseSteps
    {
        private readonly GogolSearchResultsPage gogolSearchResultsPage;

        private GogolSearchResultsPageSteps(IPage page, GogolSearchResultsPage gogolSearchResultsPage) : base(page)
        {
            this.gogolSearchResultsPage = gogolSearchResultsPage;
        }

        public static async Task<GogolSearchResultsPageSteps> CreateAsync(IPage page)
        {
            var gogolPage = await GogolSearchResultsPage.CreateAsync(page);
            return new GogolSearchResultsPageSteps(page, gogolPage);
        }
    }
}
