using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AppValidaIdade.Models;

namespace AppValidaIdade.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(HomeModel login)
        {
            if (login.campoNome != null && login.campoNome.Length < 20)
            {
                ModelState.AddModelError("campoNome", "O nome é muito pequeno!");
            }

            if (login.campoIdade != null){
                if (login.campoIdade < 0)
                {
                    ModelState.AddModelError("campoIdade", "A idade não pode ser negativa!");
                }
                if (login.campoIdade < 18)
                {
                    ModelState.AddModelError("campoIdade", "O usuário precisa ser maior de 18 anos!");
                }
            }
            return View();
        }
    }
}
