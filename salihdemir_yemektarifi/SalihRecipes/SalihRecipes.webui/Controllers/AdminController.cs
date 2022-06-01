using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SalihRecipes.business.Abstract;
using SalihRecipes.business.Concrete;
using SalihRecipes.entity;
using SalihRecipes.webui.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SalihRecipes.webui.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        private IFoodService _foodService;
        private ICategoryService _categoryService;
        public AdminController(IFoodService foodService, ICategoryService categoryService)
        {
            _foodService = foodService;
            _categoryService = categoryService;
        }
        public IActionResult FoodList()
        {
            return View(new FoodListViewModel()
            {
                Foods = _foodService.GetAll()
            });
        }

        [HttpGet]
        public IActionResult FoodCreate()
        {
            ViewBag.Categories = _categoryService.GetAll();
            return View();
        }

        [HttpPost]
        public IActionResult FoodCreate(FoodModel model,int[] categoryIds, IFormFile file)
        {
            if (ModelState.IsValid && categoryIds.Length > 0 && file != null)  //model de bütün kriterler uygunmu
            {
                JobManager urlGenerate = new JobManager();

                var url = urlGenerate.MakeUrl(model.FoodName);

                model.FoodImage = file.FileName;  //veritabanına resim isminin eklenmesi
                    var extention = Path.GetExtension(file.FileName);
                    var randomName = string.Format($"{Guid.NewGuid()}{extention}");
                    model.FoodImage = randomName;      //shopapp.webui
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images", randomName); //resim nereye kaydediliyo

                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                         file.CopyTo(stream);
                    }
                
                var entity = new Food()
                {
                    FoodName = model.FoodName,
                    FoodPrice = model.FoodPrice,
                    Url=url,
                    FoodDescription = model.FoodDescription,
                    FoodMaterial=model.FoodMaterial,
                    FoodRecipe=model.FoodRecipe,
                    FoodImage = model.FoodImage,
                    IsApproved = model.IsApproved,
                    IsHome = model.IsHome
                };
                if (_foodService.Create(entity))
                {
                    CreateMessage("Kayıt Eklendi", "success");
                    return RedirectToAction("FoodList");
                } 

            }
            //Eğer validationdan geçemediyse ve/veya kategori seçilmemişse
            ViewBag.Categories = _categoryService.GetAll();
            if (categoryIds.Length > 0)
            {
                model.SelectedCategories = categoryIds.Select(catid => new Category()
                {
                    CategoryId = catid

                }).ToList();
            }
            else
            {
                ViewBag.CategoryMessage = "Lütfen bir kategori seçimi yapınız!";
            }
            if (file == null)
            {
                ViewBag.ImageMessage = "Lütfen resim seçiniz";
            }
            return View(model);  //hata varsa aynı sayfaya geri gönderdik
        }

        public IActionResult FoodEdit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var entity = _foodService.GetByIdWithCategories((int)id);
            if (entity == null)
            {
                return NotFound();
            }

            var model = new FoodModel()
            {
                FoodId = entity.FoodId,
                FoodName = entity.FoodName,
                Url = entity.Url,
                FoodPrice = entity.FoodPrice,
                FoodImage = entity.FoodImage,
                FoodDescription = entity.FoodDescription,
                FoodMaterial=entity.FoodMaterial,
                FoodRecipe=entity.FoodRecipe,
                IsApproved = entity.IsApproved,
                IsHome = entity.IsHome,
                IsSlider=entity.IsSlider,
                SelectedCategories = entity.FoodCategories.Select(i => i.Category).ToList() //seçilmiş kategori bilgilerini aldık
            }; //veritabanından aldığımız bilgiyi productmodele aktardık

            ViewBag.Categories = _categoryService.GetAll();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> FoodEdit(FoodModel model, int[] categoryIds, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                var entity = _foodService.GetById(model.FoodId);
                if (entity == null)
                {
                    return NotFound();
                }

                entity.FoodName = model.FoodName;
                entity.Url = model.Url;
                entity.FoodPrice = model.FoodPrice;
                entity.FoodImage = model.FoodImage;
                entity.FoodDescription = model.FoodDescription;
                entity.FoodMaterial = model.FoodMaterial;
                entity.FoodRecipe = model.FoodRecipe;
                entity.IsApproved = model.IsApproved;
                entity.IsHome = model.IsHome;
                entity.IsSlider = model.IsSlider;

                if (file != null)
                {
                    entity.FoodImage = file.FileName;  //veritabanına resim isminin eklenmesi
                    var extention = Path.GetExtension(file.FileName);
                    var randomName = string.Format($"{Guid.NewGuid()}{extention}");
                    entity.FoodImage = randomName;      //shopapp.webui
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images", randomName); //resim nereye kaydediliyo

                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }
                }

                if (_foodService.Update(entity, categoryIds))
                {
                    CreateMessage($"{entity.FoodName} İsimli Kayıt Güncellendi", "success");
                    return RedirectToAction("FoodList");
                }
                CreateMessage(_foodService.ErrorMessage, "danger");
            }
            ViewBag.Categories = _categoryService.GetAll();
            return View(model);
        }

        public IActionResult DeleteFood(int foodId)
        {
            var entity = _foodService.GetById(foodId);

            if (entity != null)
            {
                _foodService.Delete(entity);
            }

            var msg = new AlertMessage()
            {
                Message = $"{entity.FoodName} isimli ürün silindi.",
                AlertType = "danger"
            };

            TempData["message"] = JsonConvert.SerializeObject(msg);

            return RedirectToAction("FoodList");
        }


        public IActionResult CategoryList()
        {
            return View(new CategoryListViewModel()
            {

                Categories = _categoryService.GetAll()
            });
        }

        public IActionResult CategoryCreate()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CategoryCreate(CategoryModel model, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                if (file != null)
                {
                    model.CategoryImage = file.FileName;  
                    var extention = Path.GetExtension(file.FileName);
                    var randomName = string.Format($"{Guid.NewGuid()}{extention}");
                    model.CategoryImage = randomName;      
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images", randomName); //resim nereye kaydediliyo

                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }

                }

                var entity = new Category()
                {
                    CategoryName = model.CategoryName,
                    Url = model.Url,
                    CategoryImage=model.CategoryImage

                };
                _categoryService.Create(entity);


                var msg = new AlertMessage()
                {
                    Message = $"{entity.CategoryName} isimli category eklendi.",
                    AlertType = "success"
                };

                TempData["message"] = JsonConvert.SerializeObject(msg);

                return RedirectToAction("CategoryList");
            }

            return View(model);

        }




            private void CreateMessage(string message, string alerttype)
            {
            var msg = new AlertMessage()
            {
                Message = message,
                AlertType = alerttype
            };

            TempData["message"] = JsonConvert.SerializeObject(msg);
            //{"Message" = "samsung isimli ürün eklendi." , "AlertType" = "Success"}

        }
    }
}
