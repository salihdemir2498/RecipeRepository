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
    public class AuthorManager : IAuthorService
    {
        private readonly IUnitOfWork _unitOfWork;
        public AuthorManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public void Create(Author entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Author entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteFromAuthor(int foodId, int authorId)
        {
            throw new NotImplementedException();
        }

        public List<Author> GetAll()
        {
            return _unitOfWork.Authors.GetAll();
        }

        public Author GetById(int id)
        {
            return _unitOfWork.Authors.GetById(id);
        }

        public Author GetByIdWithFoods(int authorId)
        {
            return _unitOfWork.Authors.GetByIdWithFoods(authorId);
        }

        public Author GetSingle(Expression<Func<Author, bool>> filter)
        {
            return _unitOfWork.Authors.GetSingle(filter);
        }

        public void Update(Author entity)
        {
            throw new NotImplementedException();
        }
    }
}
