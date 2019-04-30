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
        DbSet<Pet> Pets { get; set; }

        //Virtual medthod designed to be overridden
        // You can provide configuration information for the context
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Connection string is divided in 3 elements
            //server - database - authentication 
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=appprawject;Trusted_Connection=true");
        }
    }
}

