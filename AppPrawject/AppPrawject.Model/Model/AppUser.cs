﻿using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace AppPrawject.Domain.Model
{
    public class AppUser : IdentityUser

    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public ICollection<Service> CustomerServices { get; set; }
        public ICollection<Service> ProviderServices { get; set; }
    }
}
