using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AppPrawject.WebUI.Controllers
{
    [Authorize(Roles = "Provider")]
    public class ProviderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}