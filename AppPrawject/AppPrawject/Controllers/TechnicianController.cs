using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AppPrawject.WebUI.Controllers
{
    [Authorize(Roles = "Technician")]
    public class TechnicianController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}