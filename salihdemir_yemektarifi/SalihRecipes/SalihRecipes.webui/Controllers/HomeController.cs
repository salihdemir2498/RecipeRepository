using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SalihRecipes.business.Abstract;
using SalihRecipes.entity;
using SalihRecipes.webui.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SalihRecipes.webui.Controllers
{
    public class HomeController : Controller
    {
        private IFoodService _foodService; //startap a yazdık IProductService yazınca ProductManager gelecek
                                                 //ProductManager de de IProductRepository olduğundan startapa yazdığımız gibi
                                                 //EfCoreProductRepository gelecek
        public HomeController(IFoodService foodService)
        {
            this._foodService = foodService;
        }
        public IActionResult Index()
        {
            //FoodModel food = new FoodModel()
            //{
                
            //};
       
          
                var foodViewModel = new FoodListViewModel()
                {

                    Foods = _foodService.GetSliderFoods()
                };
          
        
           
                //var foodViewModel2 = new FoodListViewModel()
                //{

                //    Foods = _foodService.GetHomePageFoods()
                //};
          
            

            return View(foodViewModel);
            //return View();
        }
    }
}
