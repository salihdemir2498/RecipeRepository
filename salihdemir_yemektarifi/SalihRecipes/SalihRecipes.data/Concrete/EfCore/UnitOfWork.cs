using SalihRecipes.data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalihRecipes.data.Concrete.EfCore
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SalihRecipesContext _context;

        public UnitOfWork(SalihRecipesContext context)
        {
            _context = context;
        }

        private EfCoreCategoryRepository _categoryRepository;
        private EfCoreFoodRepository _foodRepository;
        private EfCoreContactRepository _contactRepository;
        public IFoodRepository Foods => _foodRepository = _foodRepository ?? new EfCoreFoodRepository(_context);

        public ICategoryRepository Categories => _categoryRepository = _categoryRepository ?? new EfCoreCategoryRepository(_context);

       

        public IContactRepository Contacts => _contactRepository = _contactRepository ?? new EfCoreContactRepository(_context);

        public void Dispose()
        {
            _context.Dispose();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
