using Microsoft.AspNetCore.Mvc;
using SalihRecipes.business.Abstract;
using SalihRecipes.webui.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalihRecipes.webui.Controllers
{
    public class AuthorController : Controller
    {
        private IAuthorService _authorService;

        public AuthorController(IAuthorService authorService)
        {
            _authorService = authorService;
        }

        //public IActionResult AuthorList()
        //{
        //    return View(new AuthorListViewModel()
        //    {
        //        Authors = _authorService.GetAll()
        //    }); 
        //}
    }
}
