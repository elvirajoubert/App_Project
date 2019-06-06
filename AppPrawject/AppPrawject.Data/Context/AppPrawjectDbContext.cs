using AppPrawject.Domain.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AppPrawject.Data.Context
{

    //this class will translate Models into Database tables


    // DbContext -> represent a session to a db APIs
    // to communicate with db
    public class AppPrawjectDbContext : IdentityDbContext<AppUser>
    {
        // Represents a collection (table) of a given entity/model
        // They map to tables by default
        public DbSet<Pet> Pets { get; set; }
        public DbSet<PetBreed> PetBreeds { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<ServiceType> ServiceTypes { get; set; }
        public DbSet<ServicePet> ServicePets { get; set; }

        //public DbSet<ServiceType> ServiceTypes {get; set;}

        //Virtual medthod designed to be overridden
        // You can provide configuration information for the context
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Connection string is divided in 3 elements
            //server - database - authentication 
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=appprawject;Trusted_Connection=true");
        }


        //We can manipulate Models, Add Data to tables, change default relationships
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //base = IdentityDbContext
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<PetBreed>().HasData(
                new PetBreed { Id = 1, Description = "Labrador" },
                new PetBreed { Id = 2, Description = "Chihuahua" },
                new PetBreed { Id = 3, Description = "Poodle" },
                new PetBreed { Id = 4, Description = "Beagle" },
                new PetBreed { Id = 5, Description = "Mixed Breed" },
                new PetBreed { Id = 6, Description = "Boston Terrier" },
                new PetBreed { Id = 7, Description = "Collie" },
                new PetBreed { Id = 8, Description = "French Bulldog" },
                new PetBreed { Id = 9, Description = "German Shepherd" },
                new PetBreed { Id = 10, Description = "Pug" },
                new PetBreed { Id = 11, Description = "Bulldog" },
                new PetBreed { Id = 12, Description = "Siberian Husky" },
                new PetBreed { Id = 13, Description = "Great Dane" },
                new PetBreed { Id = 14, Description = "Rottweiler" },
                new PetBreed { Id = 15, Description = "Yorkshire Terrier" },
                new PetBreed { Id = 16, Description = "Golden Retriever" },
                new PetBreed { Id = 17, Description = "Boxer" },
                new PetBreed { Id = 18, Description = "Australian Shepherd" },
                new PetBreed { Id = 19, Description = "Bichon Frise" },
                new PetBreed { Id = 20, Description = "Chow Chow" },
                new PetBreed { Id = 21, Description = "Pointer" },
                new PetBreed { Id = 22, Description = "Dachshund" },
                new PetBreed { Id = 23, Description = "Pomeranian" },
                new PetBreed { Id = 24, Description = "Pembroke Welsh Corgi" },
                new PetBreed { Id = 25, Description = "Bernese Mountain Dog" },
                new PetBreed { Id = 26, Description = "Basset Hound" },
                new PetBreed { Id = 27, Description = "Greyhound" },
                new PetBreed { Id = 28, Description = "American Staffordshire Terrier" },
                new PetBreed { Id = 29, Description = "Jack Russell Terrier" },
                new PetBreed { Id = 30, Description = "Australian Cattle Dog" },
                new PetBreed { Id = 31, Description = "Alaskan Malamute" },
                new PetBreed { Id = 32, Description = "Akita" },
                new PetBreed { Id = 33, Description = "American Foxhound" },
                new PetBreed { Id = 34, Description = "Vizsla" },
                new PetBreed { Id = 35, Description = "Scottish Terrier" },
                new PetBreed { Id = 36, Description = "Weimaraner" },
                new PetBreed { Id = 37, Description = "Doberman" },
                new PetBreed { Id = 38, Description = "Bullterrier" },
                new PetBreed { Id = 39, Description = "English Mastiff" },
                new PetBreed { Id = 40, Description = "Pitbull" }

                );



            //Adding ServicePet as a table in between Service and AppUser
            modelBuilder.Entity<ServicePet>()
                 .HasKey(s => new { s.PetId, s.ServiceId }); //Combined PK

            modelBuilder.Entity<ServicePet>() //Customer is an AppUser
                .HasOne(sp => sp.Pet)               //sp - servicepet
                .WithMany(a => a.ServicePets)
                .HasForeignKey(s => s.PetId);


            modelBuilder.Entity<ServicePet>()
                .HasOne(sp => sp.Service)
                .WithMany(s => s.ServicePets)
                .HasForeignKey(s => s.ServiceId);


            //using FluentAPI to manage Service and AppUser relationship

            modelBuilder.Entity<Service>()  //c- customer, s - service
                .HasOne(s => s.Customer)
                .WithMany(c => c.CustomerServices)
                .HasForeignKey(s => s.CustomerId);

            modelBuilder.Entity<Service>()  //p - provider
             .HasOne(s => s.Provider)
             .WithMany(p => p.ProviderServices)
             .HasForeignKey(s => s.ProviderId);



            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole { Name = "Customer", NormalizedName = "CUSTOMER" },
                new IdentityRole { Name = "Provider", NormalizedName = "PROVIDER" }
            );
        }
    }
}

