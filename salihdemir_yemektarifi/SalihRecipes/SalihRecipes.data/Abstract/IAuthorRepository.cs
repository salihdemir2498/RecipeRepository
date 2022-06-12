using SalihRecipes.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalihRecipes.data.Abstract
{
    public interface IAuthorRepository : IRepository<Author>
    {
        Author GetByIdWithFoods(string authorId);
        Author GetById(string id);
    }
}
