#pragma checksum "C:\Users\user\Desktop\RecipeRepository\salihdemir_yemektarifi\SalihRecipes\SalihRecipes.webui\Views\Food\Manage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8fb1a9116ae01dd735df5745a91e1279a3e022af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Food_Manage), @"mvc.1.0.view", @"/Views/Food/Manage.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 2 "C:\Users\user\Desktop\RecipeRepository\salihdemir_yemektarifi\SalihRecipes\SalihRecipes.webui\Views\_ViewImports.cshtml"
using SalihRecipes.webui.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\user\Desktop\RecipeRepository\salihdemir_yemektarifi\SalihRecipes\SalihRecipes.webui\Views\_ViewImports.cshtml"
using SalihRecipes.entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\user\Desktop\RecipeRepository\salihdemir_yemektarifi\SalihRecipes\SalihRecipes.webui\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\user\Desktop\RecipeRepository\salihdemir_yemektarifi\SalihRecipes\SalihRecipes.webui\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\user\Desktop\RecipeRepository\salihdemir_yemektarifi\SalihRecipes\SalihRecipes.webui\Views\_ViewImports.cshtml"
using SalihRecipes.webui.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\user\Desktop\RecipeRepository\salihdemir_yemektarifi\SalihRecipes\SalihRecipes.webui\Views\_ViewImports.cshtml"
using SalihRecipes.webui;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8fb1a9116ae01dd735df5745a91e1279a3e022af", @"/Views/Food/Manage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e12fb04e0484f6f05fcbf46a81a99f036ac2773", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Food_Manage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<User>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\t<h1>Üye Sayfası</h1>\r\n\r\n\t<div class=\"mt-3 row\">\r\n\t\t<div class=\"col-5\">\r\n\r\n\t\t\r\n");
#nullable restore
#line 9 "C:\Users\user\Desktop\RecipeRepository\salihdemir_yemektarifi\SalihRecipes\SalihRecipes.webui\Views\Food\Manage.cshtml"
         foreach (var item in Model)
		{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t<h5><span class=\"text-danger\">Kullanıcı Adı: </span>");
#nullable restore
#line 11 "C:\Users\user\Desktop\RecipeRepository\salihdemir_yemektarifi\SalihRecipes\SalihRecipes.webui\Views\Food\Manage.cshtml"
                                                       Write(item.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\t\t\t\r\n\t\t<h5><span class=\"text-danger\">Adı: </span>");
#nullable restore
#line 12 "C:\Users\user\Desktop\RecipeRepository\salihdemir_yemektarifi\SalihRecipes\SalihRecipes.webui\Views\Food\Manage.cshtml"
                                             Write(item.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\t\t\t\r\n\t\t<h5><span class=\"text-danger\">Soyadı: </span>");
#nullable restore
#line 13 "C:\Users\user\Desktop\RecipeRepository\salihdemir_yemektarifi\SalihRecipes\SalihRecipes.webui\Views\Food\Manage.cshtml"
                                                Write(item.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\t\t\t\r\n\t\t<h5><span class=\"text-danger\">Mail: </span>");
#nullable restore
#line 14 "C:\Users\user\Desktop\RecipeRepository\salihdemir_yemektarifi\SalihRecipes\SalihRecipes.webui\Views\Food\Manage.cshtml"
                                              Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\t\t\t\r\n");
#nullable restore
#line 15 "C:\Users\user\Desktop\RecipeRepository\salihdemir_yemektarifi\SalihRecipes\SalihRecipes.webui\Views\Food\Manage.cshtml"
		}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t</div>\r\n\r\n\t\t<div class=\"col-6\">\r\n\t\t\t<h3>Eklediği Yemekler</h3>\r\n\r\n\t\t</div>\r\n\t</div>\t\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<User>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591