using AppPrawject.Data.Context;
using AppPrawject.Data.Interfaces;
using AppPrawject.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AppPrawject.Data.Implementation.SqlServer
{
    public class SqlServerPetBreedRepository : IPetBreedRepository
    {
        public ICollection<PetBreed> GetAll()
        {
            using (var context = new AppPrawjectDbContext())
            {
                return context.PetBreeds.ToList();
            }
        }

        public PetBreed GetById(int id)
        {
            using (var context = new AppPrawjectDbContext())
            {

                var petBreed = context.PetBreeds.SingleOrDefault(pt => pt.Id == id);
                return petBreed;
            }
        }

        IPetBreed IPetBreedRepository.GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
