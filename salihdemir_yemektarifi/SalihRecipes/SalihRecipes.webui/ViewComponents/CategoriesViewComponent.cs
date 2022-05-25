using Microsoft.AspNetCore.Mvc;
using SalihRecipes.business.Abstract;
//using Models;
//using shopapp.webui.Data;

namespace shopapp.webui.ViewComponents
{
    public class CategoriesViewComponent : ViewComponent
    {
        private ICategoryService _categoryService; //startap a yazd�k ICategoryService yaz�nca CategoryManager gelecek
                                                   //CategoryManager de de ICategoryRepository oldu�undan startapa yazd���m�z gibi
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

