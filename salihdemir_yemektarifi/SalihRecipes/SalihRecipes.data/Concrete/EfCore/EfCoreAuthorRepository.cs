﻿using Microsoft.EntityFrameworkCore;
using SalihRecipes.data.Abstract;
using SalihRecipes.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalihRecipes.data.Concrete.EfCore
{
    public class EfCoreAuthorRepository : EfCoreGenericRepository<Author, SalihRecipesContext>, IAuthorRepository
    {
        public Author GetById(string id)
        {
           
                using (var context = new SalihRecipesContext())
                {
                    return context.Set<Author>().Find(id);
                }
            
        }

        public Author GetByIdWithFoods(string authorId)
        {
            using (var context = new SalihRecipesContext())
            {
                return context.Authors
                              .Where(i => i.AuthorId == authorId)
                              .Include(i => i.AuthorFoods)
                              .ThenInclude(i => i.Food)
                              .FirstOrDefault();
            }
        }
    }
}