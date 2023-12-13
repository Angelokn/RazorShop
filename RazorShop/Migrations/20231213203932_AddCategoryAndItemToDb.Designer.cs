﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RazorShop.Data;

#nullable disable

namespace RazorShop.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231213203932_AddCategoryAndItemToDb")]
    partial class AddCategoryAndItemToDb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RazorShop.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DisplayOrder = 1,
                            Name = "Fruits and Vegetables"
                        },
                        new
                        {
                            Id = 2,
                            DisplayOrder = 2,
                            Name = "Meats and Dairies"
                        },
                        new
                        {
                            Id = 3,
                            DisplayOrder = 3,
                            Name = "Beverage"
                        },
                        new
                        {
                            Id = 4,
                            DisplayOrder = 4,
                            Name = "Cleaning Products"
                        },
                        new
                        {
                            Id = 5,
                            DisplayOrder = 5,
                            Name = "Toiletries"
                        },
                        new
                        {
                            Id = 6,
                            DisplayOrder = 6,
                            Name = "Frozen Food"
                        },
                        new
                        {
                            Id = 7,
                            DisplayOrder = 7,
                            Name = "Pets"
                        },
                        new
                        {
                            Id = 8,
                            DisplayOrder = 8,
                            Name = "Electronics"
                        },
                        new
                        {
                            Id = 9,
                            DisplayOrder = 9,
                            Name = "Toys"
                        },
                        new
                        {
                            Id = 10,
                            DisplayOrder = 10,
                            Name = "Vegan"
                        });
                });

            modelBuilder.Entity("RazorShop.Models.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("RazorShop.Models.Item", b =>
                {
                    b.HasOne("RazorShop.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
