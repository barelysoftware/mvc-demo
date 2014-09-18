using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using TestWeb.Controllers;
using TestWeb.Models;
using Xunit;

namespace Tests
{
    
    public class HomeControllerTests
    {
        [Fact]
        public void TestIndexAction()
        {
            var controller = new HomeController();

            var actual = controller.Index();

            Assert.IsType<ViewResult>(actual);
            var view = actual as ViewResult;
            Assert.IsType<PageViewModel<HomeModel>>(view.Model);
            var model = view.Model as PageViewModel<HomeModel>;

            Assert.NotNull(model);
            Assert.Null(model.CurrentModel.Color);
        }

        [Fact]
        public void TestGetBlueAction()
        {
            var controller = new HomeController();

            var actual = controller.GetBlue();

            Assert.IsType<ViewResult>(actual);
            var view = actual as ViewResult;
            Assert.IsType<PageViewModel<HomeModel>>(view.Model);
            var model = view.Model as PageViewModel<HomeModel>;

            Assert.NotNull(model);
            Assert.Equal("blue",model.CurrentModel.Color);
        }
    }
}
