using AppPrawject.Domain.Model;
using System.Collections.Generic;

namespace AppPrawject.Data.Interfaces
{
    public interface IPetBreedRepository

    {
        //Read
        PetBreed GetById(int id);

        ICollection<PetBreed> GetAll();
    }
}
