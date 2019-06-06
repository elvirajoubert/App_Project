namespace AppPrawject.Domain.Model
{
    public class ServicePet

    {
        public Pet Pet { get; set; }
        public int PetId { get; set; }

        //public services
        public Service Service { get; set; }
        public int ServiceId { get; set; }
    }
}
