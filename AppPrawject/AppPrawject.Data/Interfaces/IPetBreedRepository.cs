using AppPrawject.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppPrawject.Data.Interfaces
{
    public interface IPetBreedRepository

    {
        //Read

        IPetBreed GetById(int id);
        ICollection<PetBreed> GetAll();
    }
}
