using AppPrawject.Data.Context;
using AppPrawject.Data.Interfaces;
using AppPrawject.Domain.Models;
using System;
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
                var pet = context.Pets.Single(p => p.Id == id);
                return pet;
            }
        }
        public Pet Create(Pet newPet)
        {
            throw new NotImplementedException();
        }

        public Pet Update(Pet updatedPet)
        {
            throw new NotImplementedException();
        }
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }




    }
}
