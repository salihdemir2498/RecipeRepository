﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SalihRecipes.data.Concrete.EfCore;

namespace SalihRecipes.data.Migrations
{
    [DbContext(typeof(SalihRecipesContext))]
    partial class SalihRecipesContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.16");

            modelBuilder.Entity("SalihRecipes.entity.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryImage")
                        .HasColumnType("TEXT");

                    b.Property<string>("CategoryName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryImage = "unlumamuller.jpg",
                            CategoryName = "Unlu Mamüller",
                            Url = "unlu-mamuller"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryImage = "corbalar.jpg",
                            CategoryName = "Çorbalar",
                            Url = "corba"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryImage = "tatlilar.jpg",
                            CategoryName = "Tatlılar",
                            Url = "tatlilar"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryImage = "Etliyemekler.jpg",
                            CategoryName = "Etli Yemekler",
                            Url = "etli-yemekler"
                        },
                        new
                        {
                            CategoryId = 5,
                            CategoryImage = "balık-yemek-kategori.jpg",
                            CategoryName = "Balık Yemekleri",
                            Url = "balik-yemekleri"
                        },
                        new
                        {
                            CategoryId = 6,
                            CategoryImage = "asya-yemekleri.jpg",
                            CategoryName = "Asya Yemekleri",
                            Url = "asya-yemekleri"
                        });
                });

            modelBuilder.Entity("SalihRecipes.entity.Contact", b =>
                {
                    b.Property<int>("ContactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ContactDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("ContactMail")
                        .HasColumnType("TEXT");

                    b.Property<string>("ContactMessage")
                        .HasColumnType("TEXT");

                    b.Property<bool>("ContactStatus")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ContactSubject")
                        .HasColumnType("TEXT");

                    b.Property<string>("ContactUserName")
                        .HasColumnType("TEXT");

                    b.HasKey("ContactId");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("SalihRecipes.entity.Food", b =>
                {
                    b.Property<int>("FoodId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateAdded")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValueSql("date('now')");

                    b.Property<string>("FoodImage")
                        .HasColumnType("TEXT");

                    b.Property<string>("FoodMaterial")
                        .HasColumnType("TEXT");

                    b.Property<string>("FoodName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<double?>("FoodPrice")
                        .HasColumnType("REAL");

                    b.Property<string>("FoodRecipe")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsApproved")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsHome")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsSlider")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Url")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.HasKey("FoodId");

                    b.ToTable("Foods");

                    b.HasData(
                        new
                        {
                            FoodId = 1,
                            DateAdded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FoodImage = "zeytinli_pogaca-slider.jpg",
                            FoodMaterial = "a,b,c",
                            FoodName = "Zeytinli Poğaca",
                            FoodPrice = 7.0,
                            FoodRecipe = "zeytin,hamur",
                            IsApproved = true,
                            IsHome = true,
                            IsSlider = true,
                            Url = "zeytinli-pogaca"
                        },
                        new
                        {
                            FoodId = 2,
                            DateAdded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FoodImage = "ezogelin-corbasi-tarifi.jpg",
                            FoodMaterial = "ezogelinnnnnnnn",
                            FoodName = "Ezogelin Çorbası",
                            FoodPrice = 20.0,
                            FoodRecipe = "ezogelin corbası",
                            IsApproved = true,
                            IsHome = true,
                            IsSlider = true,
                            Url = "ezogelin-corbasi"
                        },
                        new
                        {
                            FoodId = 3,
                            DateAdded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FoodImage = "mercimek_corba.jpg",
                            FoodMaterial = "mercimejjjjj",
                            FoodName = "Mercimek Çorbası",
                            FoodPrice = 12.0,
                            FoodRecipe = "mercimekkkk",
                            IsApproved = true,
                            IsHome = false,
                            IsSlider = false,
                            Url = "mercimek-corbasi"
                        },
                        new
                        {
                            FoodId = 4,
                            DateAdded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FoodImage = "kuru-baklava.jpeg",
                            FoodMaterial = "baklavassdas",
                            FoodName = "Kuru Baklava",
                            FoodPrice = 21.0,
                            FoodRecipe = "baklavaaa",
                            IsApproved = true,
                            IsHome = true,
                            IsSlider = true,
                            Url = "kuru-baklava"
                        },
                        new
                        {
                            FoodId = 5,
                            DateAdded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FoodImage = "kasarlipogaca.jpg",
                            FoodMaterial = "kaşarrrrr",
                            FoodName = "Kaşarlı Poğaça",
                            FoodPrice = 5.0,
                            FoodRecipe = "kaşarlıııı",
                            IsApproved = true,
                            IsHome = true,
                            IsSlider = false,
                            Url = "kasarli-pogaca"
                        },
                        new
                        {
                            FoodId = 6,
                            DateAdded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FoodImage = "mantar-corba.jpg",
                            FoodMaterial = "mantarrrrr",
                            FoodName = "Mantar Çorbası",
                            FoodPrice = 10.0,
                            FoodRecipe = "mantarrrrrrr",
                            IsApproved = true,
                            IsHome = false,
                            IsSlider = false,
                            Url = "mantar-corbasi"
                        },
                        new
                        {
                            FoodId = 7,
                            DateAdded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FoodImage = "cag-kebabi.jpg",
                            FoodMaterial = "et,domates,sebze",
                            FoodName = "Cağ Kebabı",
                            FoodPrice = 46.0,
                            FoodRecipe = "cag kebabı",
                            IsApproved = true,
                            IsHome = false,
                            IsSlider = false,
                            Url = "cag-kebabi"
                        },
                        new
                        {
                            FoodId = 8,
                            DateAdded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FoodImage = "uskumru-pilaki.jpeg",
                            FoodMaterial = "uskumruuuu",
                            FoodName = "Uskumru Pilaki",
                            FoodPrice = 47.0,
                            FoodRecipe = "uskumru pilaki",
                            IsApproved = true,
                            IsHome = false,
                            IsSlider = false,
                            Url = "uskumru-pilaki"
                        },
                        new
                        {
                            FoodId = 9,
                            DateAdded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FoodImage = "firinda-cinekop.jpg",
                            FoodMaterial = "çinekopp",
                            FoodName = "Fırında Çinekop",
                            FoodPrice = 36.0,
                            FoodRecipe = "fırınada çinekop",
                            IsApproved = true,
                            IsHome = false,
                            IsSlider = false,
                            Url = "firinda-cinekop"
                        },
                        new
                        {
                            FoodId = 10,
                            DateAdded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FoodImage = "sütlac.jpg",
                            FoodMaterial = "a,b,c",
                            FoodName = "Sütlaç",
                            FoodPrice = 21.0,
                            FoodRecipe = "sütlacccsç",
                            IsApproved = true,
                            IsHome = false,
                            IsSlider = false,
                            Url = "sütlac"
                        });
                });

            modelBuilder.Entity("SalihRecipes.entity.FoodCategory", b =>
                {
                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("FoodId")
                        .HasColumnType("INTEGER");

                    b.HasKey("CategoryId", "FoodId");

                    b.HasIndex("FoodId");

                    b.ToTable("FoodCategories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            FoodId = 1
                        },
                        new
                        {
                            CategoryId = 2,
                            FoodId = 2
                        },
                        new
                        {
                            CategoryId = 2,
                            FoodId = 3
                        },
                        new
                        {
                            CategoryId = 3,
                            FoodId = 4
                        },
                        new
                        {
                            CategoryId = 1,
                            FoodId = 5
                        },
                        new
                        {
                            CategoryId = 2,
                            FoodId = 6
                        },
                        new
                        {
                            CategoryId = 4,
                            FoodId = 7
                        },
                        new
                        {
                            CategoryId = 5,
                            FoodId = 8
                        },
                        new
                        {
                            CategoryId = 5,
                            FoodId = 9
                        },
                        new
                        {
                            CategoryId = 3,
                            FoodId = 10
                        });
                });

            modelBuilder.Entity("SalihRecipes.entity.FoodCategory", b =>
                {
                    b.HasOne("SalihRecipes.entity.Category", "Category")
                        .WithMany("FoodCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SalihRecipes.entity.Food", "Food")
                        .WithMany("FoodCategories")
                        .HasForeignKey("FoodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Food");
                });

            modelBuilder.Entity("SalihRecipes.entity.Category", b =>
                {
                    b.Navigation("FoodCategories");
                });

            modelBuilder.Entity("SalihRecipes.entity.Food", b =>
                {
                    b.Navigation("FoodCategories");
                });
#pragma warning restore 612, 618
        }
    }
}
