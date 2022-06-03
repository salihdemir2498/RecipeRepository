using SalihRecipes.business.Abstract;
using SalihRecipes.data.Abstract;
using SalihRecipes.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalihRecipes.business.Concrete
{
    public class FoodManager : IFoodService,IValidator<Food>
    {
        private IFoodRepository _foodRepository;
        public FoodManager(IFoodRepository foodRepository)
        {
            _foodRepository = foodRepository;
        }

     

        public bool Create(Food entity)
        {
            if (Validation(entity))
            {
                _foodRepository.Create(entity);
                return true;
            }
            return false;
        }

        public void Delete(Food entity)
        {
            _foodRepository.Delete(entity);
        }

        public List<Food> GetAll()
        {
            return _foodRepository.GetAll();
        }

        public Food GetById(int id)
        {
            return _foodRepository.GetById(id);
        }

        public List<Food> GetHomePageFoods()
        {
            return _foodRepository.GetHomePageFoods();
        }

        public List<Food> GetSliderFoods()
        {
            return _foodRepository.GetSliderFoods();

        }

        public void Update(Food entity)
        {
            _foodRepository.Update(entity);
        }

        public string ErrorMessage { get; set; }
        public bool Validation(Food entity)
        {
            var isValid = true;

            if (string.IsNullOrEmpty(entity.FoodName))
            {
                ErrorMessage += "Yemek ismi girmelisiniz. \n";
                isValid = false;
            }

            if (entity.FoodPrice < 0)
            {
                ErrorMessage += "Yemek Fiyatı negatif olamaz. \n";
                isValid = false;
            }

            return isValid;
        }

        public Food GetByIdWithCategories(int id)
        {
            return _foodRepository.GetByIdWithCategories(id);
        }

        public bool Update(Food entity, int[] categoryIds)
        {
            if (Validation(entity))
            {
                if (categoryIds.Length == 0)
                {
                    ErrorMessage += "En az 1 kategori seçmelisiniz.";
                    return false;
                }
                _foodRepository.Update(entity, categoryIds);
                return true;
            }
            return false;
        }

        public int GetCountByCategory(string category)
        {
            return _foodRepository.GetCountByCategory(category);
        }

        public List<Food> GetFoodsByCategory(string name, int page, int pageSize)
        {
            return _foodRepository.GetFoodsByCategory(name, page, pageSize);
        }

        public void Create(Food entity, int[] categoryIds)
        {
            _foodRepository.Create(entity,categoryIds);
        }

        public Food GetFoodDetails(string url)
        {
            return _foodRepository.GetFoodDetails(url);
        }

        public List<Food> GetSearchResult(string searchString)
        {
            return _foodRepository.GetSearchResult(searchString);
        }
    }
}
