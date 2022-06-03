using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalihRecipes.business.Concrete
{
    public class JobManager
    {
        public static string MakeUrl(string url)
        {
            url = url.Replace("I", "i");
            url = url.Replace("ı", "i");
            url = url.Replace("İ", "i");
            url = url.Replace(" ", "-");
            url = url.Replace(".", "");
            url = url.ToLower();
            url = url.Replace("ö", "o");
            url = url.Replace("ü", "u");
            url = url.Replace("ç", "c");
            url = url.Replace("ğ", "g");
            url = url.Replace("ş", "s");

            return url;
        }

    }
}
