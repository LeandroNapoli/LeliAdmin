using LeliAdmin.Model.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace LeliAdmin.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel login)
        {
            var alo = login;
            return RedirectToAction("Index","Home");
        }
    }
}
