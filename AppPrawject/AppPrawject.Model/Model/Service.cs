using System;
using System.Collections.Generic;

namespace AppPrawject.Domain.Model
{
    public class Service

    {
        public int Id { get; set; }
        public DateTime Date { get; set; }


        //Relationship b/n AppUser and Service
        public string CustomerId { get; set; }
        public AppUser Customer { get; set; }


        public string ProviderId { get; set; }
        public AppUser Provider { get; set; }


        //Relationship b/n  Pet and Service
        public ServiceType ServiceType { get; set; }
        public string ServiceTypeId { get; set; }

        public ICollection<ServicePet> ServicePets { get; set; }

    }
}
