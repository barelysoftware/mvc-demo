
using System.Web.Mvc;
using Mvc.Models;

namespace Mvc.Controllers
{
    public class HomeController : ControllerBase<HomeModel>
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            var viewModel = CreateModel();

            return View(viewModel);
        }

        public ActionResult GetBlue()
        {
            var viewModel = CreateModel();
            viewModel.CurrentModel.Color = "blue";
            return View("Index",viewModel);
        }

        public ActionResult GetYellow()
        {
            var viewModel = CreateModel();
            viewModel.CurrentModel.Color = "yellow";

            return View("Index", viewModel);
        }

        public ActionResult Reset()
        {
            var viewModel = CreateModel();

            return View("Index", viewModel);
        }

        [ChildActionOnly]
        public string SetColor(PageViewModel<HomeModel> model)
        {

            return !string.IsNullOrEmpty(model.CurrentModel.Color) ?  string.Concat("<div class=\"test-block ", model.CurrentModel.Color," clearfix\">&nbsp;</div>") : "";
        }

        private PageViewModel<HomeModel> CreateModel()
        {
            var model = new HomeModel();

            var viewModel = PageViewModel.Create(model);

            return viewModel;
        } 
    }
}
