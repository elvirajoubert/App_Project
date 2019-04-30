using AppPrawject.Domain.Models;

namespace AppPrawject.Data.Interfaces
{
    public interface IPetRepository
    {
        //Read
        Pet GetById(int id);
        //IColletion<Pet> GetByOwnerId(int ownerId);

        //Create
        Pet Create(Pet newPet);


        // Update
        Pet Update(Pet updatedPet);


        //Delete
        bool Delete(int id);
    }
}
