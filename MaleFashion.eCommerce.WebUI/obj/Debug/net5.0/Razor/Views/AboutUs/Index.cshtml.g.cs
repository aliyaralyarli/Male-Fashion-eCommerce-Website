#pragma checksum "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website\MaleFashion.eCommerce.WebUI\Views\AboutUs\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1de845889164515bb8328d967a6030a7f5ffba6e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AboutUs_Index), @"mvc.1.0.view", @"/Views/AboutUs/Index.cshtml")]
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
#line 1 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website\MaleFashion.eCommerce.WebUI\Views\_ViewImports.cshtml"
using MaleFashion.eCommerce.WebUI.Models.DataContext;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website\MaleFashion.eCommerce.WebUI\Views\_ViewImports.cshtml"
using MaleFashion.eCommerce.WebUI.Models.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website\MaleFashion.eCommerce.WebUI\Views\_ViewImports.cshtml"
using MaleFashion.eCommerce.WebUI.Models.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website\MaleFashion.eCommerce.WebUI\Views\_ViewImports.cshtml"
using MaleFashion.eCommerce.WebUI.Models.FormModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website\MaleFashion.eCommerce.WebUI\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website\MaleFashion.eCommerce.WebUI\Views\_ViewImports.cshtml"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website\MaleFashion.eCommerce.WebUI\Views\_ViewImports.cshtml"
using MaleFashion.eCommerce.WebUI.AppCode.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website\MaleFashion.eCommerce.WebUI\Views\_ViewImports.cshtml"
using Resources;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1de845889164515bb8328d967a6030a7f5ffba6e", @"/Views/AboutUs/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a94fa528741e63c3bba64f7a4af4c1cd2905571", @"/Views/_ViewImports.cshtml")]
    public class Views_AboutUs_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AboutUsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "~/Views/Shared/Partials/_HappyClients.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website\MaleFashion.eCommerce.WebUI\Views\AboutUs\Index.cshtml"
  
    ViewData["Title"] = "About Us";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""breadcrumb-option"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""breadcrumb__text"">
                    <h4>About Us</h4>
                    <div class=""breadcrumb__links"">
                        <a href=""index-2.html"">Home</a>
                        <span>About Us</span>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>

<section class=""about spad"">
    <div class=""container"">
        <div class=""row"">
            ");
#nullable restore
#line 26 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website\MaleFashion.eCommerce.WebUI\Views\AboutUs\Index.cshtml"
       Write(await Component.InvokeAsync("AboutUsBanner"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 29 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website\MaleFashion.eCommerce.WebUI\Views\AboutUs\Index.cshtml"
             foreach (WhyWe item in Model.WhyWes)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-lg-4 col-md-4 col-sm-6\">\r\n                    <div class=\"about__item\">\r\n                        <h4>");
#nullable restore
#line 33 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website\MaleFashion.eCommerce.WebUI\Views\AboutUs\Index.cshtml"
                       Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                        <p>\r\n                            ");
#nullable restore
#line 35 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website\MaleFashion.eCommerce.WebUI\Views\AboutUs\Index.cshtml"
                       Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 39 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website\MaleFashion.eCommerce.WebUI\Views\AboutUs\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
    </div>
</section>

<section class=""counter spad"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-3 col-md-6 col-sm-6"">
                <div class=""counter__item"">
                    <div class=""counter__item__number"">
                        <h2 class=""cn_num"">");
#nullable restore
#line 50 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website\MaleFashion.eCommerce.WebUI\Views\AboutUs\Index.cshtml"
                                      Write(Model.HappyClients.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                    </div>
                    <span>Our <br />Clients</span>
                </div>
            </div>
            <div class=""col-lg-3 col-md-6 col-sm-6"">
                <div class=""counter__item"">
                    <div class=""counter__item__number"">
                        <h2 class=""cn_num"">");
#nullable restore
#line 58 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website\MaleFashion.eCommerce.WebUI\Views\AboutUs\Index.cshtml"
                                      Write(Model.Blogs.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                    </div>
                    <span>Total <br />Blogs</span>
                </div>
            </div>
            <div class=""col-lg-3 col-md-6 col-sm-6"">
                <div class=""counter__item"">
                    <div class=""counter__item__number"">
                        <h2 class=""cn_num"">");
#nullable restore
#line 66 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website\MaleFashion.eCommerce.WebUI\Views\AboutUs\Index.cshtml"
                                      Write(Model.Teams.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                    </div>
                    <span>Team <br />Personal</span>
                </div>
            </div>
            <div class=""col-lg-3 col-md-6 col-sm-6"">
                <div class=""counter__item"">
                    <div class=""counter__item__number"">
                        <h2 class=""cn_num"">");
#nullable restore
#line 74 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website\MaleFashion.eCommerce.WebUI\Views\AboutUs\Index.cshtml"
                                      Write(Model.TeamJobs.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                    </div>
                    <span>Team <br />Jobs</span>
                </div>
            </div>
        </div>
    </div>
</section>

<section class=""team spad"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""section-title"">
                    <span>Our Team</span>
                    <h2>Meet Our Team</h2>
                </div>
            </div>
        </div>
        <div class=""row"">
");
#nullable restore
#line 94 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website\MaleFashion.eCommerce.WebUI\Views\AboutUs\Index.cshtml"
             foreach (Team item in Model.Teams)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-lg-3 col-md-6 col-sm-6\">\r\n                    <div class=\"team__item\">\r\n                        <img style=\"height: 350px; object-fit: cover;\"");
            BeginWriteAttribute("src", " src=\"", 3301, "\"", 3345, 2);
            WriteAttributeValue("", 3307, "assets/images/about-us/", 3307, 23, true);
#nullable restore
#line 98 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website\MaleFashion.eCommerce.WebUI\Views\AboutUs\Index.cshtml"
WriteAttributeValue("", 3330, item.ImagePath, 3330, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 3346, "\"", 3352, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                        <h4>");
#nullable restore
#line 99 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website\MaleFashion.eCommerce.WebUI\Views\AboutUs\Index.cshtml"
                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 99 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website\MaleFashion.eCommerce.WebUI\Views\AboutUs\Index.cshtml"
                                  Write(item.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                        <span>");
#nullable restore
#line 100 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website\MaleFashion.eCommerce.WebUI\Views\AboutUs\Index.cshtml"
                         Write(item.TeamJob.JobName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 103 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website\MaleFashion.eCommerce.WebUI\Views\AboutUs\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</section>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "1de845889164515bb8328d967a6030a7f5ffba6e12781", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 108 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website\MaleFashion.eCommerce.WebUI\Views\AboutUs\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AboutUsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
