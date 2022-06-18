using Microsoft.EntityFrameworkCore;
using SalihRecipes.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalihRecipes.data.Configurations
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder builder)
        {
            builder.Entity<Food>().HasData(

           new Food() { FoodId = 1, FoodName = "Zeytinli Poğaca", FoodImage = "zeytinli_pogaca-slider.jpg", FoodPrice = 7, IsApproved = true, IsHome = true, IsSlider = true, FoodRecipe = "zeytin,hamur", FoodMaterial = "a,b,c", Url = "zeytinli-pogaca" },
          new Food() { FoodId = 2, FoodName = "Ezogelin Çorbası", FoodImage = "ezogelin-corbasi-tarifi.jpg", FoodPrice = 20, IsApproved = true, IsHome = true, IsSlider = true, FoodRecipe = "ezogelin corbası", FoodMaterial = "ezogelinnnnnnnn", Url = "ezogelin-corbasi" },
          new Food() { FoodId = 3, FoodName = "Mercimek Çorbası", FoodImage = "mercimek_corba.jpg", FoodPrice = 12, IsApproved = true, IsHome = false, IsSlider = false, FoodRecipe = "mercimekkkk", FoodMaterial = "mercimejjjjj", Url = "mercimek-corbasi" },
          new Food() { FoodId = 4, FoodName = "Kuru Baklava", FoodImage = "kuru-baklava.jpeg", FoodPrice = 21, IsApproved = true, IsHome = true, IsSlider = true, FoodRecipe = "baklavaaa", FoodMaterial = "baklavassdas", Url = "kuru-baklava" },
          new Food() { FoodId = 5, FoodName = "Kaşarlı Poğaça", FoodImage = "kasarlipogaca.jpg", FoodPrice = 5, IsApproved = true, IsHome = true, IsSlider = false, FoodRecipe = "kaşarlıııı", FoodMaterial = "kaşarrrrr", Url = "kasarli-pogaca" },
          new Food() { FoodId = 6, FoodName = "Mantar Çorbası", FoodImage = "mantar-corba.jpg", FoodPrice = 10, IsApproved = true, IsHome = false, IsSlider = false, FoodRecipe = "mantarrrrrrr", FoodMaterial = "mantarrrrr", Url = "mantar-corbasi" },
          new Food() { FoodId = 7, FoodName = "Cağ Kebabı", FoodImage = "cag-kebabi.jpg", FoodPrice = 46, IsApproved = true, IsHome = false, IsSlider = false, FoodRecipe = "cag kebabı", FoodMaterial = "et,domates,sebze", Url = "cag-kebabi" },
          new Food() { FoodId = 8, FoodName = "Uskumru Pilaki", FoodImage = "uskumru-pilaki.jpeg", FoodPrice = 47, IsApproved = true, IsHome = false, IsSlider = false, FoodRecipe = "uskumru pilaki", FoodMaterial = "uskumruuuu", Url = "uskumru-pilaki" },
          new Food() { FoodId = 9, FoodName = "Fırında Çinekop", FoodImage = "firinda-cinekop.jpg", FoodPrice = 36, IsApproved = true, IsHome = false, IsSlider = false, FoodRecipe = "fırınada çinekop", FoodMaterial = "çinekopp", Url = "firinda-cinekop" },
          new Food() { FoodId = 10, FoodName = "Sütlaç", FoodImage = "sütlac.jpg", FoodPrice = 21, IsApproved = true, IsHome = false, IsSlider = false, FoodRecipe = "sütlacccsç", FoodMaterial = "a,b,c", Url = "sütlac" }

               );

            builder.Entity<Category>().HasData(
                new Category() { CategoryId = 1, CategoryName = "Unlu Mamüller", CategoryImage = "unlumamuller.jpg", Url = "unlu-mamuller" },
                new Category() { CategoryId = 2, CategoryName = "Çorbalar", CategoryImage = "corbalar.jpg", Url = "corba" },
                new Category() { CategoryId = 3, CategoryName = "Tatlılar", CategoryImage = "tatlilar.jpg", Url = "tatlilar" },
                new Category() { CategoryId = 4, CategoryName = "Etli Yemekler", CategoryImage = "Etliyemekler.jpg", Url = "etli-yemekler" },
                new Category() { CategoryId = 5, CategoryName = "Balık Yemekleri", CategoryImage = "balık-yemek-kategori.jpg", Url = "balik-yemekleri" },
                new Category() { CategoryId = 6, CategoryName = "Asya Yemekleri", CategoryImage = "asya-yemekleri.jpg", Url = "asya-yemekleri" }
                );

            builder.Entity<FoodCategory>().HasData(
                  new FoodCategory() { FoodId = 1, CategoryId = 1 },
                  new FoodCategory() { FoodId = 2, CategoryId = 2 },
                  new FoodCategory() { FoodId = 3, CategoryId = 2 },
                  new FoodCategory() { FoodId = 4, CategoryId = 3 },
                  new FoodCategory() { FoodId = 5, CategoryId = 1 },
                  new FoodCategory() { FoodId = 6, CategoryId = 2 },
                  new FoodCategory() { FoodId = 7, CategoryId = 4 },
                  new FoodCategory() { FoodId = 8, CategoryId = 5 },
                  new FoodCategory() { FoodId = 9, CategoryId = 5 },
                  new FoodCategory() { FoodId = 10, CategoryId = 3 }

              );
        }
    }
}
