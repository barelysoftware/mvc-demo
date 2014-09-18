using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestWeb.Models
{
    public class LayoutModel
    {
        public string Title { get; set; }
        public IEnumerable<PageBase> MenuPages { get; set; } 
    }
}