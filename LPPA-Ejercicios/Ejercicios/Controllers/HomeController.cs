using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ejercicios.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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

        public ActionResult Ejercicio1()
        {
            return View();
        }
        public ActionResult Ejercicio2()
        {
            return View();
        }
        public ActionResult Ejercicio3()
        {
            return View();
        }
        public ActionResult Ejercicio4()
        {
            return View();
        }
        public ActionResult Enlaces()
        {
            return View();
        }
        public ActionResult Listas()
        {
            return View();
        }
        public ActionResult Tablas1()
        {
            return View();
        }
        public ActionResult Tablas2()
        {
            return View();
        }
        public ActionResult Formularios1()
        {
            return View();
        }
        public ActionResult Formularios2()
        {
            return View();
        }
        public ActionResult Formularios3()
        {
            return View();
        }

    }
}