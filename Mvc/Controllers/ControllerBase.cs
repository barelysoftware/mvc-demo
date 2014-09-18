
using System.Web.Mvc;
using TestWeb.Models;

namespace TestWeb.Controllers
{
    public class ControllerBase<T> :Controller where T : PageBase
    {
        [HttpPost]
         public virtual ActionResult Search(FormCollection formInputs)
        {


            return View("~/Views/Search/Index.cshtml");
        }
    }
}