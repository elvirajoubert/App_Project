using AppPrawject.Domain.Models;
using AppPrawject.Service.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AppPrawject.WebUI.Controllers
{
    public class PetController : Controller
    {
        private readonly IPetService _petService;

        public PetController(IPetService petService)

        {
            _petService = petService;
        }

        //GET pet/index
        public IActionResult Index()
        {
            var pets = _petService.GetAll
            return View();
        }

        private IActionResult View(object pets)
        {
            throw new NotImplementedException();
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

            return View("form");


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
            if (ModelState.IsValid)
            {
                var oldPet = Pets.Single(p => p.Id == updatedPet.Id);
                oldPet.Name = updatedPet.Name;
                oldPet.Breed = updatedPet.Breed;
                oldPet.Weight = updatedPet.Weight;
                oldPet.Image = updatedPet.Image;

                return View(nameof(Index), Pets);

            }
            return View("Form", updatedPet); //By passing updatedPet we trigger the logic for Edit Form.cshtml

        }


    }
}

