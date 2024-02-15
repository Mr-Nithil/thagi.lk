using GiftStoreApplication.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace GiftStoreApplication.Data
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
                new Category { CategoryId = 1, CategoryName = "Birthday Gifts", DisplayOrder = 1 },
                new Category { CategoryId = 2, CategoryName = "Christmas Gifts", DisplayOrder = 2 },
                new Category { CategoryId = 3, CategoryName = "Valentine Gifts", DisplayOrder = 3 },
                new Category { CategoryId = 4, CategoryName = "Anniversary Gifts", DisplayOrder = 4 },
                new Category { CategoryId = 5, CategoryName = "Graduation Gifts", DisplayOrder = 5 },
                new Category { CategoryId = 6, CategoryName = "Awrudu Gifts", DisplayOrder = 6 },
                new Category { CategoryId = 7, CategoryName = "Special Gifts", DisplayOrder = 7 }
                );
        }

    }
}
