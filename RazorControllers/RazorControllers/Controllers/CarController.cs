using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RazorControllers.Controllers
{
    public class CarController : Controller
    {
        // GET: Car
        public ActionResult Driver()
        {
            // Bygga modell och skicka till viewn
            return View();
        }
        public ActionResult BrumBrum()
        {
            return View();
        }
        public ActionResult ViewDataTransfer()
        {
            ViewData["beauty"] = "Det är en häst";
            return View();
        }



        [ActionName("Lisa")]

        public ActionResult ViewBagTransfer()
        {
            ViewBag.Lisa = "Smurfarna är blå med vita hattar";
            return View();
        }

        public ViewResult OddNumbers()
        {
            var oddNumbers = (ParallelEnumerable.Range(10, 40))
                .Where(x => x % 2 != 0)
                .Select(x => x).ToList();
            ViewData.Model = oddNumbers;
            return View();
        }
    }
}