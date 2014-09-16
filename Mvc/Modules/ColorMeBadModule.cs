using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy;

namespace Mvc.Modules
{
    public class ColorMeBadModule : NancyModule
    {
        public ColorMeBadModule() : base("/nancy")
        {
            Get["/colormebad/{color}"] = parameters => string.Concat("<div class=\"test-block ", parameters.color,
                                                                     " clearfix\">&nbsp;</div>");
        }
    }
}