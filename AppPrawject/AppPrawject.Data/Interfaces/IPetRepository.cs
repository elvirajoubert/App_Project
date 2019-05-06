using AppPrawject.Domain.Models;
using System.Collections.Generic;

namespace AppPrawject.Data.Interfaces
{
    public interface IPetRepository
    {
        //Read
        Pet GetById(int id);
        ICollection<Pet> GetAllPets();

        //Create
        Pet Create(Pet newPet);


        // Update
        Pet Update(Pet updatedPet);


        //Delete
        bool Delete(int id);
    }
}
