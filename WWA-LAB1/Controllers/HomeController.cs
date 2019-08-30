using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WWA_LAB1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult HomePage()
        {
            return View();
        }
        public ActionResult Semester5Page()
        {
            return View();
        }
        public ActionResult TestimonialsPage()
        {
            return View();
        }
    }
}