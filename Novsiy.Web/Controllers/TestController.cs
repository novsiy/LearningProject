using Novsiy.Business.Contracts;
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
        private readonly IQuestionnaireService _questionnaireService;

        public TestController(IQuestionnaireService questionnaireService)
        {
            _questionnaireService = questionnaireService;
        }

        // GET: Test
        public ActionResult Index()
        {
            var model = new TestIndexViewModel();
            model.SomeValue = 10;


            return View(model);
        }

        public ActionResult BookQuestionnaire()
        {
            return View();
        }

        [HttpPost]
        public ActionResult BookQuestionnaire(BookQuestionnaireViewModel model)
        {
            var result = _questionnaireService.SaveBookQuestionnaireResult(model.ToBookQuestionnaire());

            model = BookQuestionnaireViewModel.ToModel(result);
            model.Result = "Сохранено";

            return View(model);
        }

    }
}