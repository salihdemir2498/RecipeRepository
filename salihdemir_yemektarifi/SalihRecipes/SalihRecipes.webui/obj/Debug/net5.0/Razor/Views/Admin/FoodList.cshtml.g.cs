#pragma checksum "C:\Users\user\Desktop\RecipeRepository\salihdemir_yemektarifi\SalihRecipes\SalihRecipes.webui\Views\Admin\FoodList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6805e4375ff7cc9ce148e1accf1868a9e2a68dd3"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6805e4375ff7cc9ce148e1accf1868a9e2a68dd3", @"/Views/Admin/FoodList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e12fb04e0484f6f05fcbf46a81a99f036ac2773", @"/Views/_ViewImports.cshtml")]
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
            WriteLiteral("\r\n");
            DefineSection("Css", async() => {
                WriteLiteral("\r\n    <link href=\"https://cdn.datatables.net/1.12.1/css/dataTables.bootstrap5.min.css\" rel=\"stylesheet\" />\r\n");
            }
            );
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script src=""https://cdn.datatables.net/1.12.1/js/jquery.dataTables.min.js""></script>
    <script src=""https://cdn.datatables.net/1.12.1/js/dataTables.bootstrap5.min.js""></script>
    <script>
        $(document).ready(function () {
            $('#FoodList').DataTable(
                {
                    lengthMenu: [
                        [2, 5, 10, 20, 40, -1],
                        [2, 5, 10, 20, 40, ""Tümü""]
                    ],
                    language: {
                        url: ""//cdn.datatables.net/plug-ins/1.12.1/i18n/tr.json""
                    }
                }
            );
        });
    </script>
    ");
            }
            );
            WriteLiteral(@"
    <div class=""row"">
        <div class=""col-md-12"">
            <h1 class=""h3"">Admin Foods</h1>
            <hr />
            <a class=""btn btn-primary btn-sm mb-3"" href=""/admin/foods/create"">Add Foods</a>
            <table id=""FoodList"" class=""table table-bordered mt-3"">
                <thead>
                    <tr>
                        <td width=""30"">Id</td>
                        <td width=""100"">Image</td>
                        <td>Name</td>
                        <td width=""20"">Price</td>
                        <td width=""20"">Anasayfa</td>
                        <td width=""20"">Onaylı</td>
                        <td width=""20"">Slider</td>
                        <td width=""150""></td>
                    </tr>
                </thead>
                <tbody>

");
#nullable restore
#line 46 "C:\Users\user\Desktop\RecipeRepository\salihdemir_yemektarifi\SalihRecipes\SalihRecipes.webui\Views\Admin\FoodList.cshtml"
                     if (Model.Foods.Count() > 0)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\Users\user\Desktop\RecipeRepository\salihdemir_yemektarifi\SalihRecipes\SalihRecipes.webui\Views\Admin\FoodList.cshtml"
                         foreach (var item in Model.Foods)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 51 "C:\Users\user\Desktop\RecipeRepository\salihdemir_yemektarifi\SalihRecipes\SalihRecipes.webui\Views\Admin\FoodList.cshtml"
                               Write(item.FoodId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6805e4375ff7cc9ce148e1accf1868a9e2a68dd39066", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1946, "~/images/", 1946, 9, true);
#nullable restore
#line 52 "C:\Users\user\Desktop\RecipeRepository\salihdemir_yemektarifi\SalihRecipes\SalihRecipes.webui\Views\Admin\FoodList.cshtml"
AddHtmlAttributeValue("", 1955, item.FoodImage, 1955, 15, false);

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
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 53 "C:\Users\user\Desktop\RecipeRepository\salihdemir_yemektarifi\SalihRecipes\SalihRecipes.webui\Views\Admin\FoodList.cshtml"
                               Write(item.FoodName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 54 "C:\Users\user\Desktop\RecipeRepository\salihdemir_yemektarifi\SalihRecipes\SalihRecipes.webui\Views\Admin\FoodList.cshtml"
                               Write(item.FoodPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>\r\n");
#nullable restore
#line 56 "C:\Users\user\Desktop\RecipeRepository\salihdemir_yemektarifi\SalihRecipes\SalihRecipes.webui\Views\Admin\FoodList.cshtml"
                                     if (item.IsHome)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <i class=\"fa-solid fa-circle-check text-success\"></i>\r\n");
#nullable restore
#line 59 "C:\Users\user\Desktop\RecipeRepository\salihdemir_yemektarifi\SalihRecipes\SalihRecipes.webui\Views\Admin\FoodList.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <i class=\"fa-solid fa-circle-xmark text-danger\"></i>\r\n");
#nullable restore
#line 63 "C:\Users\user\Desktop\RecipeRepository\salihdemir_yemektarifi\SalihRecipes\SalihRecipes.webui\Views\Admin\FoodList.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </td>\r\n                                <td>\r\n");
#nullable restore
#line 66 "C:\Users\user\Desktop\RecipeRepository\salihdemir_yemektarifi\SalihRecipes\SalihRecipes.webui\Views\Admin\FoodList.cshtml"
                                     if (item.IsApproved)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <i class=\"fa-solid fa-circle-check text-success\"></i>\r\n");
#nullable restore
#line 69 "C:\Users\user\Desktop\RecipeRepository\salihdemir_yemektarifi\SalihRecipes\SalihRecipes.webui\Views\Admin\FoodList.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <i class=\"fa-solid fa-circle-xmark text-danger\"></i>\r\n");
#nullable restore
#line 73 "C:\Users\user\Desktop\RecipeRepository\salihdemir_yemektarifi\SalihRecipes\SalihRecipes.webui\Views\Admin\FoodList.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </td>\r\n                                <td>\r\n");
#nullable restore
#line 76 "C:\Users\user\Desktop\RecipeRepository\salihdemir_yemektarifi\SalihRecipes\SalihRecipes.webui\Views\Admin\FoodList.cshtml"
                                     if (item.IsSlider)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <i class=\"fa-solid fa-circle-check text-success\"></i>\r\n");
#nullable restore
#line 79 "C:\Users\user\Desktop\RecipeRepository\salihdemir_yemektarifi\SalihRecipes\SalihRecipes.webui\Views\Admin\FoodList.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <i class=\"fa-solid fa-circle-xmark text-danger\"></i>\r\n");
#nullable restore
#line 83 "C:\Users\user\Desktop\RecipeRepository\salihdemir_yemektarifi\SalihRecipes\SalihRecipes.webui\Views\Admin\FoodList.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </td>\r\n                                <td>\r\n                                    <a class=\"btn btn-primary btn-sm me-2\"");
            BeginWriteAttribute("href", " href=\"", 3794, "\"", 3826, 2);
            WriteAttributeValue("", 3801, "/admin/foods/", 3801, 13, true);
#nullable restore
#line 86 "C:\Users\user\Desktop\RecipeRepository\salihdemir_yemektarifi\SalihRecipes\SalihRecipes.webui\Views\Admin\FoodList.cshtml"
WriteAttributeValue("", 3814, item.FoodId, 3814, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a>\r\n\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6805e4375ff7cc9ce148e1accf1868a9e2a68dd315785", async() => {
                WriteLiteral("\r\n                                        <input type=\"hidden\" name=\"foodId\"");
                BeginWriteAttribute("value", " value=\"", 4016, "\"", 4036, 1);
#nullable restore
#line 89 "C:\Users\user\Desktop\RecipeRepository\salihdemir_yemektarifi\SalihRecipes\SalihRecipes.webui\Views\Admin\FoodList.cshtml"
WriteAttributeValue("", 4024, item.FoodId, 4024, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                        <button type=\"submit\" class=\"btn btn-danger btn-sm\">Delete</button>\r\n                                    ");
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
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 94 "C:\Users\user\Desktop\RecipeRepository\salihdemir_yemektarifi\SalihRecipes\SalihRecipes.webui\Views\Admin\FoodList.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 94 "C:\Users\user\Desktop\RecipeRepository\salihdemir_yemektarifi\SalihRecipes\SalihRecipes.webui\Views\Admin\FoodList.cshtml"
                         
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"alert alert-warning\">\r\n                            <h3>No Foods</h3>\r\n                        </div>\r\n");
#nullable restore
#line 101 "C:\Users\user\Desktop\RecipeRepository\salihdemir_yemektarifi\SalihRecipes\SalihRecipes.webui\Views\Admin\FoodList.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>");
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
