using SalihRecipes.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalihRecipes.business.Abstract
{
    public interface IAuthorService
    {
        Author GetById(int id);
        List<Author> GetAll();
        void Create(Author entity);
        void Update(Author entity);
        void Delete(Author entity);
        Author GetByIdWithFoods(int authorId);
        void DeleteFromAuthor(int foodId, int authorId);
    }
}
