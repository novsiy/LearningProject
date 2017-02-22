using Novsiy.Web.Models.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Novsiy.Web.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            var model = new TestIndexViewModel();
            model.SomeValue = 10;


            return View(model);
        }
    }
}