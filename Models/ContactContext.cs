using Microsoft.EntityFrameworkCore;

namespace ContactManager.Models
{
    public class ContactContext : DbContext 
    {
        public ContactContext(DbContextOptions<ContactContext>options) : base(options) { }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
            new Category { CategoryID = 1, Name = "Family" },
            new Category { CategoryID = 2, Name = "Work" },
            new Category { CategoryID = 3, Name = "Friends" }
            );

            modelBuilder.Entity<Contact>().HasData(
            new Contact { ID = 1, Firstname = "Zaros", Lastname = "Marshall", Phone = "000-000-0000", Email = "zarmar@ei.com", 
                CategoryId = 1, DateAdded = DateTime.Parse("02/21/2025") },
            new Contact { ID = 2, Firstname = "Tre", Lastname = "Marsh", Phone = "111-111-1111", Email = "tremar@eo.com", 
                CategoryId = 2, DateAdded = DateTime.Parse("02/23/2025") },
            new Contact { ID = 3, Firstname = "Rey", Lastname = "Sam", Phone = "444-444-4444", Email = "reysam@eu.com", 
                CategoryId = 3, DateAdded = DateTime.Parse("02/25/2025") },
            new Contact { ID = 4, Firstname = "Rose", Lastname = "Tyler", Phone = "555-555-5555", Email = "rostay@ea.com", 
                CategoryId = 4, DateAdded = DateTime.Parse("02/27/2025") },
            new Contact { ID = 5, Firstname = "Amy", Lastname = "Ponds", Phone = "777-777-7777", Email = "amyponds@bee.com", 
                CategoryId = 1, DateAdded = DateTime.Parse("02/21/2025") }
            );
        }
    }
}
