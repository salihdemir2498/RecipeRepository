using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalihRecipes.data.Abstract
{
    public interface IUnitOfWork : IDisposable
    {
        IFoodRepository Foods { get; }
        ICategoryRepository Categories { get; }
        IAuthorRepository Authors { get; }
        IContactRepository Contacts { get; }
        void Save();
    }
}
