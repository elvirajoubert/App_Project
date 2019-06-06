using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AppPrawject.Model
{
    public class RegisterViewModel

    {
        [EmailAddress, Required]
        public string Email { get; set; }

        [DataType(DataType.Password), Required]
        public string Password { get; set; }

        [DataType(DataType.Password), Required]
        [Compare("Password", ErrorMessage = "Password does not match. Try again.")]
        public string ConfirmPassword { get; set; }

        [Required]
        public string Role { get; set; }

        public List<IdentityRole> Roles { get; set; }
    }
}
