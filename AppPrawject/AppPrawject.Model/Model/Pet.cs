using System.ComponentModel.DataAnnotations;
namespace AppPrawject.Domain
{
    public class Pet
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Breed { get; set; }

        [Required]
        public int Weight { get; set; }

        public string Image { get; set; }


    }
}
