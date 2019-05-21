using AppPrawject.Domain.Model;
using AppPrawject.Service.Services;
using Microsoft.AspNetCore.Mvc;

namespace AppPrawject.WebUI.Controllers
{
    public class PetController : Controller

    {
        private const string PETBREEDS = "PetBreeds";
        private readonly IPetService _petService;
        private readonly IPetBreedService _petBreedService;

        public PetController(IPetService petService, IPetBreedService petBreedService)

        {
            _petService = petService;
            _petBreedService = petBreedService;
        }

        // pet/index
        public IActionResult Index()
        {
            //check if we got any error in TempData
            if (TempData["Error"] != null)
            {
                //Pass that error to the ViewData, because we are communicating b/n Action and View
                ViewData.Add("Error", TempData["Error"]);
            }

            var pets = _petService.GetAllPets();
            return View(pets);
        }


        [HttpGet]
        public IActionResult Add()
        {
            GetPetBreeds();

            return View("Form"); //-->Add.cshtml renamed to Form.cshtml
        }



        [HttpPost]
        public IActionResult Add(Pet newPet)  //-> receives data from HTML form
        {

            if (ModelState.IsValid) //all required fields are completed
            {
                //we should be able to add new pet 
                _petService.Create(newPet);
                return RedirectToAction(nameof(Index)); // -> Index();
            }

            GetPetBreeds();
            return View("Form");

        }




        public IActionResult Detail(int id) //get id from URL
        {
            var pet = _petService.GetById(id);
            return View(pet);
        }

        public IActionResult Delete(int id)
        {
            var succeeded = _petService.Delete(id);

            if (!succeeded)//when delete 
                //Using tempdata = because we are communicating
                //between actions - from Delete to Index
                TempData.Add("Error", "Oops, something went wrong, this pet cannot be deleted.Try again later");

            return RedirectToAction(nameof(Index));


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

        private void GetPetBreeds()
        {

            var petBreeds = _petBreedService.GetAll();
            ViewData.Add("PETBREEDS", petBreeds);
        }
    }
}







