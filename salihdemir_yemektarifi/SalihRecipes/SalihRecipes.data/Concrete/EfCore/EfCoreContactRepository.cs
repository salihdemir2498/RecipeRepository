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
    public class EfCoreContactRepository : EfCoreGenericRepository<Contact, SalihRecipesContext>, IContactRepository
    {
        public Contact GetContactDetails(int id)
        {
            using (var context = new SalihRecipesContext())
            {
                return context.Contacts
                               .Where(i => i.ContactId == id)
                               .FirstOrDefault();
            }
        }
    }
}
