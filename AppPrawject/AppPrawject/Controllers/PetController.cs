using Microsoft.AspNetCore.Mvc;

namespace AppPrawject.WebUI.Controllers
{
    public class PetController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}