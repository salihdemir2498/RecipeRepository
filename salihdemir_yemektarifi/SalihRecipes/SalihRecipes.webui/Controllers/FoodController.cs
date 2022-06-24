using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SalihRecipes.business.Abstract;
using SalihRecipes.data.Concrete.EfCore;
using SalihRecipes.entity;
using SalihRecipes.webui.Identity;
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

        private UserManager<User> _userManager;
        public FoodController(IFoodService foodService, ICategoryService categorydService, UserManager<User> userManager)
        {
            _foodService = foodService;
            _categorydService = categorydService;
            _userManager = userManager;
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

        public async Task<IActionResult> FoodDetails(string url)
        {
            if (url == null)
            {
                return NotFound();
            }
            Food food = _foodService.GetFoodDetails(url);

            if (food == null)
            {
                return NotFound();
            }
            var user = await _userManager.GetUserAsync(User);

            return View(new FoodDetailModel
            {
                Food = food,
                Categories = food.FoodCategories.Select(i => i.Category).ToList(),
                UserName = food.UserId
            }) ;
           
        }

        public IActionResult Manage(string username)
        {
            var user = _userManager.Users.Where(i => i.UserName == username);

            return View(user);
        }

        public IActionResult Search(string q)
        {
            
            return View(_foodService.GetSearchResult(q));
        }

    }
}
