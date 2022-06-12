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
    public class AuthorManager : IAuthorService
    {
        private IAuthorRepository _authorRepository;
        public AuthorManager(IAuthorRepository authorRepository)
        {
            _authorRepository = authorRepository;
        }
        public void Create(Author entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Author entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteFromAuthor(int foodId, string authorId)
        {
            throw new NotImplementedException();
        }

        public List<Author> GetAll()
        {
            return _authorRepository.GetAll();
        }

        public Author GetById(string id)
        {
            return _authorRepository.GetById(id);
        }

        public Author GetByIdWithFoods(string authorId)
        {
            return _authorRepository.GetByIdWithFoods(authorId);
        }

        public void Update(Author entity)
        {
            throw new NotImplementedException();
        }
    }
}
