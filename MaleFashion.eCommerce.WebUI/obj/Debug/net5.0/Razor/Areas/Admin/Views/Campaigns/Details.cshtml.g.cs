#pragma checksum "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website (Back-End)\MaleFashion.eCommerce.Solution\MaleFashion.eCommerce.WebUI\Areas\Admin\Views\Campaigns\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "60f6819b19064265e7486f4f24c1a6b8956c5a1c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Campaigns_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/Campaigns/Details.cshtml")]
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
#line 1 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website (Back-End)\MaleFashion.eCommerce.Solution\MaleFashion.eCommerce.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using MaleFashion.eCommerce.WebUI.Models.DataContext;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website (Back-End)\MaleFashion.eCommerce.Solution\MaleFashion.eCommerce.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using MaleFashion.eCommerce.WebUI.Models.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website (Back-End)\MaleFashion.eCommerce.Solution\MaleFashion.eCommerce.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using MaleFashion.eCommerce.WebUI.Models.Entity.Membership;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website (Back-End)\MaleFashion.eCommerce.Solution\MaleFashion.eCommerce.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using MaleFashion.eCommerce.WebUI.Models.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website (Back-End)\MaleFashion.eCommerce.Solution\MaleFashion.eCommerce.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using MaleFashion.eCommerce.WebUI.AppCode.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website (Back-End)\MaleFashion.eCommerce.Solution\MaleFashion.eCommerce.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using MaleFashion.eCommerce.WebUI.Areas.Admin.Models.FormModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website (Back-End)\MaleFashion.eCommerce.Solution\MaleFashion.eCommerce.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using MaleFashion.eCommerce.WebUI.Areas.Admin.Models.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website (Back-End)\MaleFashion.eCommerce.Solution\MaleFashion.eCommerce.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website (Back-End)\MaleFashion.eCommerce.Solution\MaleFashion.eCommerce.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using Resources;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60f6819b19064265e7486f4f24c1a6b8956c5a1c", @"/Areas/Admin/Views/Campaigns/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ddde888a9575ddd5b75be920d5243e6a085a38d", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Campaigns_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MaleFashion.eCommerce.WebUI.Models.Entity.Campaign>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website (Back-End)\MaleFashion.eCommerce.Solution\MaleFashion.eCommerce.WebUI\Areas\Admin\Views\Campaigns\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"text-center\">Details</h1>\r\n\r\n<div>\r\n    <h4 class=\"text-center\">Campaign</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website (Back-End)\MaleFashion.eCommerce.Solution\MaleFashion.eCommerce.WebUI\Areas\Admin\Views\Campaigns\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website (Back-End)\MaleFashion.eCommerce.Solution\MaleFashion.eCommerce.WebUI\Areas\Admin\Views\Campaigns\Details.cshtml"
       Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website (Back-End)\MaleFashion.eCommerce.Solution\MaleFashion.eCommerce.WebUI\Areas\Admin\Views\Campaigns\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website (Back-End)\MaleFashion.eCommerce.Solution\MaleFashion.eCommerce.WebUI\Areas\Admin\Views\Campaigns\Details.cshtml"
       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website (Back-End)\MaleFashion.eCommerce.Solution\MaleFashion.eCommerce.WebUI\Areas\Admin\Views\Campaigns\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Discount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website (Back-End)\MaleFashion.eCommerce.Solution\MaleFashion.eCommerce.WebUI\Areas\Admin\Views\Campaigns\Details.cshtml"
       Write(Html.DisplayFor(model => model.Discount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website (Back-End)\MaleFashion.eCommerce.Solution\MaleFashion.eCommerce.WebUI\Areas\Admin\Views\Campaigns\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ExpiredDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website (Back-End)\MaleFashion.eCommerce.Solution\MaleFashion.eCommerce.WebUI\Areas\Admin\Views\Campaigns\Details.cshtml"
       Write(Html.DisplayFor(model => model.ExpiredDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website (Back-End)\MaleFashion.eCommerce.Solution\MaleFashion.eCommerce.WebUI\Areas\Admin\Views\Campaigns\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IsApproved));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website (Back-End)\MaleFashion.eCommerce.Solution\MaleFashion.eCommerce.WebUI\Areas\Admin\Views\Campaigns\Details.cshtml"
       Write(Html.DisplayFor(model => model.IsApproved));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 44 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website (Back-End)\MaleFashion.eCommerce.Solution\MaleFashion.eCommerce.WebUI\Areas\Admin\Views\Campaigns\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 47 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website (Back-End)\MaleFashion.eCommerce.Solution\MaleFashion.eCommerce.WebUI\Areas\Admin\Views\Campaigns\Details.cshtml"
       Write(Model.CreatedDate.ToString("dd.MM.yyyy HH:mm:ss"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 50 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website (Back-End)\MaleFashion.eCommerce.Solution\MaleFashion.eCommerce.WebUI\Areas\Admin\Views\Campaigns\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.UpdatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 53 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website (Back-End)\MaleFashion.eCommerce.Solution\MaleFashion.eCommerce.WebUI\Areas\Admin\Views\Campaigns\Details.cshtml"
       Write(Model.UpdatedDate?.ToString("dd.MM.yyyy HH:mm:ss"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div class=\"mb-5\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "60f6819b19064265e7486f4f24c1a6b8956c5a1c13078", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 58 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website (Back-End)\MaleFashion.eCommerce.Solution\MaleFashion.eCommerce.WebUI\Areas\Admin\Views\Campaigns\Details.cshtml"
                           WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "60f6819b19064265e7486f4f24c1a6b8956c5a1c15388", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MaleFashion.eCommerce.WebUI.Models.Entity.Campaign> Html { get; private set; }
    }
}
#pragma warning restore 1591
