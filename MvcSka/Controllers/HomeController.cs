using System;
using System.Collections.Generic;
using System.Web.Mvc;
using MvcSka.Models.ViewModel;

namespace MvcSka.Controllers
{
    public class HomeController : Controller
    {
        private const int MaxAmount = 5000;
        private const int Row = 50;
        private Random random = new Random(DateTime.Now.Millisecond);
        private DateTime date = DateTime.Now;

        public ActionResult Index()
        {
            var model = new TableViewModel(GenerateRandomRows());
            return View(model);
        }

        private List<TableRow> GenerateRandomRows()
        {
            List<TableRow> list = new List<TableRow>();
            for (int i = 1; i <= Row; i++)
            {
                list.Add(new TableRow(i, GetRandomType(random.Next(MaxAmount)), date.AddDays(i), random.Next(MaxAmount)));
            }

            return list;
        }

        private string GetRandomType(int rand)
        {
            return rand % 2 == 0 ? "收入" : "支出";
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult TableChildAction()
        {
            var model = new TableViewModel(GenerateRandomRows());
            return View(model);
        }

        public ActionResult TableAjax()
        {
            var model = new TableViewModel(GenerateRandomRows());
            return View(model);
        }
    }
}
