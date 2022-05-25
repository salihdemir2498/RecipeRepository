using Microsoft.AspNetCore.Mvc;
using SalihRecipes.business.Abstract;
//using Models;
//using shopapp.webui.Data;

namespace shopapp.webui.ViewComponents
{
    public class CategoriesViewComponent : ViewComponent
    {
        private ICategoryService _categoryService; //startap a yazdýk ICategoryService yazýnca CategoryManager gelecek
                                                   //CategoryManager de de ICategoryRepository olduðundan startapa yazdýðýmýz gibi
                                                   //EfCoreCategoryRepository gelecek
        public CategoriesViewComponent(ICategoryService categoryService)
        {
            this._categoryService = categoryService;
        }
        public IViewComponentResult Invoke()
        {
            if (RouteData.Values["category"] != null)
            {
                ViewBag.SelectedCategory = RouteData?.Values["category"];

            }
            return View(_categoryService.GetAll());


        }
    }
}

