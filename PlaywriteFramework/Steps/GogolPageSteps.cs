using PlaywriteFramework.Elements.Pages;

namespace PlaywriteFramework.Steps
{
    public class GogolPageSteps : BaseSteps
    {
        private GogolPage gogolPage;

        private GogolPageSteps(IPage page, GogolPage gogolPage) : base(page)
        {
            this.gogolPage = gogolPage;
        }

        public static async Task<GogolPageSteps> CreateAsync(IPage page)
        {
            var gogolPage = await GogolPage.CreateAsync(page);
            return new GogolPageSteps(page, gogolPage);
        }

        public async Task PressLuckButtonAsync()
        {
            await gogolPage.PressLuckButton();
        }

        public async Task TypeTextAndSearch(string text)
        {
            await gogolPage.TypeTextToSearchField(text);
            await gogolPage.Search();
        }
    }
}
