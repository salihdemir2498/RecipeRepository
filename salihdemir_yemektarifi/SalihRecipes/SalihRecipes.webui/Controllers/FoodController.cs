using Microsoft.AspNetCore.Mvc;
using SalihRecipes.business.Abstract;
using SalihRecipes.entity;
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
        private IAuthorService _authorService;

        public FoodController(IFoodService foodService, ICategoryService categorydService, IAuthorService authorService)
        {
            _foodService = foodService;
            _categorydService = categorydService;
            _authorService = authorService;
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

        public IActionResult FoodDetails(string url)
        {
            if (url == null)
            {
                return NotFound();
            }
            Food food = _foodService.GetFoodDetails(url);
           Food food2 = _foodService.GetFoodDetails2(url);
            int authorID = food2.AuthorFoods.Find(i => i.FoodId == food.FoodId).AuthorId;
            if (food == null)
            {
                return NotFound();
            }
            return View(new FoodDetailModel
            {
                Food = food,
                Categories = food.FoodCategories.Select(i => i.Category).ToList(),
                Author = _authorService.GetById(authorID)
            }) ;
           
        }

        public IActionResult Search(string q)
        {
            
            return View(_foodService.GetSearchResult(q));
        }

    }
}
