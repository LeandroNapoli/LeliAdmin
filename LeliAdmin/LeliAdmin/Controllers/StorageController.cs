using Microsoft.AspNetCore.Mvc;

namespace LeliAdmin.Controllers
{
    public class StorageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
