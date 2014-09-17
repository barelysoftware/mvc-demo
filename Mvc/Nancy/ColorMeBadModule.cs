using Nancy;

namespace Mvc.Modules
{
    public class ColorMeBadModule : NancyModule
    {
        public ColorMeBadModule()
            : base("/nancy")
        {
            Get["/colormebad"] = parameters => "Yo!";

            Get["/colormebad/{color}"] = parameters =>
                                         !string.IsNullOrEmpty(parameters["color"])
                                             ? string.Concat("<div class=\"test-block ", parameters["color"],
                                                             " clearfix\">&nbsp;</div>")
                                             : "";
        }
    }
}