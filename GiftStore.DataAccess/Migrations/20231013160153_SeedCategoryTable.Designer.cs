﻿// <auto-generated />
using GiftStoreApplication.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GiftStoreApplication.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231013160153_SeedCategoryTable")]
    partial class SeedCategoryTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GiftStoreApplication.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Birthday Gifts",
                            DisplayOrder = 1
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Christmas Gifts",
                            DisplayOrder = 2
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Valentine Gifts",
                            DisplayOrder = 3
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "Anniversary Gifts",
                            DisplayOrder = 4
                        },
                        new
                        {
                            CategoryId = 5,
                            CategoryName = "Graduation Gifts",
                            DisplayOrder = 5
                        },
                        new
                        {
                            CategoryId = 6,
                            CategoryName = "Awrudu Gifts",
                            DisplayOrder = 6
                        },
                        new
                        {
                            CategoryId = 7,
                            CategoryName = "Special Gifts",
                            DisplayOrder = 7
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
