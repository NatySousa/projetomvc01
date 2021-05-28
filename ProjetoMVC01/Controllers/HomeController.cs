using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoMVC01.Controllers
{
    [Authorize]//bloqueia o acesso as pags sem o login e senha(Autorização do NET CORE)
    public class HomeController : Controller
    {
        public IActionResult Index() // método que vai abrir a página Index
        {
            return View();
        }
    }
}
