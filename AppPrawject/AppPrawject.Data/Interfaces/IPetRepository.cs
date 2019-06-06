using AppPrawject.Domain.Model;
using System.Collections.Generic;

namespace AppPrawject.Data.Interfaces
{
    public interface IPetRepository
    {
        //Read
        Pet GetById(int id);
        ICollection<Pet> GetAllPetsByUserId(string userid);

        //Create
        Pet Create(Pet newPet);


        // Update
        Pet Update(Pet updatedPet);


        //Delete
        bool Delete(int id);
    }
}
