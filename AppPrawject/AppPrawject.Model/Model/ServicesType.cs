using System.ComponentModel.DataAnnotations;

namespace AppPrawject.Domain.Model
{
    public class ServiceType

    {
        public int Id { get; set; }

        [Display(Name = "Please select your request")]
        public string Description { get; set; }

    }
}
