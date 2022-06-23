using SalihRecipes.business.Abstract;
using SalihRecipes.data.Abstract;
using SalihRecipes.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SalihRecipes.business.Concrete
{
    public class FoodManager : IFoodService,IValidator<Food>
    {
        private readonly IUnitOfWork _unitOfWork;
        public FoodManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

     

        public bool Create(Food entity)
        {
            if (Validation(entity))
            {
                _unitOfWork.Foods.Create(entity);
                _unitOfWork.Save();
                return true;
            }
            return false;
        }

        public void Delete(Food entity)
        {
            _unitOfWork.Foods.Delete(entity);
            _unitOfWork.Save();
        }

        public List<Food> GetAll()
        {
            return _unitOfWork.Foods.GetAll();
        }

        public Food GetById(int id)
        {
            return _unitOfWork.Foods.GetById(id);
        }

        public List<Food> GetHomePageFoods()
        {
            return _unitOfWork.Foods.GetHomePageFoods();
        }

        public List<Food> GetSliderFoods()
        {
            return _unitOfWork.Foods.GetSliderFoods();

        }

        public void Update(Food entity)
        {
            _unitOfWork.Foods.Update(entity);
            _unitOfWork.Save();
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
            return _unitOfWork.Foods.GetByIdWithCategories(id);
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
                _unitOfWork.Foods.Update(entity, categoryIds);
                _unitOfWork.Save();
                return true;
            }
            return false;
        }

        public int GetCountByCategory(string category)
        {
            return _unitOfWork.Foods.GetCountByCategory(category);
        }

        public List<Food> GetFoodsByCategory(string name, int page, int pageSize)
        {
            return _unitOfWork.Foods.GetFoodsByCategory(name, page, pageSize);
        }

        public void Create(Food entity, int[] categoryIds/*, int userId*/)
        {
            _unitOfWork.Foods.Create(entity,categoryIds/*, userId*/);
            _unitOfWork.Save();
        }

        public Food GetFoodDetails(string url)
        {
            return _unitOfWork.Foods.GetFoodDetails(url);
        }

        //public Food GetFoodDetails2(string url)
        //{
        //    return _unitOfWork.Foods.GetFoodDetails2(url);
        //}

        public List<Food> GetSearchResult(string searchString)
        {
            return _unitOfWork.Foods.GetSearchResult(searchString);
        }

        public Food GetSingle(Expression<Func<Food, bool>> filter)
        {
            return _unitOfWork.Foods.GetSingle(filter);
        }
    }
}
