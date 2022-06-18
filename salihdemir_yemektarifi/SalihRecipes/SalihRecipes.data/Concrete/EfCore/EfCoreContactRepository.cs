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
    public class EfCoreContactRepository : EfCoreGenericRepository<Contact>, IContactRepository
    {
        public EfCoreContactRepository(SalihRecipesContext context) : base(context)
        {

        }
        private SalihRecipesContext SalihRecipesContext
        {
            get { return context as SalihRecipesContext; }
        }
        public Contact GetContactDetails(int id)
        {
            
                return SalihRecipesContext.Contacts
                               .Where(i => i.ContactId == id)
                               .FirstOrDefault();
            
        }
    }
}
