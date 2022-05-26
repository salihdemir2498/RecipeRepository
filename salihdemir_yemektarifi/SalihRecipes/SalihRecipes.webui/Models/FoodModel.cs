using SalihRecipes.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalihRecipes.webui.Models
{
    public class FoodModel
    {
        public int FoodId { get; set; }
        public string FoodName { get; set; }
        public string Url { get; set; }
        public double? FoodPrice { get; set; }
        public string FoodDescription { get; set; }
        public string FoodMaterial { get; set; }
        public string FoodRecipe { get; set; }
        public string FoodImage { get; set; }
        public bool IsApproved { get; set; }
        public bool IsHome { get; set; }
        public bool IsSlider { get; set; }
        public List<Category> SelectedCategories { get; set; }
    }
}
