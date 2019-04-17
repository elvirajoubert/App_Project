using AppPrawject.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AppPrawject.WebUI.Controllers
{
    public class PetController : Controller
    {

        private List<Pet> Pets = new List<Pet>();

        //GET pet/index
        public IActionResult Index()
        {
            return View(Pets);
        }

        //pet/add
        public IActionResult Add()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Add(Pet newPet)
        {
            Pets.Add(newPet);
            return View(nameof(Index), Pets);


        }



    }
}

