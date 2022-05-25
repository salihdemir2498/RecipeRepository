using SalihRecipes.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalihRecipes.data.Abstract
{
    public interface IFoodRepository : IRepository<Food>
    {
        List<Food> GetHomePageFoods();
        List<Food> GetSliderFoods();
        Food GetByIdWithCategories(int id);
        void Update(Food entity, int[] categoryIds);
        int GetCountByCategory(string category);
        void Create(Food entity, int[] categoryIds);
        List<Food> GetFoodsByCategory(string name, int page, int pageSize); //category ismini gönderelim ona göre bize foodları göstersin
    }
}
