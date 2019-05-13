using System.ComponentModel.DataAnnotations;

namespace AppPrawject.Domain.Model
{
    public class PetBreed

    {
        public int Id { get; set; } // Primary Key (PK) in DB

        [Required] //Make sure that any entry contains description
        public string Description { get; set; }
    }
}
