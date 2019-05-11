using AppPrawject.Domain.Model;
using System.Collections.Generic;

namespace AppPrawject.Data.Interfaces
{
    public interface IPetBreedRepository

    {
        //Read
        IPetBreed GetById(int id);

        ICollection<PetBreed> GetAll();
    }
}
