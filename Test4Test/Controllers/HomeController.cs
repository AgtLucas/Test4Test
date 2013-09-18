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

        public List<Pais> Paises
        {
            get
            {
                if (Session["paises"] == null)
                {
                    List<Pais> paises = new List<Pais>{
            new Pais{ Nome = "Brasil", Continente = "América do Sul", Idioma = "Português"},
            new Pais{ Nome = "Alemanha", Continente = "Europa", Idioma = "Alemão"},
            new Pais{ Nome = "Argentina", Continente = "América do Sul", Idioma = "Espanhol"}};
                    Session.Add("paises", paises);
                }

                return (List<Pais>)Session["paises"];
            }
            set
            {
                Session["paises"] = value;
            }

        }


    }
}
