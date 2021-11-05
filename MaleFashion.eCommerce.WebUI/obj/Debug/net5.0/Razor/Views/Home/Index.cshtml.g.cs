#pragma checksum "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website (Back-End)\MaleFashion.eCommerce.Solution\MaleFashion.eCommerce.WebUI\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31acfe10f0e6dbc5323e9f2feae37fdcef5d0d44"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
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
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website (Back-End)\MaleFashion.eCommerce.Solution\MaleFashion.eCommerce.WebUI\Views\_ViewImports.cshtml"
using MaleFashion.eCommerce.WebUI.AppCode.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website (Back-End)\MaleFashion.eCommerce.Solution\MaleFashion.eCommerce.WebUI\Views\_ViewImports.cshtml"
using Resources;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31acfe10f0e6dbc5323e9f2feae37fdcef5d0d44", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a94fa528741e63c3bba64f7a4af4c1cd2905571", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShopViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website (Back-End)\MaleFashion.eCommerce.Solution\MaleFashion.eCommerce.WebUI\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home";

    var brands = Model.DiscountProductViewModel.Select(b => new
    {
        // BrandId
        Id = b.BrandId,
        BrandName = b.Brand
    })
    .Distinct();

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""hero"">
    <div class=""hero__slider owl-carousel"">
        <div class=""hero__items set-bg""
             data-setbg=""assets/images/index/hero-1.jpg"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-xl-5 col-lg-7 col-md-8"">
                        <div class=""hero__text"">
                            <h6>Summer Collection</h6>
                            <h2>Fall - Winter Collections 2030</h2>
                            <p>
                                A specialist label creating luxury essentials. Ethically
                                crafted with an unwavering commitment to exceptional
                                quality.
                            </p>
                            <a href=""#"" class=""primary-btn"">
                                Shop now <span class=""arrow_right""></span>
                            </a>
                            <div class=""hero__social"">
                               ");
            WriteLiteral(@" <a href=""#""><i class=""fa fa-facebook""></i></a>
                                <a href=""#""><i class=""fa fa-twitter""></i></a>
                                <a href=""#""><i class=""fa fa-pinterest""></i></a>
                                <a href=""#""><i class=""fa fa-instagram""></i></a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""hero__items set-bg""
             data-setbg=""assets/images/index/hero-2.jpg"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-xl-5 col-lg-7 col-md-8"">
                        <div class=""hero__text"">
                            <h6>Summer Collection</h6>
                            <h2>Fall - Winter Collections 2030</h2>
                            <p>
                                A specialist label creating luxury essentials. Ethically
                                crafted with a");
            WriteLiteral(@"n unwavering commitment to exceptional
                                quality.
                            </p>
                            <a href=""#"" class=""primary-btn"">
                                Shop now <span class=""arrow_right""></span>
                            </a>
                            <div class=""hero__social"">
                                <a href=""#""><i class=""fa fa-facebook""></i></a>
                                <a href=""#""><i class=""fa fa-twitter""></i></a>
                                <a href=""#""><i class=""fa fa-pinterest""></i></a>
                                <a href=""#""><i class=""fa fa-instagram""></i></a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>

<section class=""banner spad"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-7 offset-lg-4"">
                <div class=""banner__item"">");
            WriteLiteral("\r\n                    <div class=\"banner__item__pic\">\r\n                        <img src=\"assets/images/index/xbanner-1.jpg.pagespeed.ic.KmE-rIc0aQ.webp\"");
            BeginWriteAttribute("alt", "\r\n                             alt=\"", 3462, "\"", 3498, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                    </div>
                    <div class=""banner__item__text"">
                        <h2>Clothing Collections 2030</h2>
                        <a href=""#"">Shop now</a>
                    </div>
                </div>
            </div>
            <div class=""col-lg-5"">
                <div class=""banner__item banner__item--middle"">
                    <div class=""banner__item__pic"">
                        <img src=""assets/images/index/xbanner-2.jpg.pagespeed.ic.ISE4yV86cs.webp""");
            BeginWriteAttribute("alt", "\r\n                             alt=\"", 4019, "\"", 4055, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                    </div>
                    <div class=""banner__item__text"">
                        <h2>Accessories</h2>
                        <a href=""#"">Shop now</a>
                    </div>
                </div>
            </div>
            <div class=""col-lg-7"">
                <div class=""banner__item banner__item--last"">
                    <div class=""banner__item__pic"">
                        <img src=""assets/images/index/xbanner-3.jpg.pagespeed.ic.DPyiCAUR1d.webp""");
            BeginWriteAttribute("alt", "\r\n                             alt=\"", 4560, "\"", 4596, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                    </div>
                    <div class=""banner__item__text"">
                        <h2>Shoes Spring 2030</h2>
                        <a href=""#"">Shop now</a>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>

<section class=""product spad"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <ul class=""filter__controls"">
                    <li class=""active"" data-filter=""*"">All</li>
");
#nullable restore
#line 123 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website (Back-End)\MaleFashion.eCommerce.Solution\MaleFashion.eCommerce.WebUI\Views\Home\Index.cshtml"
                     foreach (var item in brands)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li data-filter=\".brand-");
#nullable restore
#line 125 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website (Back-End)\MaleFashion.eCommerce.Solution\MaleFashion.eCommerce.WebUI\Views\Home\Index.cshtml"
                                           Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 125 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website (Back-End)\MaleFashion.eCommerce.Solution\MaleFashion.eCommerce.WebUI\Views\Home\Index.cshtml"
                                                     Write(item.BrandName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 126 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website (Back-End)\MaleFashion.eCommerce.Solution\MaleFashion.eCommerce.WebUI\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </ul>\r\n            </div>\r\n        </div>\r\n        <div class=\"row product__filter\">\r\n");
#nullable restore
#line 131 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website (Back-End)\MaleFashion.eCommerce.Solution\MaleFashion.eCommerce.WebUI\Views\Home\Index.cshtml"
             foreach (DiscountProductViewModel item in Model.DiscountProductViewModel)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div");
            BeginWriteAttribute("class", " class=\"", 5539, "\"", 5615, 8);
            WriteAttributeValue("", 5547, "col-lg-3", 5547, 8, true);
            WriteAttributeValue(" ", 5555, "col-md-6", 5556, 9, true);
            WriteAttributeValue(" ", 5564, "col-sm-6", 5565, 9, true);
            WriteAttributeValue(" ", 5573, "col-md-6", 5574, 9, true);
            WriteAttributeValue(" ", 5582, "col-sm-6", 5583, 9, true);
            WriteAttributeValue(" ", 5591, "mix", 5592, 4, true);
            WriteAttributeValue(" ", 5595, "brand-", 5596, 7, true);
#nullable restore
#line 133 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website (Back-End)\MaleFashion.eCommerce.Solution\MaleFashion.eCommerce.WebUI\Views\Home\Index.cshtml"
WriteAttributeValue("", 5602, item.BrandId, 5602, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <div class=\"product__item\">\r\n                        <div class=\"product__item__pic set-bg\" data-setbg=\"assets/images/shop/");
#nullable restore
#line 135 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website (Back-End)\MaleFashion.eCommerce.Solution\MaleFashion.eCommerce.WebUI\Views\Home\Index.cshtml"
                                                                                         Write(item.ProductImages.FirstOrDefault(pi => pi.IsMain).ImagePath);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n");
#nullable restore
#line 136 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website (Back-End)\MaleFashion.eCommerce.Solution\MaleFashion.eCommerce.WebUI\Views\Home\Index.cshtml"
                             if (item.CampaignTitle != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span class=\"label\" style=\"background-color: red;\">");
#nullable restore
#line 138 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website (Back-End)\MaleFashion.eCommerce.Solution\MaleFashion.eCommerce.WebUI\Views\Home\Index.cshtml"
                                                                              Write(item.CampaignTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 139 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website (Back-End)\MaleFashion.eCommerce.Solution\MaleFashion.eCommerce.WebUI\Views\Home\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                        <div class=\"product__item__text\">\r\n                            <h6>");
#nullable restore
#line 142 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website (Back-End)\MaleFashion.eCommerce.Solution\MaleFashion.eCommerce.WebUI\Views\Home\Index.cshtml"
                           Write(item.Title.EllipseText(50));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n");
#nullable restore
#line 143 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website (Back-End)\MaleFashion.eCommerce.Solution\MaleFashion.eCommerce.WebUI\Views\Home\Index.cshtml"
                             if (item.PriceNew != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <h5 style=\"text-decoration: line-through; color: grey;\">$");
#nullable restore
#line 145 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website (Back-End)\MaleFashion.eCommerce.Solution\MaleFashion.eCommerce.WebUI\Views\Home\Index.cshtml"
                                                                                    Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                <h5>$");
#nullable restore
#line 146 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website (Back-End)\MaleFashion.eCommerce.Solution\MaleFashion.eCommerce.WebUI\Views\Home\Index.cshtml"
                                Write(item.PriceNew);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n");
#nullable restore
#line 147 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website (Back-End)\MaleFashion.eCommerce.Solution\MaleFashion.eCommerce.WebUI\Views\Home\Index.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <h5>$");
#nullable restore
#line 150 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website (Back-End)\MaleFashion.eCommerce.Solution\MaleFashion.eCommerce.WebUI\Views\Home\Index.cshtml"
                                Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n");
#nullable restore
#line 151 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website (Back-End)\MaleFashion.eCommerce.Solution\MaleFashion.eCommerce.WebUI\Views\Home\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 155 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website (Back-End)\MaleFashion.eCommerce.Solution\MaleFashion.eCommerce.WebUI\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</section>\r\n\r\n");
#nullable restore
#line 160 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website (Back-End)\MaleFashion.eCommerce.Solution\MaleFashion.eCommerce.WebUI\Views\Home\Index.cshtml"
Write(await Component.InvokeAsync("IndexBlog"));

#line default
#line hidden
#nullable disable
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
