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
    public class EfCoreCategoryRepository : EfCoreGenericRepository<Category, SalihRecipesContext>, ICategoryRepository
    {
        public void DeleteFromCategory(int foodId, int categoryId)
        {
            using (var context = new SalihRecipesContext())
            {
                var cmd = "delete from foodcategory where FoodId=@p0 and CategoryId=@p1";
                context.Database.ExecuteSqlRaw(cmd, foodId, categoryId);
            }
        }

        public Category GetByIdWithProducts(int categoryId)
        {
            using (var context = new SalihRecipesContext())
            {
                return context.Categories
                              .Where(i => i.CategoryId == categoryId)
                              .Include(i => i.FoodCategories)
                              .ThenInclude(i => i.Food)
                              .FirstOrDefault();
            }
        }
    }
}
