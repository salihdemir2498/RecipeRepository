using SalihRecipes.entity;
using SalihRecipes.webui.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalihRecipes.webui.Models
{
    public class FoodDetailModel
    {
        public Food Food { get; set; }
        public List<Category> Categories { get; set; }
        //public User Author { get; set; }
        public string UserName { get; set; }


    }
}
