using SalihRecipes.entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalihRecipes.webui.Models
{
    public class FoodModel
    {
        public int FoodId { get; set; }

        [Required(ErrorMessage = "Yemek ismi zorunludur!")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Yemek ismi 5-50 karakter uzunluğunda olmalıdır!")]
        public string FoodName { get; set; }
        public string Url { get; set; }
        public double? FoodPrice { get; set; }
        //public string FoodDescription { get; set; }

        [Required(ErrorMessage = "Malzemeler alanı zorunludur!")]
        public string FoodMaterial { get; set; }

        [Required(ErrorMessage = "Tarif alanı zorunludur!")]
        public string FoodRecipe { get; set; }
        public string FoodImage { get; set; }
        public bool IsApproved { get; set; }
        public bool IsHome { get; set; }
        public bool IsSlider { get; set; }
        public List<Category> SelectedCategories { get; set; }
    }
}
