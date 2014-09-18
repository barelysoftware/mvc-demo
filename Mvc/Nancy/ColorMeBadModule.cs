using Nancy;
using Newtonsoft.Json;

namespace Mvc.Modules
{
    public class ColorMeBadModule : NancyModule
    {
        public ColorMeBadModule()
            : base("/nancy")
        {
            Get["/colormebad"] = parameters => "Yo!";

            Get["/colormebad/{color}"] = parameters =>
                {
                    var response = (Response)JsonConvert.SerializeObject(new
                        {
                            content = (!string.IsNullOrEmpty(parameters["color"])
                                           ? string.Concat("<div class=\"test-block ",
                                                           parameters["color"],
                                                           " clearfix\">&nbsp;</div>")
                                           : "")
                        });

                    response.ContentType = "application/json";

                    return response;
                };
        }
    }
}