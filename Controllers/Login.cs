using Administra.Models;
using Microsoft.AspNetCore.Mvc;

namespace Administra.Controllers
{
    public class Login : Controller
    {
        [HttpGet]
        public IActionResult Logar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Logar(Usuario objeto)
        {
            return View();
        }
    }
}
