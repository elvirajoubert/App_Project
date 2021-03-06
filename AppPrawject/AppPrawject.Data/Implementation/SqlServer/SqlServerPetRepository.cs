﻿using AppPrawject.Data.Context;
using AppPrawject.Data.Interfaces;
using AppPrawject.Domain.Model;
using System.Collections.Generic;
using System.Linq;

namespace AppPrawject.Data.Implementation.SqlServer
{
    public class SqlServerPetRepository : IPetRepository
    {

        public Pet GetById(int id)
        {
            using (var context = new AppPrawjectDbContext())


            {
                //SQL -> Database look for table properties
                //if not found returns null vlue - rather than an exception
                var pet = context.Pets.SingleOrDefault(p => p.Id == id);
                return pet;
            }
        }

        public ICollection<Pet> GetAllPetsByUserId(string userId)
        {
            using (var context = new AppPrawjectDbContext())
            {
                //DBSet != ICollection
                return context.Pets.Where(p => p.AppUserId == userId).ToList(); //Now it is ICollection
            }
        }

        public Pet Create(Pet newPet)
        {
            using (var context = new AppPrawjectDbContext())
            {
                context.Pets.Add(newPet);
                context.SaveChanges();
                return newPet; //newPet.Id. will be populated with new DB value
            }
        }

        public Pet Update(Pet updatedPet)
        {
            using (var context = new AppPrawjectDbContext())
            {

                //find the old entity
                var oldPet = GetById(updatedPet.Id);

                // update each entity properties -->/ get; set;
                context.Entry(oldPet).CurrentValues.SetValues(updatedPet);

                // save changes
                context.Pets.Update(oldPet);
                context.SaveChanges();

                return oldPet; // To ensure that the Save happened
            }
        }
        public bool Delete(int id)
        {

            using (var context = new AppPrawjectDbContext())
            {

                //Find what we are going to delete
                var petToBeDeleted = GetById(id);

                //delete
                context.Pets.Remove(petToBeDeleted);


                //save changes
                context.SaveChanges();

                //check if entity/model exist
                if (GetById(id) == null)
                {
                    return true;
                }
                return false;

            }






        }


    }
}
