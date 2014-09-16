
using System.Web.Http;

namespace Mvc.Controllers.Api
{
    public class ColorMeController : ApiController
    {
        public string Get([FromUri]string color)
        {
            return string.Concat("<div class=\"test-block ", color," clearfix\">&nbsp;</div>");
        }
    }
}
