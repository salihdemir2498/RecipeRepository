using SalihRecipes.entity;
using System;
using System.Collections.Generic;

namespace SalihRecipes.webui.Models
{

    public class PageInfo
    {
        public int TotalItems { get; set; }
        public int ItemsPerPage { get; set; } //sayfa ba�� ka� �r�n g�stermek istiyosun
        public int CurrentPage { get; set; }  //o an hangi sayfadas�n
        public string CurrentCategory { get; set; }  //linkin sonuna gelecek category varm� yokmu // localhost/products/telefon?page=1 => buradaki telefon gibi

        //sayfada 10 �r�n var biz ��erli g�sterece�iz sayfada 10/3=3.3 oluyo 4 e yuvarlamam�z laz�m.
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