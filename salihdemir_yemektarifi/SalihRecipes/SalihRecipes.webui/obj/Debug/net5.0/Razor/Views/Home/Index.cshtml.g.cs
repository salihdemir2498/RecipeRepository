#pragma checksum "C:\Users\user\Desktop\salihdemir_yemektarifi\SalihRecipes\SalihRecipes.webui\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "12c1a59f1b8d9b9398bfb6924d67beb38dc1691b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\user\Desktop\salihdemir_yemektarifi\SalihRecipes\SalihRecipes.webui\Views\_ViewImports.cshtml"
using SalihRecipes.webui.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\user\Desktop\salihdemir_yemektarifi\SalihRecipes\SalihRecipes.webui\Views\_ViewImports.cshtml"
using SalihRecipes.entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\user\Desktop\salihdemir_yemektarifi\SalihRecipes\SalihRecipes.webui\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12c1a59f1b8d9b9398bfb6924d67beb38dc1691b", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0251a68504e82eb818963b37b72ccd4f32bc1b93", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FoodListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-block w-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-10 m-auto\">\r\n        <div id=\"carouselExampleCaptions\" class=\"carousel slide\" data-bs-ride=\"carousel\">\r\n            <div class=\"carousel-indicators\">\r\n\r\n\r\n");
#nullable restore
#line 9 "C:\Users\user\Desktop\salihdemir_yemektarifi\SalihRecipes\SalihRecipes.webui\Views\Home\Index.cshtml"
                     if (Model.Foods.Count < 10)
                    {

                    
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\user\Desktop\salihdemir_yemektarifi\SalihRecipes\SalihRecipes.webui\Views\Home\Index.cshtml"
                             for (int i = 0; i < Model.Foods.Count; i++)
                            {
                                if (i == 0)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <button type=\"button\" data-bs-target=\"#carouselExampleCaptions\" data-bs-slide-to=\"");
#nullable restore
#line 17 "C:\Users\user\Desktop\salihdemir_yemektarifi\SalihRecipes\SalihRecipes.webui\Views\Home\Index.cshtml"
                                                                                                                 Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"active\" aria-current=\"true\"");
            BeginWriteAttribute("aria-label", " aria-label=\"", 663, "\"", 688, 2);
            WriteAttributeValue("", 676, "Slide", 676, 5, true);
#nullable restore
#line 17 "C:\Users\user\Desktop\salihdemir_yemektarifi\SalihRecipes\SalihRecipes.webui\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 681, i+1, 682, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></button>\r\n");
#nullable restore
#line 18 "C:\Users\user\Desktop\salihdemir_yemektarifi\SalihRecipes\SalihRecipes.webui\Views\Home\Index.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <button type=\"button\" data-bs-target=\"#carouselExampleCaptions\" data-bs-slide-to=\"");
#nullable restore
#line 21 "C:\Users\user\Desktop\salihdemir_yemektarifi\SalihRecipes\SalihRecipes.webui\Views\Home\Index.cshtml"
                                                                                                                 Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"");
            BeginWriteAttribute("aria-label", " aria-label=\"", 930, "\"", 957, 2);
            WriteAttributeValue("", 943, "Slide", 943, 5, true);
#nullable restore
#line 21 "C:\Users\user\Desktop\salihdemir_yemektarifi\SalihRecipes\SalihRecipes.webui\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 948, i + 1, 949, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></button>\r\n");
#nullable restore
#line 22 "C:\Users\user\Desktop\salihdemir_yemektarifi\SalihRecipes\SalihRecipes.webui\Views\Home\Index.cshtml"

                                }
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\user\Desktop\salihdemir_yemektarifi\SalihRecipes\SalihRecipes.webui\Views\Home\Index.cshtml"
                             
                        
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                \r\n            </div>\r\n            <div class=\"carousel-inner mb-5\">\r\n\r\n");
#nullable restore
#line 31 "C:\Users\user\Desktop\salihdemir_yemektarifi\SalihRecipes\SalihRecipes.webui\Views\Home\Index.cshtml"
                 if (Model.Foods.Count != 0)
                {
                    int b = 0;
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\user\Desktop\salihdemir_yemektarifi\SalihRecipes\SalihRecipes.webui\Views\Home\Index.cshtml"
                     foreach (var a in Model.Foods)
                    {

                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\user\Desktop\salihdemir_yemektarifi\SalihRecipes\SalihRecipes.webui\Views\Home\Index.cshtml"
                         for (int i = 0; i < Model.Foods.Count; i++)
                        {
                            if (b == 1)
                            {
                                i = 1;
                            }
                            if (b == 2)
                            {
                                i = 2;
                            }

                            if (i == 0)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"carousel-item active\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "12c1a59f1b8d9b9398bfb6924d67beb38dc1691b8889", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1920, "~/images/", 1920, 9, true);
#nullable restore
#line 51 "C:\Users\user\Desktop\salihdemir_yemektarifi\SalihRecipes\SalihRecipes.webui\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 1929, a.FoodImage, 1929, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                                    <div class=\"carousel-caption d-none d-md-block\">\r\n                                        <p style=\"font-size: 50px; color: rgb(254, 242, 0); font-family: \'Akshar\', sans-serif; \"><strong>");
#nullable restore
#line 54 "C:\Users\user\Desktop\salihdemir_yemektarifi\SalihRecipes\SalihRecipes.webui\Views\Home\Index.cshtml"
                                                                                                                                    Write(a.FoodDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></p>\r\n                                    </div>\r\n                                </div>\r\n");
#nullable restore
#line 57 "C:\Users\user\Desktop\salihdemir_yemektarifi\SalihRecipes\SalihRecipes.webui\Views\Home\Index.cshtml"
                                break;
                            }

                            else if (i == 1)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"carousel-item\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "12c1a59f1b8d9b9398bfb6924d67beb38dc1691b11650", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2566, "~/images/", 2566, 9, true);
#nullable restore
#line 63 "C:\Users\user\Desktop\salihdemir_yemektarifi\SalihRecipes\SalihRecipes.webui\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 2575, a.FoodImage, 2575, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                                    <div class=\"carousel-caption d-none d-md-block\">\r\n                                        <p style=\"font-size: 50px; color: rgb(254, 242, 0); font-family: \'Akshar\', sans-serif; \"><strong>");
#nullable restore
#line 66 "C:\Users\user\Desktop\salihdemir_yemektarifi\SalihRecipes\SalihRecipes.webui\Views\Home\Index.cshtml"
                                                                                                                                    Write(a.FoodDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></p>\r\n                                    </div>\r\n                                </div>\r\n");
#nullable restore
#line 69 "C:\Users\user\Desktop\salihdemir_yemektarifi\SalihRecipes\SalihRecipes.webui\Views\Home\Index.cshtml"
                                break;
                            }
                            else if (i == 2)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"carousel-item\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "12c1a59f1b8d9b9398bfb6924d67beb38dc1691b14410", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3210, "~/images/", 3210, 9, true);
#nullable restore
#line 74 "C:\Users\user\Desktop\salihdemir_yemektarifi\SalihRecipes\SalihRecipes.webui\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 3219, a.FoodImage, 3219, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                                    <div class=\"carousel-caption d-none d-md-block\">\r\n                                        <p style=\"font-size: 50px; color: rgb(254, 242, 0); font-family: \'Akshar\', sans-serif; \"><strong>");
#nullable restore
#line 77 "C:\Users\user\Desktop\salihdemir_yemektarifi\SalihRecipes\SalihRecipes.webui\Views\Home\Index.cshtml"
                                                                                                                                    Write(a.FoodDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></p>\r\n                                    </div>\r\n                                </div>\r\n");
#nullable restore
#line 80 "C:\Users\user\Desktop\salihdemir_yemektarifi\SalihRecipes\SalihRecipes.webui\Views\Home\Index.cshtml"
                            }
                            else if (i == 3)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"carousel-item\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "12c1a59f1b8d9b9398bfb6924d67beb38dc1691b17130", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3814, "~/images/", 3814, 9, true);
#nullable restore
#line 84 "C:\Users\user\Desktop\salihdemir_yemektarifi\SalihRecipes\SalihRecipes.webui\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 3823, a.FoodImage, 3823, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                                    <div class=\"carousel-caption d-none d-md-block\">\r\n                                        <p style=\"font-size: 50px; color: rgb(254, 242, 0); font-family: \'Akshar\', sans-serif; \"><strong>");
#nullable restore
#line 87 "C:\Users\user\Desktop\salihdemir_yemektarifi\SalihRecipes\SalihRecipes.webui\Views\Home\Index.cshtml"
                                                                                                                                    Write(a.FoodDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></p>\r\n                                    </div>\r\n                                </div>\r\n");
#nullable restore
#line 90 "C:\Users\user\Desktop\salihdemir_yemektarifi\SalihRecipes\SalihRecipes.webui\Views\Home\Index.cshtml"
                            }
                            else if (i == 4)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"carousel-item\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "12c1a59f1b8d9b9398bfb6924d67beb38dc1691b19850", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4418, "~/images/", 4418, 9, true);
#nullable restore
#line 94 "C:\Users\user\Desktop\salihdemir_yemektarifi\SalihRecipes\SalihRecipes.webui\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 4427, a.FoodImage, 4427, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                                    <div class=\"carousel-caption d-none d-md-block\">\r\n                                        <p style=\"font-size: 50px; color: rgb(254, 242, 0); font-family: \'Akshar\', sans-serif; \"><strong>");
#nullable restore
#line 97 "C:\Users\user\Desktop\salihdemir_yemektarifi\SalihRecipes\SalihRecipes.webui\Views\Home\Index.cshtml"
                                                                                                                                    Write(a.FoodDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></p>\r\n                                    </div>\r\n                                </div>\r\n");
#nullable restore
#line 100 "C:\Users\user\Desktop\salihdemir_yemektarifi\SalihRecipes\SalihRecipes.webui\Views\Home\Index.cshtml"
                            }

                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 102 "C:\Users\user\Desktop\salihdemir_yemektarifi\SalihRecipes\SalihRecipes.webui\Views\Home\Index.cshtml"
                         
                        b++;


                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 106 "C:\Users\user\Desktop\salihdemir_yemektarifi\SalihRecipes\SalihRecipes.webui\Views\Home\Index.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

            </div>
                    

          

            <button class=""carousel-control-prev"" type=""button"" data-bs-target=""#carouselExampleCaptions"" data-bs-slide=""prev"">
                <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
                <span class=""visually-hidden"">Previous</span>
            </button>
            <button class=""carousel-control-next"" type=""button"" data-bs-target=""#carouselExampleCaptions"" data-bs-slide=""next"">
                <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
                <span class=""visually-hidden"">Next</span>
            </button>

        </div>
    </div>
</div>



");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    <script src=\"https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js\" integrity=\"sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p\" crossorigin=\"anonymous\"></script>\r\n");
                WriteLiteral("    <script src=\"https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.min.js\" integrity=\"sha384-QJHtvGhmr9XOIpI6YVutG+2QOK9T+ZnN4kzFN1RtK3zEFEIsxhlmWl5/YESvpZ13\" crossorigin=\"anonymous\"></script>\r\n");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FoodListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
