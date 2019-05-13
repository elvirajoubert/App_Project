using AppPrawject.Domain.Models;
using AppPrawject.Service.Services;
using Microsoft.AspNetCore.Mvc;

namespace AppPrawject.WebUI.Controllers
{
    public class PetController : Controller
    {
        private readonly IPetService _petService;

        public PetController(IPetService petService)

        {
            _petService = petService;
        }

        // pet/index
        public IActionResult Index()
        {
            var pets = _petService.GetAllPets();
            return View(pets);
        }



        public IActionResult Add()
        {
            return View("Form"); //-->Add.cshtml renamed to Form.cshtml
        }



        [HttpPost]
        public IActionResult Add(Pet newPet)  //-> receives data from HTML form
        {

            if (ModelState.IsValid) //all required fields are completed
            {
                //we should be able to add new pet 
                _petService.Create(newPet);
                return RedirectToAction(nameof(Index));
            }

            return View("form");

        }




        public IActionResult Detail(int id) //get id from URL
        {
            var pet = _petService.GetById(id);
            return View(pet);
        }

        public IActionResult Delete(int id)
        {
            var succeeded = _petService.Delete(id);

            if (!succeeded)//when delete fails
                ViewBag.Error = "Oops, something went wrong, this pet cannot be deleted.Try again later";
            {
                return RedirectToAction(nameof(Index));

            }
        }




        //pet/edit/1
        public IActionResult Edit(int id) //get id from URL
        {
            var pet = _petService.GetById(id);
            return View("Form", pet);// Edit.cshtml, renamed to Form.cshtml
        }

        [HttpPost]
        public IActionResult Edit(Pet updatedPet)
        {
            if (ModelState.IsValid)
            {
                _petService.Update(updatedPet);
                return RedirectToAction(nameof(Index));

            }
            return View("Form", updatedPet); //By passing updatedPet we trigger the logic for Edit Form.cshtml

        }
    }
}







