using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc.Models
{
    public class LayoutModel
    {
        public string Title { get; set; }
        public IEnumerable<PageBase> MenuPages { get; set; } 
    }
}