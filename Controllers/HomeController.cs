using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Descreva sua aplicação.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contato da sua página.";

            return View();
        }
    }
}