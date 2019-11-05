using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MinhaPrimeiraAplicacaoMVC.Models;

namespace MinhaPrimeiraAplicacaoMVC.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Default1/
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(EstagiarioModel estagiario)
        {
            return View();
        }
    }
}
