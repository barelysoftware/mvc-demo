using TestWeb.Controllers.Api;
using Xunit;

namespace TestWeb.Tests
{
    public class ApiControllerTests
    {
        [Fact]
        public void TestGetAction()
        {
            var controller = new ColorMeController();

            var actual = controller.Get("");

            Assert.Equal("{\"content\":\"<div class=\\\"test-block  clearfix\\\">&nbsp;</div>\"}",actual);
        }

        [Fact]
        public void TestGetBlueAction()
        {
            var controller = new ColorMeController();

            var actual = controller.Get("blue");

            Assert.Equal("{\"content\":\"<div class=\\\"test-block blue clearfix\\\">&nbsp;</div>\"}", actual);
        }
    }
}
