using SalihRecipes.entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalihRecipes.webui.Models
{
    public class CategoryModel
    {
        public int? CategoryId { get; set; } //? yaparak categori edit sayfasında kategori seçmezsek hata vermez

        [Required(ErrorMessage = "Kategori adı zorunludur.")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Kategori için 5 ile 100 arasında değer giriniz.")]
        public string CategoryName { get; set; }

        [Required(ErrorMessage = "Url adı zorunludur.")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Url için 5 ile 100 arasında değer giriniz.")]
        public string Url { get; set; }

        public string CategoryImage { get; set; }
        public List<Food> Foods { get; set; }

    }
}
