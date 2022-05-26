using Microsoft.AspNetCore.Mvc;
using SalihRecipes.business.Abstract;
using SalihRecipes.webui.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalihRecipes.webui.Controllers
{
    public class FoodController : Controller
    {
        private IFoodService _foodService;
        private ICategoryService _categorydService;

        public FoodController(IFoodService foodService, ICategoryService categorydService)
        {
            _foodService = foodService;
            _categorydService = categorydService;
        }

        public IActionResult FoodList(string category, int page = 1)
        {
            const int pageSize = 2; //sayfadda kaç ürün gösterilecek
            var foodListViewmodel = new FoodListViewModel()
            {
                PageInfo = new PageInfo()
                {
                    TotalItems = _foodService.GetCountByCategory(category),
                    CurrentPage = page,
                    ItemsPerPage = pageSize,
                    CurrentCategory = category
                },
               
                Foods = _foodService.GetFoodsByCategory(category, page, pageSize),
            };
            ViewBag.CategoryName = _categorydService.GetAll().Where(i => i.Url == category).Select(i => i.CategoryName).FirstOrDefault();
            return View(foodListViewmodel);
        }
  
    }
}
