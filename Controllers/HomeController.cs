using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NET_Framework.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AboutUs()
        {
            ViewBag.Title = "Acerca de Nosotros";
            ViewBag.Message = "Pagina Acerca de Nosotros.";

            return View();
        }

        public ActionResult Producto()
        {
            ViewBag.Title = "Acerca de Productos";
            ViewBag.Message = "Pagina de vista de Productos.";

            return View();
        }

    }
}