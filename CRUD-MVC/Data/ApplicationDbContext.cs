using CRUD_MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD_MVC.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Coca Cola", Price = 2 },
                new Category { Id = 2, Name = "Inka Cola", Price = 1 },
                new Category { Id = 3, Name = "Fanta", Price = 2 },
                new Category { Id = 4, Name = "Sprite", Price = 3 },
                new Category { Id = 5, Name = "Coca", Price = 4 }

                );
        }
    }
}
