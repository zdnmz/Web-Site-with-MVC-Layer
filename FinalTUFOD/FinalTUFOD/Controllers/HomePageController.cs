using FinalTUFOD.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalTUFOD.Controllers
{
    public class HomePageController : Controller
    {
        // GET: HomePage
        Context c = new Context();
        public ActionResult Index() // anasayfa
        {
            var variable = c.HomePages.ToList(); // listeleme işlemi veritabanı için
            return View(variable);
        }

        public PartialViewResult icons() // iconların kayıt tutulduğu view
        {
            var variable = c.icons.ToList(); // listeleme işlemi veritabanı için
            return PartialView(variable);
        }
    }
}