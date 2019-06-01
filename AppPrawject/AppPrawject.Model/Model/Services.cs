using System;

namespace AppPrawject.Domain.Model
{
    public class Services

    {
        public int Id { get; set; }
        public string ServiceType { get; set; }
        public DateTime Date { get; set; }


        //Relationship b/n AppUser and Service
        public string UserId { get; set; }
        public AppUser User { get; set; }

        //Relationship b/n  Pet and Service

        public int PetBreedId { get; set; }
        public Pet Pet { get; set; }
    }
}
