using SalihRecipes.data.Abstract;
using SalihRecipes.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalihRecipes.data.Concrete.EfCore
{
    public class EfCoreContactRepository : EfCoreGenericRepository<Contact,SalihRecipesContext>,IContactRepository
    {

    }
}
