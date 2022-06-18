using Microsoft.EntityFrameworkCore;
using SalihRecipes.data.Abstract;
using SalihRecipes.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalihRecipes.data.Concrete.EfCore
{
    public class EfCoreAuthorRepository : EfCoreGenericRepository<Author>, IAuthorRepository
    {
        public EfCoreAuthorRepository(SalihRecipesContext context) : base(context)
        {

        }
        private SalihRecipesContext SalihRecipesContext
        {
            get { return context as SalihRecipesContext; }
        }
        public Author GetByIdWithFoods(int authorId)
        {
            
                return SalihRecipesContext.Authors
                              .Where(i => i.AuthorId == authorId)
                              .Include(i => i.AuthorFoods)
                              .ThenInclude(i => i.Food)
                              .FirstOrDefault();
            
        }
    }
}
