using AppPrawject.Data.Interfaces;
using AppPrawject.Domain.Model;
using System.Collections.Generic;

namespace AppPrawject.Service.Services
{
    public interface IPetService

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


    public class PetService : IPetService

    {
        private readonly IPetRepository _petRepository; //-->null
                                                        //Added a dependency to the constructor
        public PetService(IPetRepository petRepository)
        {
            _petRepository = petRepository;
        }


        public ICollection<Pet> GetAllPets()
        {

            return _petRepository.GetAllPets();
        }

        public Pet Create(Pet newPet)
        {
            //Add more logic to varify a new pet before creating a new pet

            return _petRepository.Create(newPet); //Create() is from the Repository
        }

        public bool Delete(int id)
        {
            return _petRepository.Delete(id);
        }

        public Pet GetById(int id)
        {
            return _petRepository.GetById(id);
        }

        public Pet Update(Pet updatedPet)
        {
            return _petRepository.Update(updatedPet);
        }
    }

}
