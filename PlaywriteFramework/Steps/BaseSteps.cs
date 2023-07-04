namespace PlaywriteFramework.Steps
{
    public class BaseSteps
    {
        protected IPage Page { get; set; }

        protected BaseSteps(IPage page)
        {
            Page = page;
        }
    }
}
