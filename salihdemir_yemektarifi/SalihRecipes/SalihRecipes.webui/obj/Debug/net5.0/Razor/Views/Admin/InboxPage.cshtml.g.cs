#pragma checksum "C:\Users\user\Desktop\RecipeRepository\salihdemir_yemektarifi\SalihRecipes\SalihRecipes.webui\Views\Admin\InboxPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bef1f79071258ba578b9e2c060c14d0fd2effafa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_InboxPage), @"mvc.1.0.view", @"/Views/Admin/InboxPage.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bef1f79071258ba578b9e2c060c14d0fd2effafa", @"/Views/Admin/InboxPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e12fb04e0484f6f05fcbf46a81a99f036ac2773", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_InboxPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<link href=\"https://maxcdn.bootstrapcdn.com/font-awesome/4.3.0/css/font-awesome.min.css\" rel=\"stylesheet\" />\r\n\r\n<div");
            BeginWriteAttribute("class", " class=\"", 118, "\"", 126, 0);
            EndWriteAttribute();
            WriteLiteral(@">
    <div class=""row"">
        <div class=""col-md-12"">
            <div class=""card"">
                <div class=""card-body bg-primary text-white mailbox-widget pb-0"">
                    <h2 class=""text-white pb-3"">Your Mailbox</h2>
                    <ul class=""nav nav-tabs custom-tab border-bottom-0 mt-4"" id=""myTab"" role=""tablist"">
                        <li class=""nav-item"">
                            <a class=""nav-link active"" id=""inbox-tab"" data-toggle=""tab"" aria-controls=""inbox"" href=""#inbox"" role=""tab"" aria-selected=""true"">
                                <span class=""d-block d-md-none""><i class=""ti-email""></i></span>
                                <span class=""d-none d-md-block""> INBOX</span>
                            </a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" id=""delete-tab"" data-toggle=""tab"" aria-controls=""delete"" href=""#delete"" role=""tab"" aria-selected=""false"">
                              ");
            WriteLiteral(@"  <span class=""d-block d-md-none""><i class=""ti-trash""></i></span>
                                <span class=""d-none d-md-block"">DELETED</span>
                            </a>
                        </li>
                    </ul>
                </div>
          
                    ");
#nullable restore
#line 26 "C:\Users\user\Desktop\RecipeRepository\salihdemir_yemektarifi\SalihRecipes\SalihRecipes.webui\Views\Admin\InboxPage.cshtml"
               Write(await Html.PartialAsync("_inbox"));

#line default
#line hidden
#nullable disable
            WriteLiteral("  \r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
