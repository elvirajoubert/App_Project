using System.ComponentModel.DataAnnotations;

namespace AppPrawject.WebUI.Models
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
    }
}
