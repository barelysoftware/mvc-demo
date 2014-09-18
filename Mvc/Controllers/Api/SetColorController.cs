
using System.Web.Http;
using Newtonsoft.Json;

namespace TestWeb.Controllers.Api
{
    public class ColorMeController : ApiController
    {

        public string Get()
        {
            return string.Empty;
        }

        public string Get(string id)
        {
            return JsonConvert.SerializeObject(new { content = string.Concat("<div class=\"test-block ", id," clearfix\">&nbsp;</div>")});
        }
    }
}
