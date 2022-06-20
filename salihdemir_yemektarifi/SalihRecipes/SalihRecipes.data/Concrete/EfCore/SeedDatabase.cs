using Microsoft.EntityFrameworkCore;
using SalihRecipes.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalihRecipes.data.Concrete.EfCore
{
    public static class SeedDatabase
    {
        public static void Seed()
        {
            //var context = new SalihRecipesContext();
            //if (context.Database.GetPendingMigrations().Count() == 0)
            //{
            //    if (context.Categories.Count() == 0)
            //    {
            //        context.Categories.AddRange();
            //    }

            //    if (context.Foods.Count() == 0)
            //    {
            //        context.Foods.AddRange();
            //    }

            //    if (context.FoodCategories.Count() == 0)
            //    {
            //        context.FoodCategories.AddRange();
            //    }
            //}
            //context.SaveChanges();
        }

        private static Category[] Categories ={
            new Category(){CategoryName="Unlu Mamüller",CategoryImage="unlumamuller.jpg",Url="unlu-mamuller"},
            new Category(){CategoryName="Çorbalar",CategoryImage="corbalar.jpg",Url="corba"},
            new Category(){CategoryName="Tatlılar",CategoryImage="tatlilar.jpg",Url="tatlilar"},
            new Category(){CategoryName="Etli Yemekler",CategoryImage="Etliyemekler.jpg",Url="etli-yemekler"},
            new Category(){CategoryName="Balık Yemekleri",CategoryImage="balık-yemek-kategori.jpg",Url="balik-yemekleri"},
            new Category(){CategoryName="Asya Yemekleri",CategoryImage="asya-yemekleri.jpg",Url="asya-yemekleri"},
        };

        private static Food[] Foods ={
           new Food(){FoodName="Zeytinli Poğaca",FoodImage="zeytinli_pogaca-slider.jpg",FoodPrice=7,IsApproved=true,IsHome=true,IsSlider=true,FoodRecipe="zeytin,hamur",FoodMaterial="a,b,c"},
           new Food(){FoodName="Ezogelin Çorbası",FoodImage="ezogelin-corbasi-tarifi.jpg",FoodPrice=20,IsApproved=true,IsHome=true,IsSlider=true,FoodRecipe="ezogelin corbası",FoodMaterial="ezogelinnnnnnnn"},
           new Food(){FoodName="Mercimek Çorbası",FoodImage="mercimek_corba.jpg",FoodPrice=12,IsApproved=true,IsHome=false,IsSlider=false,FoodRecipe="mercimekkkk",FoodMaterial="mercimejjjjj"},
           new Food(){FoodName="Kuru Baklava",FoodImage="kuru-baklava.jpeg",FoodPrice=21,IsApproved=true,IsHome=true,IsSlider=true,FoodRecipe="baklavaaa",FoodMaterial="baklavassdas"},
           new Food(){FoodName="Kaşarlı Poğaça",FoodImage="kasarlipogaca.jpg",FoodPrice=5,IsApproved=true,IsHome=true,IsSlider=false,FoodRecipe="kaşarlıııı",FoodMaterial="kaşarrrrr"},
           new Food(){FoodName="Mantar Çorbası",FoodImage="mantar-corba.jpg",FoodPrice=10,IsApproved=true,IsHome=false,IsSlider=false,FoodRecipe="mantarrrrrrr",FoodMaterial="mantarrrrr"},
           new Food(){FoodName="Cağ Kebabı",FoodImage="cag-kebabi.jpg",FoodPrice=46,IsApproved=true,IsHome=false,IsSlider=false,FoodRecipe="cag kebabı",FoodMaterial="et,domates,sebze"},
           new Food(){FoodName="Uskumru Pilaki",FoodImage="uskumru-pilaki.jpeg",FoodPrice=47,IsApproved=true,IsHome=false,IsSlider=false,FoodRecipe="uskumru pilaki",FoodMaterial="uskumruuuu"},
           new Food(){FoodName="Fırında Çinekop",FoodImage="firinda-cinekop.jpg",FoodPrice=36,IsApproved=true,IsHome=false,IsSlider=false,FoodRecipe="fırınada çinekop",FoodMaterial="çinekopp"},
           new Food(){FoodName="Sütlaç",FoodImage="sütlac.jpg",FoodPrice=21,IsApproved=true,IsHome=false,IsSlider=false,FoodRecipe="sütlacccsç",FoodMaterial="a,b,c"}
        };

        private static FoodCategory[] FoodCategories ={
            new FoodCategory(){FoodId=1,CategoryId=1},
            new FoodCategory(){FoodId=2,CategoryId=2},
            new FoodCategory(){FoodId=3,CategoryId=2},
            new FoodCategory(){FoodId=4,CategoryId=5},
            new FoodCategory(){FoodId=6,CategoryId=1},
            new FoodCategory(){FoodId=12,CategoryId=2},
            new FoodCategory(){FoodId=13,CategoryId=6},
            new FoodCategory(){FoodId=14,CategoryId=8},
            new FoodCategory(){FoodId=15,CategoryId=8},
            new FoodCategory(){FoodId=16,CategoryId=5}
        };
    }
}
