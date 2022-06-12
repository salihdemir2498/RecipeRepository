using Microsoft.EntityFrameworkCore;
using SalihRecipes.data.Abstract;
using SalihRecipes.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalihRecipes.data.Concrete.EfCore
{
    public class EfCoreFoodRepository : EfCoreGenericRepository<Food, SalihRecipesContext> , IFoodRepository
    {
        public void Create(Food entity, int[] categoryIds/*, string authorId*/)
        {
            using (var context = new SalihRecipesContext())
            {
                context.Foods.Add(entity);
                context.SaveChanges();
                entity.FoodCategories = categoryIds.Select(catId => new FoodCategory()
                {
                    FoodId = entity.FoodId,
                    CategoryId = catId
                }).ToList();
                context.SaveChanges();
                //authorId = entity.AuthorFoods.Where(i => i.AuthorId).FirstOrDefault();
            }
        }

        public Food GetByIdWithCategories(int id)
        {
            using (var context = new SalihRecipesContext())
            {
                return context.Foods.Where(i => i.FoodId == id)
                                    .Include(i => i.FoodCategories)
                                    .ThenInclude(i => i.Category)
                                    .FirstOrDefault();
            }
        }

        public int GetCountByCategory(string category)
        {
            using (var context = new SalihRecipesContext())
            {
                var foods = context.Foods.Where(i => i.IsApproved).AsQueryable();

                if (!string.IsNullOrEmpty(category))
                {
                    foods = foods
                                    .Include(i => i.FoodCategories)
                                    .ThenInclude(i => i.Category)
                                    .Where(i => i.FoodCategories.Any(a => a.Category.Url == category));
                }
                return foods.Count();
            }           //Örneğin 25 değeri gelecek 
        }

        public Food GetFoodDetails(string url)
        {
            using (var context = new SalihRecipesContext())
            {
                return context.Foods
                               .Where(i => i.Url == url)
                               .Include(i => i.FoodCategories)
                               .ThenInclude(i => i.Category)
                               .FirstOrDefault();
            }
        }

        public Food GetFoodDetails2(string url)
        {
            using (var context = new SalihRecipesContext())
            {
                return context.Foods
                               .Where(i => i.Url == url)
                               .Include(i => i.AuthorFoods)
                               .ThenInclude(i => i.Author)
                               .FirstOrDefault();
            }
        }

        public List<Food> GetFoodsByCategory(string name, int page, int pageSize)
        {
            using (var context = new SalihRecipesContext())
            {
                var foods = context.Foods.Where(i => i.IsApproved).AsQueryable(); //asqueryable biz sorguyu yazıyoruz ancak veritabanına göndermeden önce üzerine ekstradan bir linq sorgusu bir kriter eklemek
                                                                                        //istiyorum
                if (!string.IsNullOrEmpty(name))
                {
                    foods = foods
                                    .Include(i => i.FoodCategories)
                                    .ThenInclude(i => i.Category)
                                    .Where(i => i.FoodCategories.Any(a => a.Category.Url == name)); //ilgili food kategorilerinden herhangi birinin gönderdiğimiz name e eşit olup olmadığıyla ilgili
                }
                return foods.Skip((page - 1) * pageSize).Take(pageSize).ToList(); //example:3 sayfa var pagesize 6 => Skip(12).Take(6) 12 ürünü ötele 6 ürün al
            }           //Skip(5) 5 ürün öteler ilk 5 ürünu öteler  
        }

        public List<Food> GetHomePageFoods()
        {
            using (var context = new SalihRecipesContext())
            {
                return context.Foods.Where(i => i.IsApproved).ToList();
            }
        }

        private string ConvertLower(string text)
        {
            //İstanbul Irak Üzgün Şelaler Satırarası
            text = text.Replace("I", "i");//İstanbul irak Üzgün Şelaleler Satırarası
            text = text.Replace("İ", "i");//istanbul irak Üzgün Şelaleler Satırarası
            text = text.Replace("ı", "i");//istanbul irak Üzgün Şelaleler Satirarasi

            text = text.ToLower();//istanbul irak üzgün şelaleler satirarasi
            text = text.Replace("ç", "c");
            text = text.Replace("ö", "o");
            text = text.Replace("ü", "u");
            text = text.Replace("ş", "s");
            text = text.Replace("ğ", "g");
            return text;
        }

        public List<Food> GetSearchResult(string searchString)
        {
            searchString = ConvertLower(searchString);

            using (var context = new SalihRecipesContext())
            {
                var foods = context
                    .Foods
                    .Where(i => i.IsApproved).ToList();
                foreach (var item in foods)
                {
                    item.FoodName = ConvertLower(item.FoodName);
                    
                }
                var foods2 = foods
                    .Where(i => i.FoodName == searchString)
                    .ToList();

                return foods2;
            }
        }

        public List<Food> GetSliderFoods()
        {
            using (var context = new SalihRecipesContext())
            {
                return context.Foods.Where(i => i.IsApproved && i.IsHome && i.IsSlider).ToList();
            }
        }

        public void Update(Food entity, int[] categoryIds)
        {
            using (var context = new SalihRecipesContext())
            {
                var food = context.Foods
                                     .Include(i => i.FoodCategories)
                                     .FirstOrDefault(i => i.FoodId == entity.FoodId); //burada bize bir product gel
      

                if (food != null)
                {
                    food.FoodName = entity.FoodName;
                    food.FoodPrice = entity.FoodPrice;
                    food.FoodMaterial = entity.FoodMaterial;
                    food.FoodRecipe = entity.FoodRecipe;
                    food.Url = entity.Url;
                    food.FoodImage = entity.FoodImage;
                    food.IsApproved = entity.IsApproved;
                    food.IsHome = entity.IsHome;
                    food.IsSlider = entity.IsSlider;

                    food.FoodCategories = categoryIds.Select(catid => new FoodCategory()
                    {
                        FoodId = entity.FoodId,
                        CategoryId = catid
                    }).ToList();

                    context.SaveChanges();
                }
            }
        }
    }
}
