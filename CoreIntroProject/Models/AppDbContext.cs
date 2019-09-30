using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreIntroProject.Models
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Item> Items { get; set; }
        public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed categories
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Snowboards" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Goggles" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Bindings" });

            //seed pies

            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 1,
                Name = "Burton Board",
                Price = 12.95M,
                ShortDescription = "Awesome Burton Board",
                LongDescription =
                    "2019 Edition - V-Rocker Burton Board.",
                CategoryId = 1,
                ImageUrl = "https://cdn.shopify.com/s/files/1/0257/8209/products/drinkwatersnowboards3_large.jpg?v=1538422318",
                InStock = true,
                IsDealOfTheWeek = true,
                ImageThumbnailUrl = "https://cdn.shopify.com/s/files/1/0257/8209/products/drinkwatersnowboards3_large.jpg?v=1538422318",
              
            });

            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 2,
                Name = "Smith Squad Goggles",
                Price = 18.95M,
                ShortDescription = "Smith Squad Snowboard Goggles",
                LongDescription =
                    "Best goggles of 2019 for wind/snow resistance, and glare reduction. ",
                CategoryId = 2,
                ImageUrl = "https://images.evo.com/imgp/700/119214/515639/smith-squad-xl-goggles-.jpg",
                InStock = true,
                IsDealOfTheWeek = false,
                ImageThumbnailUrl =
                    "https://images.evo.com/imgp/700/119214/515639/smith-squad-xl-goggles-.jpg",
               
            });

            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 3,
                Name = "Burton Bindings",
                Price = 18.95M,
                ShortDescription = "Awesome Burton Bindings",
                LongDescription =
                    "Flexible and Secure.",
                CategoryId = 2,
                ImageUrl = "https://summitsports.scene7.com/is/image/SummitSports/573741_573741_1?$600$",
                InStock = true,
                IsDealOfTheWeek = false,
                ImageThumbnailUrl = "https://summitsports.scene7.com/is/image/SummitSports/573741_573741_1?$600$",
               
            });

        }
    }
}
