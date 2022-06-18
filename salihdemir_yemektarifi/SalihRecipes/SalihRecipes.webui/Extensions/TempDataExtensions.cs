using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalihRecipes.webui.Extensions
{
    public static class TempDataExtensions
    {
        public static void Put<T>(this ITempDataDictionary tempData, string key, T value) where T : class
        {
            tempData[key] = JsonConvert.SerializeObject(value); //tempdata içine bilgi attım
        }

        public static T Get<T>(this ITempDataDictionary tempData, string key) where T : class
        {
            //tempdata içerisindeki bilgiyi deserialize ederek geriye aldım.
            object o;

            tempData.TryGetValue(key, out o); //verdiğimiz key bilgisine göre bize objeyi getirecek
            return o == null ? null : JsonConvert.DeserializeObject<T>((string)o);
        }   
    }
}
