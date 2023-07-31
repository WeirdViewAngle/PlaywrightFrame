namespace PlaywriteFramework.Elements.Pages.Base
{
    public interface IBasePage
    {
        string Locator { get; set; }
        Task NavigateAsync();
        Task WaitForLoadedAsync();
    }
}
