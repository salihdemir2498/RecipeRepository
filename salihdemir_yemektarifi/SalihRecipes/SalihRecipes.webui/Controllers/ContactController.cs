using Microsoft.AspNetCore.Mvc;
using SalihRecipes.business.Abstract;
using SalihRecipes.business.Concrete;
using SalihRecipes.entity;
using SalihRecipes.webui.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalihRecipes.webui.Controllers
{
    public class ContactController : Controller
    {
        private IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Contact p)
        {
            p.ContactDate= DateTime.Parse(DateTime.Now.ToShortDateString());
            p.ContactStatus = true;
            _contactService.ContactAdd(p);
            return RedirectToAction("Index", "Home");
        }
    }
}
