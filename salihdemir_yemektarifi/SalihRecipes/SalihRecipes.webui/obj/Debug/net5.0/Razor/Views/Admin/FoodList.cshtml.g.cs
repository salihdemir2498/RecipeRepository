#pragma checksum "C:\Users\user\Desktop\RecipeRepository\salihdemir_yemektarifi\SalihRecipes\SalihRecipes.webui\Views\Admin\FoodList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "85515476c2dae259223452fda0fa0335f030a115"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_FoodList), @"mvc.1.0.view", @"/Views/Admin/FoodList.cshtml")]
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
#line 1 "C:\Users\user\Desktop\RecipeRepository\salihdemir_yemektarifi\SalihRecipes\SalihRecipes.webui\Views\_ViewImports.cshtml"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85515476c2dae259223452fda0fa0335f030a115", @"/Views/Admin/FoodList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0251a68504e82eb818963b37b72ccd4f32bc1b93", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_FoodList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FoodListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("80"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("80"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/admin/deletefood"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-md-12"">
        <h1 class=""h3"">Admin Foods</h1>
        <hr />
        <a class=""btn btn-primary btn-sm"" href=""/admin/foods/create"">Add Foods</a>
        <table class=""table table-sm table-bordered mt-3"">
            <thead>
                <tr>
                    <td width=""30"">Id</td>
                    <td width=""100"">Image</td>
                    <td>Name</td>
                    <td width=""20"">Price</td>
                    <td width=""20"">Anasayfa</td>
                    <td width=""20"">Onaylı</td>
                    <td width=""20"">Slider</td>
                    <td width=""150"">Actions</td>
                </tr>
            </thead>
            <tbody>

");
#nullable restore
#line 23 "C:\Users\user\Desktop\RecipeRepository\salihdemir_yemektarifi\SalihRecipes\SalihRecipes.webui\Views\Admin\FoodList.cshtml"
                 if (Model.Foods.Count() > 0)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\user\Desktop\RecipeRepository\salihdemir_yemektarifi\SalihRecipes\SalihRecipes.webui\Views\Admin\FoodList.cshtml"
                     foreach (var item in Model.Foods)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 28 "C:\Users\user\Desktop\RecipeRepository\salihdemir_yemektarifi\SalihRecipes\SalihRecipes.webui\Views\Admin\FoodList.cshtml"
                   Write(item.FoodId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "85515476c2dae259223452fda0fa0335f030a1157160", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1002, "~/images/", 1002, 9, true);
#nullable restore
#line 29 "C:\Users\user\Desktop\RecipeRepository\salihdemir_yemektarifi\SalihRecipes\SalihRecipes.webui\Views\Admin\FoodList.cshtml"
AddHtmlAttributeValue("", 1011, item.FoodImage, 1011, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 30 "C:\Users\user\Desktop\RecipeRepository\salihdemir_yemektarifi\SalihRecipes\SalihRecipes.webui\Views\Admin\FoodList.cshtml"
                   Write(item.FoodName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 31 "C:\Users\user\Desktop\RecipeRepository\salihdemir_yemektarifi\SalihRecipes\SalihRecipes.webui\Views\Admin\FoodList.cshtml"
                   Write(item.FoodPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n");
#nullable restore
#line 33 "C:\Users\user\Desktop\RecipeRepository\salihdemir_yemektarifi\SalihRecipes\SalihRecipes.webui\Views\Admin\FoodList.cshtml"
                         if (item.IsHome)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <i class=\"fa-solid fa-circle-check text-success\"></i>\r\n");
#nullable restore
#line 36 "C:\Users\user\Desktop\RecipeRepository\salihdemir_yemektarifi\SalihRecipes\SalihRecipes.webui\Views\Admin\FoodList.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <i class=\"fa-solid fa-circle-xmark text-danger\"></i>\r\n");
#nullable restore
#line 40 "C:\Users\user\Desktop\RecipeRepository\salihdemir_yemektarifi\SalihRecipes\SalihRecipes.webui\Views\Admin\FoodList.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                    <td>\r\n");
#nullable restore
#line 43 "C:\Users\user\Desktop\RecipeRepository\salihdemir_yemektarifi\SalihRecipes\SalihRecipes.webui\Views\Admin\FoodList.cshtml"
                         if (item.IsApproved)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <i class=\"fa-solid fa-circle-check text-success\"></i>\r\n");
#nullable restore
#line 46 "C:\Users\user\Desktop\RecipeRepository\salihdemir_yemektarifi\SalihRecipes\SalihRecipes.webui\Views\Admin\FoodList.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <i class=\"fa-solid fa-circle-xmark text-danger\"></i>\r\n");
#nullable restore
#line 50 "C:\Users\user\Desktop\RecipeRepository\salihdemir_yemektarifi\SalihRecipes\SalihRecipes.webui\Views\Admin\FoodList.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                    <td>\r\n");
#nullable restore
#line 53 "C:\Users\user\Desktop\RecipeRepository\salihdemir_yemektarifi\SalihRecipes\SalihRecipes.webui\Views\Admin\FoodList.cshtml"
                         if (item.IsSlider)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <i class=\"fa-solid fa-circle-check text-success\"></i>\r\n");
#nullable restore
#line 56 "C:\Users\user\Desktop\RecipeRepository\salihdemir_yemektarifi\SalihRecipes\SalihRecipes.webui\Views\Admin\FoodList.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <i class=\"fa-solid fa-circle-xmark text-danger\"></i>\r\n");
#nullable restore
#line 60 "C:\Users\user\Desktop\RecipeRepository\salihdemir_yemektarifi\SalihRecipes\SalihRecipes.webui\Views\Admin\FoodList.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                    <td>\r\n                        <a class=\"btn btn-primary btn-sm me-2\"");
            BeginWriteAttribute("href", " href=\"", 2442, "\"", 2474, 2);
            WriteAttributeValue("", 2449, "/admin/foods/", 2449, 13, true);
#nullable restore
#line 63 "C:\Users\user\Desktop\RecipeRepository\salihdemir_yemektarifi\SalihRecipes\SalihRecipes.webui\Views\Admin\FoodList.cshtml"
WriteAttributeValue("", 2462, item.FoodId, 2462, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a>\r\n\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "85515476c2dae259223452fda0fa0335f030a11513435", async() => {
                WriteLiteral("\r\n                            <input type=\"hidden\" name=\"foodId\"");
                BeginWriteAttribute("value", " value=\"", 2640, "\"", 2660, 1);
#nullable restore
#line 66 "C:\Users\user\Desktop\RecipeRepository\salihdemir_yemektarifi\SalihRecipes\SalihRecipes.webui\Views\Admin\FoodList.cshtml"
WriteAttributeValue("", 2648, item.FoodId, 2648, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                            <button type=\"submit\" class=\"btn btn-danger btn-sm\">Delete</button>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 71 "C:\Users\user\Desktop\RecipeRepository\salihdemir_yemektarifi\SalihRecipes\SalihRecipes.webui\Views\Admin\FoodList.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 71 "C:\Users\user\Desktop\RecipeRepository\salihdemir_yemektarifi\SalihRecipes\SalihRecipes.webui\Views\Admin\FoodList.cshtml"
                     
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"alert alert-warning\">\r\n                        <h3>No Foods</h3>\r\n                    </div>\r\n");
#nullable restore
#line 78 "C:\Users\user\Desktop\RecipeRepository\salihdemir_yemektarifi\SalihRecipes\SalihRecipes.webui\Views\Admin\FoodList.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </tbody>\r\n        </table>\r\n    </div>\r\n</div>");
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
