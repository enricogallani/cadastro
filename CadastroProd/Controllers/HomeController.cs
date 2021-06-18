using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CadastroProd.Models;

namespace CadastroProd.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var prod = new Produto(); 
            return View(prod); 
        }
        [HttpPost]
        public ActionResult Index(Produto prod)
        {
            if (ModelState.IsValid) 
            {
                return View("Resultado", prod);
            }
            return View(prod);
        }
        public ActionResult Resultado(Produto prod)
        {
            return View(prod);
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
    }
}