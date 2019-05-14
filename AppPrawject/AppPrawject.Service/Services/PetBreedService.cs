using AppPrawject.Data.Interfaces;
using AppPrawject.Domain.Model;
using System.Collections.Generic;

namespace AppPrawject.Service.Services
{


    public interface IPetBreed
    {
        //Read
        PetBreed GetById(int id);

        ICollection<PetBreed> GetAll();
    }

    public class PetBreedService : IPetBreedService

    {
        private readonly IPetBreedRepository _petBreedRepository;

        public PetBreedService(IPetBreedRepository petBreedRepository)
        {
            _petBreedRepository = petBreedRepository;
        }

        public ICollection<PetBreed> GetAll()
        {
            return _petBreedRepository.GetAll();
        }


        public PetBreed GetById(int id)

        {
            return _petBreedRepository.GetById(id);
        }

    }
}
