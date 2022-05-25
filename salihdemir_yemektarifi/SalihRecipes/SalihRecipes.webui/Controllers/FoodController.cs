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
        public FoodController(IFoodService foodService)
        {
            _foodService = foodService;
        }

        public IActionResult FoodList(string category, int page = 1)
        {
            const int pageSize = 2; //sayfadda kaç ürün gösterilecek
            var productViewModel = new FoodListViewModel()
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

            return View(productViewModel);
        }
  
    }
}
