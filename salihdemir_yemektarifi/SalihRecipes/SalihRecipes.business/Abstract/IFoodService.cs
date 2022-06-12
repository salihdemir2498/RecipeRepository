using SalihRecipes.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalihRecipes.business.Abstract
{
    public interface IFoodService : IValidator<Food>
    {
        Food GetById(int id);
        List<Food> GetAll();
        bool Create(Food entity);
        void Delete(Food entity);
        void Update(Food entity);
        List<Food> GetHomePageFoods();
        List<Food> GetSliderFoods();
        List<Food> GetFoodsByCategory(string name, int page, int pageSize);
        Food GetByIdWithCategories(int id);
        bool Update(Food entity, int[] categoryIds);
        void Create(Food entity, int[] categoryIds/*, string authorId*/);
        int GetCountByCategory(string category);
        Food GetFoodDetails(string url);
        Food GetFoodDetails2(string url);
        List<Food> GetSearchResult(string searchString);

    }
}
