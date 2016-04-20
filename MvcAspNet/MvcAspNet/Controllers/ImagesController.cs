using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcAspNet.Controllers
{
    public class ImagesController : Controller
    {
        // GET: Images
        public ActionResult TopTen()
        {
            return View();
        }
    }
}