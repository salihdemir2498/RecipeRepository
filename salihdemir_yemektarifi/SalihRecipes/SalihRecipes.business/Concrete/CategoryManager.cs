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
    public class CategoryManager : ICategoryService
    {
        private readonly IUnitOfWork _unitOfWork;
        public CategoryManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Create(Category entity)
        {
            _unitOfWork.Categories.Create(entity);
            _unitOfWork.Save();
        }

        public void Delete(Category entity)
        {
            _unitOfWork.Categories.Delete(entity);
            _unitOfWork.Save();
        }

        public List<Category> GetAll()
        {
            return _unitOfWork.Categories.GetAll();
        }

        public Category GetById(int id)
        {
            return _unitOfWork.Categories.GetById(id);
        }

        public Category GetByIdWithFoods(int categoryId)
        {
            return _unitOfWork.Categories.GetByIdWithFoods(categoryId);
        }

        public void Update(Category entity)
        {
            _unitOfWork.Categories.Update(entity);
            _unitOfWork.Save();
        }

        public void DeleteFromCategory(int foodId, int categoryId)
        {
            _unitOfWork.Categories.DeleteFromCategory(foodId, categoryId);
            _unitOfWork.Save();
        }
    }
}
