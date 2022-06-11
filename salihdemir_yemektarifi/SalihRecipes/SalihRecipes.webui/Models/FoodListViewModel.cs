using SalihRecipes.entity;
using System;
using System.Collections.Generic;

namespace SalihRecipes.webui.Models
{

    public class PageInfo
    {
        public int TotalItems { get; set; }
        public int ItemsPerPage { get; set; } //sayfa baþý kaç ürün göstermek istiyosun
        public int CurrentPage { get; set; }  //o an hangi sayfadasýn
        public string CurrentCategory { get; set; }  //linkin sonuna gelecek category varmý yokmu // localhost/products/telefon?page=1 => buradaki telefon gibi

        //sayfada 10 ürün var biz üçerli göstereceðiz sayfada 10/3=3.3 oluyo 4 e yuvarlamamýz lazým.
        public int TotalPages()
        {
            return (int)Math.Ceiling((decimal)TotalItems / ItemsPerPage);
        }
    }

    public class FoodListViewModel
    {
        public PageInfo PageInfo { get; set; }
        public List<Food> Foods { get; set; }
        public List<Category> Categories { get; set; }
        public List<Author> Authors { get; set; }
    }
}