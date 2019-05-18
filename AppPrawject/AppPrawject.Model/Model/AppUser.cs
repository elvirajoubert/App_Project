using Microsoft.AspNetCore.Identity;

namespace AppPrawject.Domain.Model
{
    public class AppUser : IdentityUser

    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
