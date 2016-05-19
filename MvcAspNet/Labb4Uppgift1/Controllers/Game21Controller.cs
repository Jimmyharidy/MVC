using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Labb4Uppgift1.Models;

namespace Labb4Uppgift1.Controllers
{
    public class Game21Controller : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        // GET: Game21
        public PartialViewResult _Logic()
        {
            var game21 = new Game21();
            Session["game21"] = game21;

            return PartialView(game21);
        }

        // POST: Game21
        [HttpPost]
        public PartialViewResult _Logic(int add)
        {
            var game21 = (Game21)Session["game21"];
            game21.AddNr(add);
            return PartialView(game21);
        }
    }
}