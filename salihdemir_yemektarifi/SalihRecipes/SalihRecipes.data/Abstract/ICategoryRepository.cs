using SalihRecipes.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalihRecipes.data.Abstract
{
    public interface ICategoryRepository : IRepository<Category>
    {
        void DeleteFromCategory(int productId, int categoryId);
        Category GetByIdWithProducts(int categoryId);
    }
}
