using GiftStoreApplication.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace GiftStoreApplication.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Birthday Gifts", DisplayOrder = 1 },
                new Category { CategoryId = 2, CategoryName = "Christmas Gifts", DisplayOrder = 2 },
                new Category { CategoryId = 3, CategoryName = "Valentine Gifts", DisplayOrder = 3 },
                new Category { CategoryId = 4, CategoryName = "Anniversary Gifts", DisplayOrder = 4 },
                new Category { CategoryId = 5, CategoryName = "Graduation Gifts", DisplayOrder = 5 },
                new Category { CategoryId = 6, CategoryName = "New Year Gifts", DisplayOrder = 6 },
                new Category { CategoryId = 7, CategoryName = "Special Gifts", DisplayOrder = 7 }
                );

            modelBuilder.Entity<Product>().HasData(
                new Product { 
                    ProductId = 1, 
                    ProductName = "Elegant Crystal Vase", 
                    ProductDescription = "Add a touch of timeless elegance to your home decor with our Elegant Crystal Vase. This exquisite piece features intricate craftsmanship and a classic design that complements any room. Whether you want to display fresh flowers or use it as a stunning centerpiece, this vase is a must-have.", 
                    Price = 1999, 
                    DiscountPrice = 1799,
                    CategoryId = 3,
                    ImageUrl = ""
                },
                new Product
                {
                    ProductId = 2,
                    ProductName = "Birthday Surprise Gift Box",
                    ProductDescription = "Celebrate a special birthday with our Birthday Surprise Gift Box. This carefully curated box includes a personalized card, a delicious birthday cake, and a selection of colorful balloons to make the day extra special.",
                    Price = 2499,
                    DiscountPrice = 2199,
                    CategoryId = 1,
                    ImageUrl = ""
                },
                new Product
                {
                    ProductId = 3,
                    ProductName = "Personalized Love Message Bracelet",
                    ProductDescription = "Express your love with our Personalized Love Message Bracelet. Engrave your special message on this elegant bracelet, making it a heartfelt and cherished gift for Valentine's Day.",
                    Price = 1199,
                    DiscountPrice = 999,
                    CategoryId = 3,
                    ImageUrl = ""
                },
                new Product
                {
                    ProductId = 4,
                    ProductName = "Personalized Anniversary Photo Frame",
                    ProductDescription = "Commemorate your years of love with our Personalized Anniversary Photo Frame. This beautiful frame allows you to showcase your cherished memories together and can be customized with your names and anniversary date.",
                    Price = 799,
                    DiscountPrice = 699,
                    CategoryId = 4,
                    ImageUrl = ""
                },
                new Product
                {
                    ProductId = 5,
                    ProductName = "Professional Leather Portfolio",
                    ProductDescription = "Prepare the graduate for their career with our Professional Leather Portfolio. It's designed to hold resumes, documents, and a tablet, making it an essential tool for job interviews and meetings.",
                    Price = 1499,
                    DiscountPrice = 1299,
                    CategoryId = 5,
                    ImageUrl = ""
                },
                new Product
                {
                    ProductId = 6,
                    ProductName = "Personalized New Year Calendar",
                    ProductDescription = "Start the year organized with our Personalized New Year Calendar. This wall calendar can be customized with your family's name and important dates. It's a practical and thoughtful way to kick off the new year.",
                    Price = 699,
                    DiscountPrice = 599,
                    CategoryId = 6,
                    ImageUrl = ""
                },
                new Product
                {
                    ProductId = 7,
                    ProductName = "Personalized Birthday Candle Set",
                    ProductDescription = "Light up the birthday celebration with our Personalized Birthday Candle Set. This set includes beautifully designed candles that can be customized with the birthday person's name. It's a unique and memorable addition to any birthday cake.",
                    Price = 799,
                    DiscountPrice = 699,
                    CategoryId = 1,
                    ImageUrl = ""
                },
                new Product
                {
                    ProductId = 8,
                    ProductName = "Graduation Keepsake Box",
                    ProductDescription = "Celebrate academic achievements with our Graduation Keepsake Box. This box is perfect for storing diplomas, photos, and mementos from the educational journey. It's a thoughtful gift for the recent graduate.",
                    Price = 1299,
                    DiscountPrice = 1099,
                    CategoryId = 5,
                    ImageUrl = ""
                },
                new Product
                {
                    ProductId = 9,
                    ProductName = "Christmas Gift Basket",
                    ProductDescription = "Spread holiday cheer with our Christmas Gift Basket. Packed with a selection of gourmet treats, chocolates, and a beautifully scented candle, this basket makes a delightful gift for friends and family during the festive season.",
                    Price = 1499,
                    DiscountPrice = 1399,
                    CategoryId = 2,
                    ImageUrl = ""
                },
                new Product
                {
                    ProductId = 10,
                    ProductName = "New Year's Eve Party Kit",
                    ProductDescription = "Ring in the New Year with our New Year's Eve Party Kit. This kit includes a variety of party essentials, such as party hats, noisemakers, confetti poppers, and sparkling cider, making it the perfect package to celebrate the arrival of the new year with friends and family.",
                    Price = 1899,
                    DiscountPrice = 1799,
                    CategoryId = 6,
                    ImageUrl = ""
                },
                new Product
                {
                    ProductId = 11,
                    ProductName = "Love in a Jar",
                    ProductDescription = "Express your love with our \"Love in a Jar\" gift. This unique and heartfelt present contains a collection of handwritten love notes, each with a special message or memory. Your partner can read one note each day, keeping the romance alive throughout the year.",
                    Price = 599,
                    DiscountPrice = 499,
                    CategoryId = 3,
                    ImageUrl = ""
                },
                new Product
                {
                    ProductId = 12,
                    ProductName = "Festive Christmas Wreath",
                    ProductDescription = "Welcome the holiday season with our Festive Christmas Wreath. This beautifully crafted wreath is adorned with ornaments, ribbons, and evergreen branches, adding a touch of elegance to your front door.",
                    Price = 1999,
                    DiscountPrice = 1799,
                    CategoryId = 2,
                    ImageUrl = ""
                }
                );
        }

    }
}
