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
    public class EfCoreCategoryRepository : EfCoreGenericRepository<Category>, ICategoryRepository
    {
        public EfCoreCategoryRepository(SalihRecipesContext context) : base(context)
        {

        }
        private SalihRecipesContext SalihRecipesContext
        {
            get { return context as SalihRecipesContext; }
        }
        public void DeleteFromCategory(int foodId, int categoryId)
        {
           
                var cmd = "delete from foodcategory where FoodId=@p0 and CategoryId=@p1";
            SalihRecipesContext.Database.ExecuteSqlRaw(cmd, foodId, categoryId);
            
        }

        public Category GetByIdWithFoods(int categoryId)
        {
            
                return SalihRecipesContext.Categories
                              .Where(i => i.CategoryId == categoryId)
                              .Include(i => i.FoodCategories)
                              .ThenInclude(i => i.Food)
                              .FirstOrDefault();
            
        }
    }
}
