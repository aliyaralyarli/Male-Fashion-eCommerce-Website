#pragma checksum "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website (Back-End)\MaleFashion.eCommerce.Solution\MaleFashion.eCommerce.WebUI\Views\Chat\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "18ba46dfd9a894bde2df853aad1587af58ff4d85"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Chat_Index), @"mvc.1.0.view", @"/Views/Chat/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18ba46dfd9a894bde2df853aad1587af58ff4d85", @"/Views/Chat/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c0fa6cd1a4c045b2eaec8feeaec764a117ea4d6", @"/Views/_ViewImports.cshtml")]
    public class Views_Chat_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/sources/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/sources/js/jquery-3.3.1.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/libs/microsoft-signalr/signalr.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\User\Desktop\Male-Fashion-eCommerce-Website (Back-End)\MaleFashion.eCommerce.Solution\MaleFashion.eCommerce.WebUI\Views\Chat\Index.cshtml"
  
    ViewData["Title"] = "Chat SignalR";
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "18ba46dfd9a894bde2df853aad1587af58ff4d857389", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1, shrink-to-fit=no\">\r\n    <title>\r\n        SignalR Application\r\n    </title>\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "18ba46dfd9a894bde2df853aad1587af58ff4d857847", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

    <style>
        .input-group.input-group-multiline {
            flex-direction: column;
            margin-bottom: 0 !important;
        }

            .input-group.input-group-multiline > .input-group-prepend > .input-group-text {
                width: 100%;
                border-radius: .2rem .2rem 0 0;
                margin-right: 1px;
            }

            .input-group.input-group-multiline > textarea.form-control {
                border-radius: 0 0 .2rem .2rem;
                resize: none;
                border-top: none;
            }

        .nice-scroll {
            height: 500px;
            overflow-y: auto;
        }
    </style>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "18ba46dfd9a894bde2df853aad1587af58ff4d8510421", async() => {
                WriteLiteral("\r\n\r\n    <div class=\"container mt-3 mb-3\">\r\n        <div class=\"row\">\r\n            <div class=\"col\">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "18ba46dfd9a894bde2df853aad1587af58ff4d8510809", async() => {
                    WriteLiteral(@"
                    <div class=""card-header"">
                        SignalR nümunə
                    </div>
                    <div class=""card-body"">
                        <div class=""input-group input-group-sm mb-3"">
                            <div class=""input-group-prepend"">
                                <span class=""input-group-text"" id=""chat-email-label"">E-mail</span>
                            </div>
                            <input id=""chat-email"" type=""text"" class=""form-control"" placeholder=""Kimə göndəriləcək"" aria-label=""Bura sinizi yazın"" aria-describedby=""chat-email-label"">
                        </div>
                        <div class=""input-group input-group-sm mb-3"">
                            <div class=""input-group-prepend"">
                                <span class=""input-group-text"" id=""chat-email-label"">Qrup adi</span>
                            </div>
                            <input id=""chat-group"" type=""text"" class=""form-control""
                  ");
                    WriteLiteral(@"                 placeholder=""Qrupa qosul"" aria-label=""Bura sinizi yazın"" aria-describedby=""chat-email-label"">
                            <button type=""button"" class=""btn btn-primary"" id=""btnJoinGroup"">Qrupa Qosul</button>
                        </div>

                        <div class=""input-group input-group-multiline input-group-sm mb-3"">
                            <div class=""input-group-prepend"">
                                <span class=""input-group-text"" id=""chat-message-label"">Mesajınız</span>
                            </div>
                            <textarea class=""form-control w-100"" id=""chat-message"" aria-describedby=""chat-message-label"" rows=""3""></textarea>
                        </div>
                    </div>
                    <div class=""card-footer text-muted"" style=""display: flex;align-items: baseline;justify-content: flex-end;"">
                        <div class=""input-group mr-3"" id=""client"">
                            <input type=""text"" class=""form-control""");
                    WriteLiteral(@" id=""eMail"" value=""zakirer@code.edu.az"" placeholder=""E-mailinizi qeyd edin"" aria-label=""E-mailinizi qeyd edin""
                                   aria-describedby=""btnConnect"">
                            <div class=""input-group-append"">
                                <button class=""btn btn-outline-secondary"" type=""button""
                                        id=""btnConnect"">
                                    Qoşul
                                </button>
                            </div>
                        </div>
                        <button type=""reset"" class=""btn btn-warning mr-1"">Təmizlə</button>
                        <button type=""button"" class=""btn btn-primary"" id=""btnSend"">Göndər</button>
                        <button id=""sendToGroup"" type=""button"" class=""btn btn-primary"">
                            Qrupa göndər
                        </button>
                    </div>
                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col nice-scroll\">\r\n                <div class=\"list-group\" id=\"messages\">\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "18ba46dfd9a894bde2df853aad1587af58ff4d8515649", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "18ba46dfd9a894bde2df853aad1587af58ff4d8516749", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <script>
        $(document).ready(function () {

            $('#btnConnect').click(function () {
                let userEmail = $('#eMail').val();

                if (userEmail.length < 1) {
                    alert(""EMail inputunu boş qoymaq olmaz!"");
                    return;
                }

                $.connection = new signalR.HubConnectionBuilder()
                    .configureLogging(signalR.LogLevel.None)
                    .withUrl(`/chat?email=${userEmail}`).build();

                // QueryString ile mail inputunun value'sunu gonderirik.

                $.connection.on('sayhello', function (msg) {
                    alert(`${msg}`);
                });


                $.connection.on('mesajgeldi', function (tomail, tomsj) {
                    alert(`${tomail}, ${tomsj}`);
                })

                $.connection.on('groupaQoshulma', function (userMail, groupName) {
                    alert(`${userMail} adlı istifadəçi , ${groupName} ad");
                WriteLiteral(@"lı
                                                 qrupa qoşuldu.`);
                })

                $.connection.on('groupaGonderenXaricMesajiGostermek',
                    function (from, chatMsg) {
                        alert(`${from} adlı istifadəçi , ${chatMsg} - dedi.`);
                    });

                $.connection.start().then(function () {
                    console.log(""Connected!"");
                })
                    .catch(function (ex) { console.log(ex); });
            });

            $('#btnSend').on('click', function () {

                let toMail = $('#chat-email').val();

                let toMsg = $('#chat-message').val();

                if (toMail.length < 1) {
                    alert(""Göndəriləcək E-mail ünvanını doldurun!"");
                    return;
                }

                if (toMsg.length < 1) {
                    alert(""Mesaj ünvanını doldurun!"");
                    return;
                }

                if");
                WriteLiteral(@" ($.connection == null) {
                    alert(""Çata qoşulun!"");
                    return;
                }

                $.connection.invoke(""send"", toMail, toMsg);

            })

            $('#btnJoinGroup').on('click', function () {

                let chatGroupName = $('#chat-group').val();

                if (chatGroupName.length < 1) {
                    alert(""Qrupun adını doldurun!"");
                    return;
                }

                let ourMail = $('#eMail').val();

                if (ourMail.length < 1) {
                    alert(""Göndərən istifadəçinin mail yerini doldurun!"");
                    return;
                }

                if ($.connection == null) {
                    alert(""Çata qoşulun!"");
                    return;
                }

                $.connection.invoke(""jointogroup"", ourMail, chatGroupName);


            });
        })

        $('#sendToGroup').click(function () {
            let chatGroup");
                WriteLiteral(@"Name = $('#chat-group').val();

            if (chatGroupName.length < 1) {
                alert(""Qrupun adını doldurun!"");
                return;
            }

            let ourMail = $('#eMail').val();

            if (ourMail.length < 1) {
                alert(""Göndərən istifadəçinin mail yerini doldurun!"");
                return;
            }

            let chatMessage = $('#chat-message').val();

            if (chatMessage.length < 1) {
                alert(""Mesaj yerini doldurun!"");
                return;
            }

            if ($.connection == null) {
                alert(""Çata qoşulun!"");
                return;
            }

            $.connection.invoke(""sendtogroup"", chatGroupName, chatMessage);


        });

    </script>



");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
