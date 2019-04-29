using AppPrawject.Domain;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;


namespace AppPrawject.WebUI.Controllers
{
    public class PetController : Controller
    {

        private List<Pet> Pets = new List<Pet>
        {
            new Pet { Id = 1, Name="Molly", Breed ="Border Collie", Weight= 40 },
            new Pet { Id = 2, Name="Holly", Breed ="Beagle", Weight= 35}
        };

        //GET pet/index
        public IActionResult Index()
        {
            return View(Pets);
        }

        //pet/add
        public IActionResult Add()
        {
            return View("Form"); //-->Add.cshtml
        }


        [HttpPost]
        public IActionResult Add(Pet newPet)  //-> receives data from HTML form
        {

            if (ModelState.IsValid) //all required fields are completed
            {
                //we should be able to add new pet 
                Pets.Add(newPet);
                return View(nameof(Index), Pets);
            }

            return View("form", newPet);


        }

        public IActionResult Detail(int id) //get id from URL
        {
            var pet = Pets.Single(p => p.Id == id);

            return View(pet);
        }

        public IActionResult Delete(int id)
        {
            var pet = Pets.Single(p => p.Id == id);
            Pets.Remove(pet);

            return View(nameof(Index), Pets);
        }

        //pet/edit/1
        public IActionResult Edit(int id) //get id from URL
        {
            var pet = Pets.Single(p => p.Id == id);
            return View("Form", pet);// Edit.cshtml, renamed to Form.cshtml
        }

        [HttpPost]
        public IActionResult Edit(Pet updatedPet)
        {
            var oldPet = Pets.Single(p => p.Id == updatedPet.Id);
            oldPet.Name = updatedPet.Name;
            oldPet.Breed = updatedPet.Breed;
            oldPet.Weight = updatedPet.Weight;
            oldPet.Image = updatedPet.Image;

            return View(nameof(Index), Pets);
        }


    }
}

