using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Test4Test.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            ViewBag.Message = "ViewBag do ASP.NET MVC!";
            ViewData["Mensagem"] = "ViewData do ASP.NET MVC!";
            TempData["Mensagem"] = "TempData do ASP.NET MVC!";

            return View();
        }

    }
}
