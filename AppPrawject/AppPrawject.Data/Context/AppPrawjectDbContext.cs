using AppPrawject.Domain.Model;
using AppPrawject.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace AppPrawject.Data.Context
{

    //this class will translate Models into Database tables


    // DbContext -> represent a session to a db APIs
    // to communicate with db
    public class AppPrawjectDbContext : DbContext
    {
        // Represents a collection (table) of a given entity/model
        // They map to tables by default
        public DbSet<Pet> Pets { get; set; }
        public DbSet<PetBreed> PetBreeds { get; set; }

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
            modelBuilder.Entity<PetBreed>().HasData(
                new PetBreed { Id = 1, Description = "Labrador" },
                new PetBreed { Id = 2, Description = "Chihuahua" },
                new PetBreed { Id = 3, Description = "Poodle" },
                new PetBreed { Id = 4, Description = "Beagle" },
                new PetBreed { Id = 5, Description = "Mixed Breed" },
                new PetBreed { Id = 6, Description = "Boston Terrier" }
                );
        }


    }
}

