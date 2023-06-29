using PlaywriteFramework.Utils;

namespace PlaywriteFramework.SetUp
{
    public class OneTimeSetUp
    {
        [OneTimeSetUp]
        public async Task SetUp()
        {

        }

        [OneTimeTearDown]
        public async Task TearDown()
        {
            await BrowserFactory.CloseAsync();
        }
    }
}
