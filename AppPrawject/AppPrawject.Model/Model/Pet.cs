using System.ComponentModel.DataAnnotations;

namespace AppPrawject.Domain.Model
{
    public class Pet
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Don't forget to add your Pet's name")]

        public string Name { get; set; }

        [Required]
        public string Breed { get; set; }

        [Required]
        public int Weight { get; set; }

        public string Image { get; set; }

        // Fully Defined Relationship
        public int PetBreedId { get; set; }
        public PetBreed PetBreed { get; set; }





    }
}
