#pragma checksum "C:\Users\nobyA\trpr\Traktorina\MarinaIvanna\Views\Home\ManagerMC.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d8684dfd8138c2e88effc1efa042844208e982fa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ManagerMC), @"mvc.1.0.view", @"/Views/Home/ManagerMC.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ManagerMC.cshtml", typeof(AspNetCore.Views_Home_ManagerMC))]
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
#line 1 "C:\Users\nobyA\trpr\Traktorina\MarinaIvanna\Views\_ViewImports.cshtml"
using MarinaIvanna;

#line default
#line hidden
#line 2 "C:\Users\nobyA\trpr\Traktorina\MarinaIvanna\Views\_ViewImports.cshtml"
using MarinaIvanna.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8684dfd8138c2e88effc1efa042844208e982fa", @"/Views/Home/ManagerMC.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"231cba1d2428d0fd11af927c094ed2eec31abcd4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ManagerMC : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserManager>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/mc.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Home/AuthorizationUser"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("texit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\nobyA\trpr\Traktorina\MarinaIvanna\Views\Home\ManagerMC.cshtml"
  
    ViewData["Title"] = "Home Page";
    Layout = null;

#line default
#line hidden
            BeginContext(85, 277, true);
            WriteLiteral(@"<script>
    $('#myModal').on('show.bs.modal', function (event) {
        var button = $(event.relatedTarget)
        var recipient = button.data('whatever')
        var modal = $(this)
        modal.find('.Id').val(recipient)
    })
</script>
<!DOCTYPE html>
<html>
");
            EndContext();
            BeginContext(362, 251, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d8684dfd8138c2e88effc1efa042844208e982fa5716", async() => {
                BeginContext(368, 114, true);
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\r\n    ");
                EndContext();
                BeginContext(482, 45, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d8684dfd8138c2e88effc1efa042844208e982fa6221", async() => {
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
                EndContext();
                BeginContext(527, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(533, 71, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d8684dfd8138c2e88effc1efa042844208e982fa7553", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(604, 2, true);
                WriteLiteral("\r\n");
                EndContext();
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
            EndContext();
            BeginContext(613, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(615, 4129, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d8684dfd8138c2e88effc1efa042844208e982fa9682", async() => {
                BeginContext(621, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(627, 58, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d8684dfd8138c2e88effc1efa042844208e982fa10067", async() => {
                    BeginContext(676, 5, true);
                    WriteLiteral("Выход");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(685, 247, true);
                WriteLiteral("\r\n    <div class=\"container main\">\r\n        <div class=\"row\">\r\n            <div class=\"col-4\">\r\n                <div class=\"miv\">Марь Иванна</div>\r\n                <div class=\"kman\">Кабинет Менеджера</div>\r\n                <div class=\"mname\">Имя: ");
                EndContext();
                BeginContext(933, 14, false);
#line 29 "C:\Users\nobyA\trpr\Traktorina\MarinaIvanna\Views\Home\ManagerMC.cshtml"
                                   Write(Model.UserName);

#line default
#line hidden
                EndContext();
                BeginContext(947, 52, true);
                WriteLiteral("</div>\r\n                <div class=\"memail\">e-mail: ");
                EndContext();
                BeginContext(1000, 14, false);
#line 30 "C:\Users\nobyA\trpr\Traktorina\MarinaIvanna\Views\Home\ManagerMC.cshtml"
                                       Write(Model.UserMail);

#line default
#line hidden
                EndContext();
                BeginContext(1014, 66, true);
                WriteLiteral("</div>\r\n                <div class=\"mnapr\">Мои Направления</div>\r\n");
                EndContext();
#line 32 "C:\Users\nobyA\trpr\Traktorina\MarinaIvanna\Views\Home\ManagerMC.cshtml"
                 foreach (var p in Model.Problems)
                {

#line default
#line hidden
                BeginContext(1151, 35, true);
                WriteLiteral("                <div class=\"fnapr\">");
                EndContext();
                BeginContext(1187, 7, false);
#line 34 "C:\Users\nobyA\trpr\Traktorina\MarinaIvanna\Views\Home\ManagerMC.cshtml"
                              Write(p.Value);

#line default
#line hidden
                EndContext();
                BeginContext(1194, 8, true);
                WriteLiteral("</div>\r\n");
                EndContext();
#line 35 "C:\Users\nobyA\trpr\Traktorina\MarinaIvanna\Views\Home\ManagerMC.cshtml"
                }

#line default
#line hidden
                BeginContext(1221, 166, true);
                WriteLiteral("            </div>\r\n            <div class=\"col-8\">\r\n                <div class=\"mz\">Мои Заявки</div>\r\n                <div class=\"accordion\" id=\"accordionExample\">\r\n");
                EndContext();
#line 40 "C:\Users\nobyA\trpr\Traktorina\MarinaIvanna\Views\Home\ManagerMC.cshtml"
                     foreach (var v in Model.UserRequests)
                    {

#line default
#line hidden
                BeginContext(1470, 99, true);
                WriteLiteral("                        <div class=\"card za\">\r\n                            <div class=\"card-header\"");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 1569, "\"", 1580, 2);
                WriteAttributeValue("", 1574, "!", 1574, 1, true);
#line 43 "C:\Users\nobyA\trpr\Traktorina\MarinaIvanna\Views\Home\ManagerMC.cshtml"
WriteAttributeValue("", 1575, v.Id, 1575, 5, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1581, 156, true);
                WriteLiteral(">\r\n                                <h5 class=\"mb-0\">\r\n                                    <button class=\"btn btn-link\" data-toggle=\"collapse\" data-target=\"#");
                EndContext();
                BeginContext(1738, 4, false);
#line 45 "C:\Users\nobyA\trpr\Traktorina\MarinaIvanna\Views\Home\ManagerMC.cshtml"
                                                                                                 Write(v.Id);

#line default
#line hidden
                EndContext();
                BeginContext(1742, 23, true);
                WriteLiteral("\" aria-expanded=\"false\"");
                EndContext();
                BeginWriteAttribute("aria-controls", " aria-controls=\"", 1765, "\"", 1786, 1);
#line 45 "C:\Users\nobyA\trpr\Traktorina\MarinaIvanna\Views\Home\ManagerMC.cshtml"
WriteAttributeValue("", 1781, v.Id, 1781, 5, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1787, 69, true);
                WriteLiteral(">\r\n                                        <div class=\"acch\">Заявка №");
                EndContext();
                BeginContext(1857, 4, false);
#line 46 "C:\Users\nobyA\trpr\Traktorina\MarinaIvanna\Views\Home\ManagerMC.cshtml"
                                                             Write(v.Id);

#line default
#line hidden
                EndContext();
                BeginContext(1861, 81, true);
                WriteLiteral("</div>\r\n                                        <div class=\"acch\">Статус заявки: ");
                EndContext();
                BeginContext(1943, 8, false);
#line 47 "C:\Users\nobyA\trpr\Traktorina\MarinaIvanna\Views\Home\ManagerMC.cshtml"
                                                                    Write(v.Status);

#line default
#line hidden
                EndContext();
                BeginContext(1951, 164, true);
                WriteLiteral("</div>\r\n                                    </button>\r\n                                </h5>\r\n                            </div>\r\n\r\n                            <div");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 2115, "\"", 2125, 1);
#line 52 "C:\Users\nobyA\trpr\Traktorina\MarinaIvanna\Views\Home\ManagerMC.cshtml"
WriteAttributeValue("", 2120, v.Id, 2120, 5, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2126, 22, true);
                WriteLiteral(" class=\"collapse hide\"");
                EndContext();
                BeginWriteAttribute("aria-labelledby", " aria-labelledby=\"", 2148, "\"", 2172, 2);
                WriteAttributeValue("", 2166, "!", 2166, 1, true);
#line 52 "C:\Users\nobyA\trpr\Traktorina\MarinaIvanna\Views\Home\ManagerMC.cshtml"
WriteAttributeValue("", 2167, v.Id, 2167, 5, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2173, 230, true);
                WriteLiteral(" data-parent=\"#accordionExample\">\r\n                                <div class=\"card-body\">\r\n                                    <div class=\"binz\">Заявитель</div>\r\n                                    <div class=\"linz\">Направление: ");
                EndContext();
                BeginContext(2404, 6, false);
#line 55 "C:\Users\nobyA\trpr\Traktorina\MarinaIvanna\Views\Home\ManagerMC.cshtml"
                                                              Write(v.Type);

#line default
#line hidden
                EndContext();
                BeginContext(2410, 70, true);
                WriteLiteral("</div>\r\n                                    <div class=\"linz\">E-mail: ");
                EndContext();
                BeginContext(2481, 7, false);
#line 56 "C:\Users\nobyA\trpr\Traktorina\MarinaIvanna\Views\Home\ManagerMC.cshtml"
                                                         Write(v.Email);

#line default
#line hidden
                EndContext();
                BeginContext(2488, 69, true);
                WriteLiteral("</div>\r\n                                    <div class=\"linz\">Адрес: ");
                EndContext();
                BeginContext(2558, 9, false);
#line 57 "C:\Users\nobyA\trpr\Traktorina\MarinaIvanna\Views\Home\ManagerMC.cshtml"
                                                        Write(v.Address);

#line default
#line hidden
                EndContext();
                BeginContext(2567, 132, true);
                WriteLiteral("</div>\r\n                                    <div class=\"binz\">Проблема</div>\r\n                                    <div class=\"mess\">");
                EndContext();
                BeginContext(2700, 9, false);
#line 59 "C:\Users\nobyA\trpr\Traktorina\MarinaIvanna\Views\Home\ManagerMC.cshtml"
                                                 Write(v.Message);

#line default
#line hidden
                EndContext();
                BeginContext(2709, 144, true);
                WriteLiteral("</div>\r\n                                    <div class=\"binz\">Управляющая компания</div>\r\n                                    <div class=\"linz\">");
                EndContext();
                BeginContext(2854, 9, false);
#line 61 "C:\Users\nobyA\trpr\Traktorina\MarinaIvanna\Views\Home\ManagerMC.cshtml"
                                                 Write(v.Company);

#line default
#line hidden
                EndContext();
                BeginContext(2863, 77, true);
                WriteLiteral("</div>\r\n                                    <div class=\"linz\">Ответственный: ");
                EndContext();
                BeginContext(2941, 14, false);
#line 62 "C:\Users\nobyA\trpr\Traktorina\MarinaIvanna\Views\Home\ManagerMC.cshtml"
                                                                Write(ViewBag.M_name);

#line default
#line hidden
                EndContext();
                BeginContext(2955, 133, true);
                WriteLiteral("</div>\r\n                                    <div><button class=\"b_success\" data-toggle=\"modal\" data-target=\"#myModal\" data-whatever=\"");
                EndContext();
                BeginContext(3089, 4, false);
#line 63 "C:\Users\nobyA\trpr\Traktorina\MarinaIvanna\Views\Home\ManagerMC.cshtml"
                                                                                                                        Write(v.Id);

#line default
#line hidden
                EndContext();
                BeginContext(3093, 244, true);
                WriteLiteral("\">Принят в работу</button></div>\r\n                                    <div><button class=\"b_error\">Ошибка маршрутизации</button></div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
                EndContext();
#line 68 "C:\Users\nobyA\trpr\Traktorina\MarinaIvanna\Views\Home\ManagerMC.cshtml"
                    }

#line default
#line hidden
                BeginContext(3360, 1377, true);
                WriteLiteral(@"                </div>
            </div>
        </div>
    </div>

    <div class=""modal fade"" id=""myModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"" aria-hidden=""true"">
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"">
                <div>
                    <button type=""button"" class=""close1"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                    <h4 class=""date"" id=""myModalLabel"">Запрос даты</h4>

                </div>
                <h3 class=""standtext1"">Направить заявку на следующую дату: </h3>
                <input readonly=""readonly"" class=""cent"" name=""Id"" cols=""15"" rows=""5"" />
                <input class=""cent"" name=""Email"" cols=""15"" rows=""5"" placeholder=""Дата"" />
                <input class=""cent"" name=""Name"" cols=""15"" rows=""5"" placeholder=""Email"" />
                <button type=""submit"" class=""button_send1"">Отправи");
                WriteLiteral(@"ть заявку</button>
            </div>
        </div>
    </div>

    <script src=""https://code.jquery.com/jquery-3.3.1.slim.min.js""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js""></script>
    <script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.min.js""></script>

");
                EndContext();
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
            EndContext();
            BeginContext(4744, 11, true);
            WriteLiteral("\r\n</html>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserManager> Html { get; private set; }
    }
}
#pragma warning restore 1591