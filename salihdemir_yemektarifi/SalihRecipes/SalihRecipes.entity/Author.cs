using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalihRecipes.entity
{
    public class Author
    {
        public string AuthorId { get; set; }
        public string AuthorFullName { get; set; }
        public string UserId { get; set; }
        public string AuthorAbout { get; set; }
        public string AuthorImage { get; set; }
        public bool IsDeleted { get; set; }
        public List<AuthorFoods> AuthorFoods { get; set; }
    }
}
