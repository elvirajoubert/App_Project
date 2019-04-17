using AppPrawject.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AppPrawject.WebUI.Controllers
{
    public class PetController : Controller
    {

        private List<Pet> Pets = new List<Pet>();

        //pet/index
        public IActionResult Index()
        {
            return View(Pets);
        }

        //pet/add
        public IActionResult Add()
        {
            return View();
        }

    }
}

