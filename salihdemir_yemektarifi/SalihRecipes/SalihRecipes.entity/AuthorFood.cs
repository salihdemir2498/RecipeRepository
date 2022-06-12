using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalihRecipes.entity
{
    public class AuthorFoods
    {
        public int FoodId { get; set; }
        public Food Food { get; set; }
        public string AuthorId { get; set; }
        public Author Author { get; set; }
    }
}
