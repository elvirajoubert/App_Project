using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AppPrawject.Domain.Model
{
    public class Pet
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Don't forget to add your Pet's name")]

        public string Name { get; set; }

        [Required]
        public int Weight { get; set; }

        public string Image { get; set; }


        // Fully Defined Relationship for PetBreed

        [Display(Name = "Pet Breed")]
        public int PetBreedId { get; set; }
        public PetBreed PetBreed { get; set; }

        //Fully Defined Relationship for AppUser
        public string AppUserId { get; set; }
        public AppUser Provider { get; set; }

        public ICollection<Service> ServiceType { get; set; }

        public ICollection<ServicePet> ServicePets { get; set; }

    }
}
