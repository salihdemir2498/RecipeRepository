using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SalihRecipes.data.Concrete.EfCore;
using SalihRecipes.entity;
using SalihRecipes.webui.EmailServices;
using SalihRecipes.webui.Extensions;
using SalihRecipes.webui.Identity;
using SalihRecipes.webui.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalihRecipes.webui.Controllers
{
    [AutoValidateAntiforgeryToken]
    public class AccountController : Controller
    {
   
        private UserManager<User> _userManager;
        private SignInManager<User> _signInManager;
        private IEmailSender _emailSender;
        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager, IEmailSender emailSender)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _emailSender = emailSender;
        }
        public IActionResult AccessDenied()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }
      
    

        public IActionResult Login(RegisterModel model=null)
        {
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(string usernamee,string passwordd,string ReturnUrl)
        {
     
                if (string.IsNullOrEmpty(usernamee) && string.IsNullOrEmpty(passwordd))
                {
                ModelState.AddModelError("","Kullanıcı adı veya şifre yanlış");
                    return View(usernamee, passwordd);
                }
                var user = await _userManager.FindByNameAsync(usernamee);
                if (user == null)
                {
                    ModelState.AddModelError("", "Böyle bir kullanıcı bulunamadı!");
                    return View(usernamee, passwordd);
                }

                if (!await _userManager.IsEmailConfirmedAsync(user))
                {
                    ModelState.AddModelError("", "Hesabınız onaylı değil! Lütfen mail adresinizi kontrol ederek, onay işlemlerini kontrol ediniz");
                    return View(usernamee, passwordd);
                }
                var result = await _signInManager.PasswordSignInAsync(user, passwordd, true, false);
                if (result.Succeeded)
                {
                    return Redirect(ReturnUrl ?? "~/");
                }
                ModelState.AddModelError("", "Kullanıcı adı veya parola hatalı!");
                return View(usernamee, passwordd);
            
        }

        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = new User()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                UserName = model.UserName,
                Email = model.Email
            };

            var result = await _userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)//Create işlemi başarılıysa
            {
                await _userManager.AddToRoleAsync(user,"customer"); //üyelik oluşturulduğu zaman kullanıcı varsayılan olarak bir customer rolüne ait yapmak istiyosak 

                var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);

                var url = Url.Action("ConfirmEmail", "Account", new
                {
                    userId = user.Id,
                    token = code
                });
                
                //mail gönderme işlemleri
                await _emailSender.SendEmailAsync(model.Email, "SalihRecipes Hesap Onaylama", $"Lütfen email hesabınızı onaylamak için <a href='https://localhost:5001{url}'>tıklayınız.</a>");
 
                return RedirectToAction("Index", "Home");
   
            }

            CreateMessage("Bir sorun oluştu, lütfen tekrar deneyiniz", "danger");
            return View(model);
        }

        public async Task<IActionResult> ConfirmEmail(string userId, string token)
        {
            if (userId == null || token == null)
            {
                CreateMessage("Geçersiz token","danger");
                return View();
            }

            var user = await _userManager.FindByIdAsync(userId);
            if (user != null)
            {
                var result = await _userManager.ConfirmEmailAsync(user, token);
                if (result.Succeeded)
                {
                    CreateMessage("Hesabınız onaylanmıştır", "success");
                    return View();
                }
            }

            CreateMessage("Hesabınız onaylanamadı. Lütfen bilgileri kontrol ederek, yeniden deneyiniz!", "warning");
            return View();
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            TempData.Put("message", new AlertMessage()
            {
                Title = "Oturum Kapatıldı",
                Message = "Hesabınız güvenli bir şekilde kapatıldı.",
                AlertType = "warning"
            });
            return Redirect("~/");
        }

        public IActionResult ForgotPassword()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ForgotPassword(string email)
        {
            if (String.IsNullOrEmpty(email))
            {
                CreateMessage("Lütfen email adresini yazınız!", "warning");
                return View();
            }

            var user = await _userManager.FindByEmailAsync(email);
            if (user == null)
            {
                CreateMessage("Böyle bir mail adresi bulunamadı. Lütfen kontrol ediniz.", "warning");
            }

            var code = await _userManager.GeneratePasswordResetTokenAsync(user);
            var url = Url.Action("ResetPassword", "Account", new
            {
                userId = user.Id,
                token = code
            });

            await _emailSender.SendEmailAsync(

                email,
                "SalihRecipes Reset Password",
                $"Parolanızı yeniden belirlemek için <a href='https://localhost:5001{url}'>tıklayınız.</a>"
                );
            CreateMessage("Parola değiştirmek için gerekli link mail adresinize yollanmıştır.Lütfen kontrol ederek gerekli adımları takip ediniz!", "warning");
            return Redirect("~/");
        }

        public IActionResult ResetPassword(string userId, string token)
        {
            if (userId == null || token == null)
            {
                CreateMessage("Geçersiz işlem!", "danger");
                return RedirectToAction("Index", "Home");
            }
            var model = new ResetPasswordModel() { Token = token };
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ResetPassword(ResetPasswordModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user == null)
            {
                CreateMessage("Böyle bir kullanıcı bulunamadı!", "warning");
                return Redirect("~/");
            }
            var result = await _userManager.ResetPasswordAsync(user, model.Token, model.Password);
            if (result.Succeeded)
            {
                CreateMessage("Şifre değiştirme işleminiz gerçekleşti.", "success");
                return RedirectToAction("Login");
            }
            CreateMessage("İşlem başarısız oldu, lütfen daha sonra tekrar deneyiniz!", "danger");
            return View(model);
        }

        private void CreateMessage(string message, string alertType)
        {
            var msg = new AlertMessage()
            {
                Message = message,
                AlertType = alertType
            };
            TempData["Message"] = JsonConvert.SerializeObject(msg);
        }
    }
}
