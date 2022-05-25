using Microsoft.AspNetCore.Mvc;
using SalihRecipes.business.Abstract;
using SalihRecipes.webui.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalihRecipes.webui.Controllers
{
    public class CategoryController : Controller
    {
        private ICategoryService _categoryService; //startap a yazdık IProductService yazınca ProductManager gelecek
                                           //ProductManager de de IProductRepository olduğundan startapa yazdığımız gibi
                                           //EfCoreProductRepository gelecek
        public CategoryController(ICategoryService categoryService)
        {
            this._categoryService = categoryService;
        }
        public IActionResult Index()
        {
            var categoryViewModel = new CategoryListViewModel()
            {

                Categories = _categoryService.GetAll()
            };

            return View(categoryViewModel);
        }
    }
}
