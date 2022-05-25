﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SalihRecipes.data.Concrete.EfCore;

namespace SalihRecipes.data.Migrations
{
    [DbContext(typeof(SalihRecipesContext))]
    [Migration("20220518082226_Mig2")]
    partial class Mig2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                });

            modelBuilder.Entity("SalihRecipes.entity.Food", b =>
                {
                    b.Property<int>("FoodId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("FoodDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("FoodDescription")
                        .HasColumnType("TEXT");

                    b.Property<string>("FoodImage")
                        .HasColumnType("TEXT");

                    b.Property<string>("FoodMaterial")
                        .HasColumnType("TEXT");

                    b.Property<string>("FoodName")
                        .HasColumnType("TEXT");

                    b.Property<double?>("FoodPrice")
                        .HasColumnType("REAL");

                    b.Property<bool>("IsApproved")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsHome")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Url")
                        .HasColumnType("TEXT");

                    b.HasKey("FoodId");

                    b.ToTable("Foods");
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
