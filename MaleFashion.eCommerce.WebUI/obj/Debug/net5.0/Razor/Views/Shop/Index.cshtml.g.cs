#pragma checksum "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website (Back-End)\MaleFashion.eCommerce.Solution\MaleFashion.eCommerce.WebUI\Views\Shop\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "026b2d6a26a3931d46383518fabaec5e697ab55e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop_Index), @"mvc.1.0.view", @"/Views/Shop/Index.cshtml")]
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
#line 1 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website (Back-End)\MaleFashion.eCommerce.Solution\MaleFashion.eCommerce.WebUI\Views\_ViewImports.cshtml"
using MaleFashion.eCommerce.WebUI.Models.DataContext;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website (Back-End)\MaleFashion.eCommerce.Solution\MaleFashion.eCommerce.WebUI\Views\_ViewImports.cshtml"
using MaleFashion.eCommerce.WebUI.Models.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website (Back-End)\MaleFashion.eCommerce.Solution\MaleFashion.eCommerce.WebUI\Views\_ViewImports.cshtml"
using MaleFashion.eCommerce.WebUI.Models.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website (Back-End)\MaleFashion.eCommerce.Solution\MaleFashion.eCommerce.WebUI\Views\_ViewImports.cshtml"
using MaleFashion.eCommerce.WebUI.Models.FormModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website (Back-End)\MaleFashion.eCommerce.Solution\MaleFashion.eCommerce.WebUI\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website (Back-End)\MaleFashion.eCommerce.Solution\MaleFashion.eCommerce.WebUI\Views\_ViewImports.cshtml"
using MaleFashion.eCommerce.WebUI.AppCode.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website (Back-End)\MaleFashion.eCommerce.Solution\MaleFashion.eCommerce.WebUI\Views\_ViewImports.cshtml"
using Resources;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"026b2d6a26a3931d46383518fabaec5e697ab55e", @"/Views/Shop/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c0fa6cd1a4c045b2eaec8feeaec764a117ea4d6", @"/Views/_ViewImports.cshtml")]
    public class Views_Shop_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShopViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website (Back-End)\MaleFashion.eCommerce.Solution\MaleFashion.eCommerce.WebUI\Views\Shop\Index.cshtml"
  
    ViewData["Title"] = "Shop";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""breadcrumb-option"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""breadcrumb__text"">
                    <h4>Shop</h4>
                    <div class=""breadcrumb__links"">
                        <a href=""index-2.html"">Home</a>
                        <span>Shop</span>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>

<section class=""shop spad"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-3"">
                <div class=""shop__sidebar"">
                    <div class=""shop__sidebar__search"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "026b2d6a26a3931d46383518fabaec5e697ab55e6647", async() => {
                WriteLiteral(@"
                            <input type=""text"" placeholder=""Search..."" />
                            <button type=""submit"">
                                <span class=""icon_search""></span>
                            </button>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                    <div class=""shop__sidebar__accordion"">
                        <div class=""accordion"" id=""accordionExample"">
                            <div class=""card"">
                                <div class=""card-heading"">
                                    <a data-toggle=""collapse"" data-target=""#collapseOne"">Categories</a>
                                </div>
                                <div id=""collapseOne""
                                     class=""collapse show""
                                     data-parent=""#accordionExample"">
                                    <div class=""card-body"">
                                        <div class=""shop__sidebar__categories"">
                                            <ul class=""nice-scroll"">
");
#nullable restore
#line 48 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website (Back-End)\MaleFashion.eCommerce.Solution\MaleFashion.eCommerce.WebUI\Views\Shop\Index.cshtml"
                                                 foreach (Category item in Model.Categories)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <li><a href=\"#\">");
#nullable restore
#line 50 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website (Back-End)\MaleFashion.eCommerce.Solution\MaleFashion.eCommerce.WebUI\Views\Shop\Index.cshtml"
                                                               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 51 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website (Back-End)\MaleFashion.eCommerce.Solution\MaleFashion.eCommerce.WebUI\Views\Shop\Index.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            </ul>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class=""card"">
                                <div class=""card-heading"">
                                    <a data-toggle=""collapse"" data-target=""#collapseTwo"">Branding</a>
                                </div>
                                <div id=""collapseTwo""
                                     class=""collapse show""
                                     data-parent=""#accordionExample"">
                                    <div class=""card-body"">
                                        <div class=""shop__sidebar__brand"">
                                            <ul>
");
#nullable restore
#line 67 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website (Back-End)\MaleFashion.eCommerce.Solution\MaleFashion.eCommerce.WebUI\Views\Shop\Index.cshtml"
                                                 foreach (Brand item in Model.Brands)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <li><a href=\"#\">");
#nullable restore
#line 69 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website (Back-End)\MaleFashion.eCommerce.Solution\MaleFashion.eCommerce.WebUI\Views\Shop\Index.cshtml"
                                                               Write(item.BrandName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 70 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website (Back-End)\MaleFashion.eCommerce.Solution\MaleFashion.eCommerce.WebUI\Views\Shop\Index.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            </ul>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class=""card"">
                                <div class=""card-heading"">
                                    <a data-toggle=""collapse"" data-target=""#collapseThree"">Filter Price</a>
                                </div>
                                <div id=""collapseThree""
                                     class=""collapse show""
                                     data-parent=""#accordionExample"">
                                    <div class=""card-body"">
                                        <div class=""shop__sidebar__price"">
                                            <ul>
                                                <li><a href=""#"">$0.00 - $50.00</a></li>
                                                <li><a href=""#"">$50.00 - $100.00</a>");
            WriteLiteral(@"</li>
                                                <li><a href=""#"">$100.00 - $150.00</a></li>
                                                <li><a href=""#"">$150.00 - $200.00</a></li>
                                                <li><a href=""#"">$200.00 - $250.00</a></li>
                                                <li><a href=""#"">250.00+</a></li>
                                            </ul>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class=""card"">
                                <div class=""card-heading"">
                                    <a data-toggle=""collapse"" data-target=""#collapseFour"">Size</a>
                                </div>
                                <div id=""collapseFour""
                                     class=""collapse show""
                                     data-parent=""#accordionExample"">
     ");
            WriteLiteral("                               <div class=\"card-body\">\r\n                                        <div class=\"shop__sidebar__size\">\r\n");
#nullable restore
#line 106 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website (Back-End)\MaleFashion.eCommerce.Solution\MaleFashion.eCommerce.WebUI\Views\Shop\Index.cshtml"
                                             foreach (Size item in Model.Sizes)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <label");
            BeginWriteAttribute("for", " for=\"", 5660, "\"", 5680, 1);
#nullable restore
#line 108 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website (Back-End)\MaleFashion.eCommerce.Solution\MaleFashion.eCommerce.WebUI\Views\Shop\Index.cshtml"
WriteAttributeValue("", 5666, item.SizeName, 5666, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                    ");
#nullable restore
#line 109 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website (Back-End)\MaleFashion.eCommerce.Solution\MaleFashion.eCommerce.WebUI\Views\Shop\Index.cshtml"
                                               Write(item.SizeName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    <input type=\"radio\"");
            BeginWriteAttribute("id", " id=\"", 5823, "\"", 5842, 1);
#nullable restore
#line 110 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website (Back-End)\MaleFashion.eCommerce.Solution\MaleFashion.eCommerce.WebUI\Views\Shop\Index.cshtml"
WriteAttributeValue("", 5828, item.SizeName, 5828, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                                </label>\r\n");
#nullable restore
#line 112 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website (Back-End)\MaleFashion.eCommerce.Solution\MaleFashion.eCommerce.WebUI\Views\Shop\Index.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class=""card"">
                                <div class=""card-heading"">
                                    <a data-toggle=""collapse"" data-target=""#collapseFive"">Colors</a>
                                </div>
                                <div id=""collapseFive""
                                     class=""collapse show""
                                     data-parent=""#accordionExample"">
                                    <div class=""card-body"">
                                        <div class=""shop__sidebar__color"">
");
#nullable restore
#line 126 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website (Back-End)\MaleFashion.eCommerce.Solution\MaleFashion.eCommerce.WebUI\Views\Shop\Index.cshtml"
                                             foreach (Color item in Model.Colors)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <label class=\"c-1\"");
            BeginWriteAttribute("style", " style=\"", 6891, "\"", 6933, 3);
            WriteAttributeValue("", 6899, "background-color:", 6899, 17, true);
#nullable restore
#line 128 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website (Back-End)\MaleFashion.eCommerce.Solution\MaleFashion.eCommerce.WebUI\Views\Shop\Index.cshtml"
WriteAttributeValue(" ", 6916, item.ColorName, 6917, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6932, ";", 6932, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                    <input type=\"radio\" id=\"sp-1\" />\r\n                                                </label>\r\n");
#nullable restore
#line 131 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website (Back-End)\MaleFashion.eCommerce.Solution\MaleFashion.eCommerce.WebUI\Views\Shop\Index.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class=""card"">
                                <div class=""card-heading"">
                                    <a data-toggle=""collapse"" data-target=""#collapseSix"">Tags</a>
                                </div>
                                <div id=""collapseSix""
                                     class=""collapse show""
                                     data-parent=""#accordionExample"">
                                    <div class=""card-body"">
                                        <div class=""shop__sidebar__tags"">
");
#nullable restore
#line 145 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website (Back-End)\MaleFashion.eCommerce.Solution\MaleFashion.eCommerce.WebUI\Views\Shop\Index.cshtml"
                                             foreach (ProductTag item in Model.ProductTags)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <a href=\"#\">");
#nullable restore
#line 147 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website (Back-End)\MaleFashion.eCommerce.Solution\MaleFashion.eCommerce.WebUI\Views\Shop\Index.cshtml"
                                                       Write(item.ProductTagName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 148 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website (Back-End)\MaleFashion.eCommerce.Solution\MaleFashion.eCommerce.WebUI\Views\Shop\Index.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-lg-9"">
                <div class=""shop__product__option"">
                    <div class=""row"">
                        <div class=""col-lg-6 col-md-6 col-sm-6"">
                            <div class=""shop__product__option__left"">
                                <p>Showing 1–12 of 126 results</p>
                            </div>
                        </div>
                        <div class=""col-lg-6 col-md-6 col-sm-6"">
                            <div class=""shop__product__option__right"">
                                <p>Sort by Price:</p>
                                <select>
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "026b2d6a26a3931d46383518fabaec5e697ab55e21732", async() => {
                WriteLiteral("Low To High");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "026b2d6a26a3931d46383518fabaec5e697ab55e22933", async() => {
                WriteLiteral("$0 - $55");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "026b2d6a26a3931d46383518fabaec5e697ab55e24131", async() => {
                WriteLiteral("$55 - $100");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </select>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                <div class=\"row\">\r\n");
#nullable restore
#line 178 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website (Back-End)\MaleFashion.eCommerce.Solution\MaleFashion.eCommerce.WebUI\Views\Shop\Index.cshtml"
                     foreach (DiscountProductViewModel item in Model.DiscountProductViewModel)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-lg-4 col-md-6 col-sm-6\">\r\n                            <div class=\"product__item\">\r\n                                <div class=\"product__item__pic set-bg\" data-setbg=\"assets/images/shop/");
#nullable restore
#line 182 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website (Back-End)\MaleFashion.eCommerce.Solution\MaleFashion.eCommerce.WebUI\Views\Shop\Index.cshtml"
                                                                                                 Write(item.ProductImages.FirstOrDefault(pi => pi.IsMain).ImagePath);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n");
#nullable restore
#line 183 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website (Back-End)\MaleFashion.eCommerce.Solution\MaleFashion.eCommerce.WebUI\Views\Shop\Index.cshtml"
                                     if (item.CampaignTitle != null)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <span class=\"label\" style=\"background-color: red;\">");
#nullable restore
#line 185 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website (Back-End)\MaleFashion.eCommerce.Solution\MaleFashion.eCommerce.WebUI\Views\Shop\Index.cshtml"
                                                                                      Write(item.CampaignTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 186 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website (Back-End)\MaleFashion.eCommerce.Solution\MaleFashion.eCommerce.WebUI\Views\Shop\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </div>\r\n                                <div class=\"product__item__text\">\r\n                                    <h6>");
#nullable restore
#line 189 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website (Back-End)\MaleFashion.eCommerce.Solution\MaleFashion.eCommerce.WebUI\Views\Shop\Index.cshtml"
                                   Write(item.Title.EllipseText(50));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h6>
                                    <a href=""#"" class=""add-cart"">+ Add To Cart</a>
                                    <div class=""rating"">
                                        <i class=""fa fa-star-o""></i>
                                        <i class=""fa fa-star-o""></i>
                                        <i class=""fa fa-star-o""></i>
                                        <i class=""fa fa-star-o""></i>
                                        <i class=""fa fa-star-o""></i>
                                    </div>
");
#nullable restore
#line 198 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website (Back-End)\MaleFashion.eCommerce.Solution\MaleFashion.eCommerce.WebUI\Views\Shop\Index.cshtml"
                                     if (item.PriceNew != null)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <h5 style=\"text-decoration: line-through; color: grey;\">$");
#nullable restore
#line 200 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website (Back-End)\MaleFashion.eCommerce.Solution\MaleFashion.eCommerce.WebUI\Views\Shop\Index.cshtml"
                                                                                            Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                        <h5>$");
#nullable restore
#line 201 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website (Back-End)\MaleFashion.eCommerce.Solution\MaleFashion.eCommerce.WebUI\Views\Shop\Index.cshtml"
                                        Write(item.PriceNew);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n");
#nullable restore
#line 202 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website (Back-End)\MaleFashion.eCommerce.Solution\MaleFashion.eCommerce.WebUI\Views\Shop\Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <h5>$");
#nullable restore
#line 205 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website (Back-End)\MaleFashion.eCommerce.Solution\MaleFashion.eCommerce.WebUI\Views\Shop\Index.cshtml"
                                        Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n");
#nullable restore
#line 206 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website (Back-End)\MaleFashion.eCommerce.Solution\MaleFashion.eCommerce.WebUI\Views\Shop\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    <div class=""product__color__select"">
                                        <label for=""pc-4"">
                                            <input type=""radio"" id=""pc-4"" />
                                        </label>
                                        <label class=""active black"" for=""pc-5"">
                                            <input type=""radio"" id=""pc-5"" />
                                        </label>
                                        <label class=""grey"" for=""pc-6"">
                                            <input type=""radio"" id=""pc-6"" />
                                        </label>
                                    </div>
                                </div>
                            </div>
                        </div>
");
#nullable restore
#line 221 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website (Back-End)\MaleFashion.eCommerce.Solution\MaleFashion.eCommerce.WebUI\Views\Shop\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
                <div class=""row"">
                    <div class=""col-lg-12"">
                        <div class=""product__pagination"">
                            <a class=""active"" href=""#"">1</a>
                            <a href=""#"">2</a>
                            <a href=""#"">3</a>
                            <span>...</span>
                            <a href=""#"">21</a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShopViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
