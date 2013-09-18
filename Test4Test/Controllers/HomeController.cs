using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test4Test.Models;
using System.Web.SessionState;

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

        public ActionResult List()
        {

            return View(Paises);

        }

        public ActionResult Details(string nome)
        {
            var model = Paises.Where(x => x.Nome == nome).FirstOrDefault();
            if (model == null) return View("NotFound");
            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Pais pais)
        {
            if (!ModelState.IsValid)
                return View();
            Paises.Add(pais);
            return View("List", Paises);

        }

        public ActionResult Edit(string nome)
        {
            var model = Paises.Where(x => x.Nome == nome).FirstOrDefault();
            if (model == null) return View("NotFound");
            return View(model);
        }


        [HttpPost]
        public ActionResult Edit(string nome, FormCollection collection)
        {
            var paisAntigo = Paises.Where(x => x.Nome == nome).FirstOrDefault();
            paisAntigo.Continente = collection["Continente"];
            paisAntigo.Idioma = collection["Idioma"];
            return View("List", Paises);
        }


        public ActionResult Delete(string nome)
        {
            var model = Paises.Where(x => x.Nome == nome).FirstOrDefault();
            if (model == null) return View("NotFound");
            return View(model);
        }


        [HttpPost]
        public ActionResult Delete(string nome, FormCollection collection)
        {
            var paisDeletar = Paises.Where(x => x.Nome == nome).FirstOrDefault();
            Paises.Remove(paisDeletar);
            return View("List", Paises);
        }


    }
}
