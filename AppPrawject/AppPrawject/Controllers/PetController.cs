﻿using AppPrawject.Models;
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
            return View();
        }


        [HttpPost]
        public IActionResult Add(Pet newPet)
        {
            Pets.Add(newPet);
            return View(nameof(Index), Pets);


        }

        public IActionResult Detail(int id) //get id from URL
        {
            var pet = Pets.Single(p => p.Id == id);

            return View(pet);
        }



    }
}

