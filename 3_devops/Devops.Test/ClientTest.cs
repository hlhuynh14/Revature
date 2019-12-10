using Devops.Client.Controllers;
using Xunit;



namespace Devops.Test
{
    public class ClientTest
    {
        private readonly Illoger<HomeController> logger = LoggerFactory.Create(o => o.SetMinimumLevel(LogLevel.Debug)).CreateLogger<HomeController>();
        [Fact]
        public void Test_IndexPage()
        {

            var home = new HomeController(logger);
            var index = home.Index();

            Assert.NotNull(index);
        }
    }
}