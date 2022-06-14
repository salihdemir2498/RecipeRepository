using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SalihRecipes.business.Abstract;
using SalihRecipes.business.Concrete;
using SalihRecipes.entity;
using SalihRecipes.webui.Identity;
using SalihRecipes.webui.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SalihRecipes.webui.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private IFoodService _foodService;
        private ICategoryService _categoryService;
        private RoleManager<IdentityRole> _roleManager;
        private UserManager<User> _userManager;
        private IContactService _contactService;
        private IAuthorService _authorService;

        public AdminController(IFoodService foodService, ICategoryService categoryService, RoleManager<IdentityRole> roleManager, UserManager<User> userManager, IContactService contactService, IAuthorService authorService)
        {
            _foodService = foodService;
            _categoryService = categoryService;
            _roleManager = roleManager;
            _userManager = userManager;
            _contactService = contactService;
            _authorService = authorService;
        }


        //public IActionResult UserList()
        //{
        //    return View(_userManager.Users);
        //}

        //public async Task<IActionResult> UserEdit(string id)
        //{
        //    var user = await _userManager.FindByIdAsync(id);
        //    if (user != null)
        //    {
        //        var selectedRoles = await _userManager.GetRolesAsync(user);
        //        var roles = _roleManager.Roles.Select(i => i.Name);
        //        ViewBag.Roles = roles;
        //        return View(new UserDetailsModel()
        //        {
        //            UserId = user.Id,
        //            FirstName = user.FirstName,
        //            LastName = user.LastName,
        //            UserName = user.UserName,
        //            Email = user.Email,
        //            EmailConfirmed = user.EmailConfirmed,
        //            SelectedRoles = selectedRoles
        //        });
        //    }
        //    return Redirect("~/admin/user/list");
        //}

        public IActionResult RoleList()
        {
            return View(_roleManager.Roles);
        }

        public IActionResult RoleCreate()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> RoleCreate(RoleModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _roleManager.CreateAsync(
                    new IdentityRole(model.Name)
                    );
                if (result.Succeeded)
                {
                    return RedirectToAction("RoleList");
                }

                //Geri kalan kısmına yarın devam edeceğiz.
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return View(model);
        }

        public async Task<IActionResult> RoleEdit(string id)
        {
            var role = await _roleManager.FindByIdAsync(id);
            var members = new List<User>();
            var nonMembers = new List<User>();

            foreach (var user in _userManager.Users)
            {
                var list = await _userManager.IsInRoleAsync(user, role.Name) ? members : nonMembers;
                list.Add(user);
            }
            var model = new RoleDetails()
            {
                Role = role,
                Members = members,
                NonMembers = nonMembers
            };
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> RoleEdit(RoleEditModel model)
        {
            if (ModelState.IsValid)
            {
                foreach (var userId in model.IdsToAdd ?? new string[] { })
                {
                    var user = await _userManager.FindByIdAsync(userId);
                    if (user != null)
                    {
                        var result = await _userManager.AddToRoleAsync(user, model.RoleName);
                        if (!result.Succeeded)
                        {
                            foreach (var error in result.Errors)
                            {
                                ModelState.AddModelError("", error.Description);
                            }
                        }
                    }
                }

                foreach (var userId in model.IdsToDelete ?? new string[] { })
                {
                    var user = await _userManager.FindByIdAsync(userId);
                    if (user != null)
                    {
                        var result = await _userManager.RemoveFromRoleAsync(user, model.RoleName);
                        if (!result.Succeeded)
                        {
                            foreach (var error in result.Errors)
                            {
                                ModelState.AddModelError("", error.Description);
                            }
                        }
                    }
                }
            }
            return Redirect("/admin/role/" + model.RoleId);
        }
        [AllowAnonymous]
        public IActionResult FoodList()
        {
            return View(new FoodListViewModel()
            {
                Foods = _foodService.GetAll()
            });
        }
        [AllowAnonymous]
        [HttpGet]
        public IActionResult FoodCreate()
        {
            ViewBag.Categories = _categoryService.GetAll();

            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public IActionResult FoodCreate(FoodModel model,int[] categoryIds, IFormFile file)
        {
            if (ModelState.IsValid && categoryIds.Length > 0 && file != null)  
            {
                

                var url = JobManager.MakeUrl(model.FoodName);

                model.FoodImage = file.FileName;  //veritabanına resim isminin eklenmesi
                    var extention = Path.GetExtension(file.FileName);
                    var randomName = string.Format($"{Guid.NewGuid()}{extention}");
                    model.FoodImage = randomName;      //shopapp.webui
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images", randomName); 

                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                         file.CopyTo(stream);
                    }
                
                var entity = new Food()
                {
                    FoodName = model.FoodName,
                    FoodPrice = model.FoodPrice,
                    Url=url,
                    FoodMaterial=model.FoodMaterial,
                    FoodRecipe=model.FoodRecipe,
                    FoodImage = model.FoodImage,
                    IsApproved = model.IsApproved,
                    IsHome = model.IsHome
                };
                string userId = _userManager.GetUserId(User);

                var author= _authorService.GetSingle(i=>i.UserId==userId);
                _foodService.Create(entity, categoryIds, author.AuthorId);

                 CreateMessage("Kayıt Eklendi", "success");
                    return RedirectToAction("FoodList");
               

            }
            //Eğer validationdan geçemediyse ve/veya kategori seçilmemişse
            
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
            ViewBag.Categories = _categoryService.GetAll();
            return View(model);  
        }
        [AllowAnonymous]
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
        [AllowAnonymous]
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

        [HttpGet]
        public IActionResult CategoryEdit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var entity = _categoryService.GetByIdWithFoods((int)id);

            if (entity == null)
            {
                return NotFound();
            }
            var model = new CategoryModel()
            {
                CategoryId = entity.CategoryId,
                CategoryName = entity.CategoryName,
                Url = entity.Url,
                Foods = entity.FoodCategories.Select(p => p.Food).ToList()
            };
            return View(model);

        }

        [HttpPost]
        public IActionResult CategoryEdit(CategoryModel model)
        {
            if (ModelState.IsValid)
            {
                var entity = _categoryService.GetById((int)model.CategoryId);

                if (entity == null)
                {
                    return NotFound();
                }

                entity.CategoryName = model.CategoryName;
                entity.Url = model.Url;

                _categoryService.Update(entity);

                var msg = new AlertMessage()
                {
                    Message = $"{entity.CategoryName} isimli category güncellendi.",
                    AlertType = "success"
                };

                TempData["message"] = JsonConvert.SerializeObject(msg);

                return RedirectToAction("CategoryList");
            }

            return View(model);
        }

        public IActionResult DeleteCategory(int categoryId)
        {
            var entity = _categoryService.GetById(categoryId);

            if (entity != null)
            {
                _categoryService.Delete(entity);
            }

            var msg = new AlertMessage()
            {
                Message = $"{entity.CategoryName} isimli category silindi.",
                AlertType = "danger"
            };

            TempData["message"] = JsonConvert.SerializeObject(msg);

            return RedirectToAction("CategoryList");
        }

        [HttpPost]
        public IActionResult DeleteFromCategory(int foodId, int categoryId)  //category ve product 'ın kesiştiği veriyi silicez
        {
            _categoryService.DeleteFromCategory(foodId, categoryId);
            return Redirect("/admin/categories/" + categoryId);
        }

        

        public IActionResult InboxPage()
        {
            return View(new ContactListViewModel()
            {
                Contacts = _contactService.GetAll()
            });
      
        }

        //public IActionResult InboxPageDetails()
        //{

        //}
        public IActionResult InboxPageDetails(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            Contact contact = _contactService.GetContactDetails(id);

            if (contact == null)
            {
                return NotFound();
            }
            return View(new ContactDetailModel
            {
                Contact = contact    
            });
            
        }



        private void CreateMessage(string message, string alerttype)
            {
            var msg = new AlertMessage()
            {
                Message = message,
                AlertType = alerttype
            };

            TempData["message"] = JsonConvert.SerializeObject(msg);


        }
    }
}
