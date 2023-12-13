using Microsoft.EntityFrameworkCore;
using RazorShop.Models;
using System.ComponentModel;

namespace RazorShop.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Item> Items { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Fruits and Vegetables", DisplayOrder = 1},
                new Category { Id = 2, Name = "Meats and Dairies", DisplayOrder  = 2},
                new Category { Id = 3, Name = "Beverage", DisplayOrder = 3 },
                new Category { Id = 4, Name = "Cleaning Products", DisplayOrder = 4 },
                new Category { Id = 5, Name = "Toiletries", DisplayOrder = 5 },
                new Category { Id = 6, Name = "Frozen Food", DisplayOrder = 6 },
                new Category { Id = 7, Name = "Cold cuts and Sausages", DisplayOrder = 7 },
                new Category { Id = 8, Name = "Eletronics", DisplayOrder = 8 },
                new Category { Id = 9, Name = "Toys", DisplayOrder = 9 },
                new Category { Id = 10, Name = "Vegan", DisplayOrder = 10 }
                );

            //modelBuilder.Entity<Item>().HasData(
            //    new Item { Id = 1, Name = "Apple", Description = "", Category = "", Quantity = 30, Price = 2 },
            //    new Item { Id = 1, Name = "Apple", Description = "", Category = "", Quantity = 30, Price = 2 },
            //    new Item { Id = 1, Name = "Apple", Description = "", Category = "", Quantity = 30, Price = 2 },
            //    new Item { Id = 1, Name = "Apple", Description = "", Category = "", Quantity = 30, Price = 2 },
            //    new Item { Id = 1, Name = "Apple", Description = "", Category = "", Quantity = 30, Price = 2 },
            //    );
        }
    }
}
