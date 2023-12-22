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
                new Category { Id = 7, Name = "Pets", DisplayOrder = 7 },
                new Category { Id = 8, Name = "Electronics", DisplayOrder = 8 },
                new Category { Id = 9, Name = "Toys", DisplayOrder = 9 },
                new Category { Id = 10, Name = "Vegan", DisplayOrder = 10 }
                );

            modelBuilder.Entity<Item>().HasData(
                new Item 
                { 
                    Id = 1,
                    Name = "Apple",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean at.",
                    CategoryId = 1,
                    Quantity = 30,
                    Price = 2
                },
                new Item
                {
                    Id = 2,
                    Name = "Banana (bunch)",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean at.",
                    CategoryId = 1,
                    Quantity = 15,
                    Price = 7
                },
                new Item
                {
                    Id = 3,
                    Name = "Ground beef - 1kg",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean at.",
                    CategoryId = 2,
                    Quantity = 10,
                    Price = 30
                },
                new Item
                {
                    Id = 4,
                    Name = "Detergent",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean at.",
                    CategoryId = 4,
                    Quantity = 30,
                    Price = 1.9
                },
                new Item
                {
                    Id = 5,
                    Name = "Coke soda - 350ml",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean at.",
                    CategoryId = 3,
                    Quantity = 60,
                    Price = 4.5
                },
                new Item
                {
                    Id = 6,
                    Name = "Toy car",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean at.",
                    CategoryId = 9,
                    Quantity = 10,
                    Price = 29.9
                }
                );
        }
    }
}
