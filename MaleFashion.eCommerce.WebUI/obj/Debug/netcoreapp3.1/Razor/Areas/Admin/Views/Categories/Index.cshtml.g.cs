#pragma checksum "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website (Back-End)\MaleFashion.eCommerce.Solution\MaleFashion.eCommerce.WebUI\Areas\Admin\Views\Categories\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99382cd22b4a4c9f18a9b45b7c4e5d85daa327bd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Categories_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Categories/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99382cd22b4a4c9f18a9b45b7c4e5d85daa327bd", @"/Areas/Admin/Views/Categories/Index.cshtml")]
    public class Areas_Admin_Views_Categories_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MaleFashion.eCommerce.WebUI.Models.Entity.Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website (Back-End)\MaleFashion.eCommerce.Solution\MaleFashion.eCommerce.WebUI\Areas\Admin\Views\Categories\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website (Back-End)\MaleFashion.eCommerce.Solution\MaleFashion.eCommerce.WebUI\Areas\Admin\Views\Categories\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website (Back-End)\MaleFashion.eCommerce.Solution\MaleFashion.eCommerce.WebUI\Areas\Admin\Views\Categories\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website (Back-End)\MaleFashion.eCommerce.Solution\MaleFashion.eCommerce.WebUI\Areas\Admin\Views\Categories\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.UpdatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website (Back-End)\MaleFashion.eCommerce.Solution\MaleFashion.eCommerce.WebUI\Areas\Admin\Views\Categories\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DeletedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 31 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website (Back-End)\MaleFashion.eCommerce.Solution\MaleFashion.eCommerce.WebUI\Areas\Admin\Views\Categories\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 34 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website (Back-End)\MaleFashion.eCommerce.Solution\MaleFashion.eCommerce.WebUI\Areas\Admin\Views\Categories\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website (Back-End)\MaleFashion.eCommerce.Solution\MaleFashion.eCommerce.WebUI\Areas\Admin\Views\Categories\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website (Back-End)\MaleFashion.eCommerce.Solution\MaleFashion.eCommerce.WebUI\Areas\Admin\Views\Categories\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.UpdatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website (Back-End)\MaleFashion.eCommerce.Solution\MaleFashion.eCommerce.WebUI\Areas\Admin\Views\Categories\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DeletedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1210, "\"", 1233, 1);
#nullable restore
#line 46 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website (Back-End)\MaleFashion.eCommerce.Solution\MaleFashion.eCommerce.WebUI\Areas\Admin\Views\Categories\Index.cshtml"
WriteAttributeValue("", 1225, item.Id, 1225, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n                <a asp-action=\"Details\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1286, "\"", 1309, 1);
#nullable restore
#line 47 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website (Back-End)\MaleFashion.eCommerce.Solution\MaleFashion.eCommerce.WebUI\Areas\Admin\Views\Categories\Index.cshtml"
WriteAttributeValue("", 1301, item.Id, 1301, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a> |\r\n                <a asp-action=\"Delete\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1364, "\"", 1387, 1);
#nullable restore
#line 48 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website (Back-End)\MaleFashion.eCommerce.Solution\MaleFashion.eCommerce.WebUI\Areas\Admin\Views\Categories\Index.cshtml"
WriteAttributeValue("", 1379, item.Id, 1379, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 51 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website (Back-End)\MaleFashion.eCommerce.Solution\MaleFashion.eCommerce.WebUI\Areas\Admin\Views\Categories\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MaleFashion.eCommerce.WebUI.Models.Entity.Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
