using Amaral.Models;
using Microsoft.EntityFrameworkCore;

namespace Amaral.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
               new Category { Id = 1, Name = "Action", Description = "Books full of excitement and adventure." },
               new Category { Id = 2, Name = "SciFi", Description = "Science fiction books exploring futuristic concepts." },
               new Category { Id = 3, Name = "History", Description = "Books delving into historical events and figures." },
               new Category { Id = 4, Name = "Adventure", Description = "Stories involving exciting and risky experiences." },
               new Category { Id = 5, Name = "Fantasy", Description = "Works featuring magical or supernatural elements, often set in imaginary worlds." },
               new Category { Id = 6, Name = "Thriller", Description = "Stories designed to provoke excitement and suspense." },
               new Category { Id = 7, Name = "Horror", Description = "Fiction intended to scare, unsettle, or horrify the reader." },
               new Category { Id = 8, Name = "Romance", Description = "Focuses on romantic relationships between characters." },
               new Category { Id = 9, Name = "Biography", Description = "A detailed description of a person's life." },
               new Category { Id = 10, Name = "Comedy", Description = "Light-hearted stories designed to amuse and entertain." }
               );
        }
    }
}
