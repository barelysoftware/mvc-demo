
using System.Web.Http;
using Newtonsoft.Json;

namespace Mvc.Controllers.Api
{
    public class ColorMeController : ApiController
    {
        public string Get(string id)
        {
            return JsonConvert.SerializeObject(new { content = string.Concat("<div class=\"test-block ", id," clearfix\">&nbsp;</div>")});
        }
    }
}
