#pragma checksum "C:\Users\yao\Downloads\TFM103-No.2_Project - 複製\TwenGo\TwenGo\Views\Management\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa8e83c796814bb0155b01169655550a243c4076"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Management_Details), @"mvc.1.0.view", @"/Views/Management/Details.cshtml")]
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
#line 1 "C:\Users\yao\Downloads\TFM103-No.2_Project - 複製\TwenGo\TwenGo\Views\_ViewImports.cshtml"
using TwenGo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\yao\Downloads\TFM103-No.2_Project - 複製\TwenGo\TwenGo\Views\_ViewImports.cshtml"
using TwenGo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa8e83c796814bb0155b01169655550a243c4076", @"/Views/Management/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b56eb9d82ec8cefc71110b23990bd931ef39353", @"/Views/_ViewImports.cshtml")]
    public class Views_Management_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TwenGo.Models.Order>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Management", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-outline-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\yao\Downloads\TFM103-No.2_Project - 複製\TwenGo\TwenGo\Views\Management\Details.cshtml"
   ViewData["Title"] = "ReviewOrder"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"section border-bottom pt-2 pb-2\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-sm-12\">\r\n                <ul class=\"breadcrumbs\">\r\n                    <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa8e83c796814bb0155b01169655550a243c40765192", async() => {
                WriteLiteral("首頁");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("a", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n                    <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa8e83c796814bb0155b01169655550a243c40766882", async() => {
                WriteLiteral("訂單管理");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</li>
                    <li>訂單資訊</li>
                </ul>
            </div>
        </div>
    </div>
</div>

<div class=""text-center"">
    <p></p>
    <h4>訂單資訊</h4>
    <p></p>
</div>

<div class=""card shadow-sm rounded"">
    <div class=""card-body"">

        <h5>訂單編號：");
#nullable restore
#line 29 "C:\Users\yao\Downloads\TFM103-No.2_Project - 複製\TwenGo\TwenGo\Views\Management\Details.cshtml"
            Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n        <div class=\"row\">\r\n            <div class=\"col\"><p class=\"text-muted\">付款者帳號: ");
#nullable restore
#line 31 "C:\Users\yao\Downloads\TFM103-No.2_Project - 複製\TwenGo\TwenGo\Views\Management\Details.cshtml"
                                                     Write(Html.DisplayFor(model => model.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></div>\r\n            <div class=\"col text-right\"><p class=\"text-muted\">");
#nullable restore
#line 32 "C:\Users\yao\Downloads\TFM103-No.2_Project - 複製\TwenGo\TwenGo\Views\Management\Details.cshtml"
                                                         Write(Html.DisplayFor(model => model.OrderDate));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p></div>
        </div>

        <div>
            <table class=""table table-success table-striped"">
                <thead>
                    <tr>
                        <th>商品名稱</th>
                        <th>數量</th>
                        <th>小計</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 45 "C:\Users\yao\Downloads\TFM103-No.2_Project - 複製\TwenGo\TwenGo\Views\Management\Details.cshtml"
                     foreach (var item in ViewBag.orderItems)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 48 "C:\Users\yao\Downloads\TFM103-No.2_Project - 複製\TwenGo\TwenGo\Views\Management\Details.cshtml"
                           Write(item.Product.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 49 "C:\Users\yao\Downloads\TFM103-No.2_Project - 複製\TwenGo\TwenGo\Views\Management\Details.cshtml"
                           Write(item.Amount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 50 "C:\Users\yao\Downloads\TFM103-No.2_Project - 複製\TwenGo\TwenGo\Views\Management\Details.cshtml"
                           Write(item.SubTotal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n");
#nullable restore
#line 52 "C:\Users\yao\Downloads\TFM103-No.2_Project - 複製\TwenGo\TwenGo\Views\Management\Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n            <div class=\"text-right pr-5\">\r\n                <p style=\"padding-right:12px\" class=\"text-danger\">總計： $");
#nullable restore
#line 56 "C:\Users\yao\Downloads\TFM103-No.2_Project - 複製\TwenGo\TwenGo\Views\Management\Details.cshtml"
                                                                  Write(Html.DisplayFor(model => model.Total));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n        <hr />\r\n        <div class=\"row\">\r\n            <div class=\"col-7\">\r\n                <p>預約日期：");
#nullable restore
#line 62 "C:\Users\yao\Downloads\TFM103-No.2_Project - 複製\TwenGo\TwenGo\Views\Management\Details.cshtml"
                   Write(Html.DisplayFor(model => model.ReciveDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p>預約者姓名：");
#nullable restore
#line 63 "C:\Users\yao\Downloads\TFM103-No.2_Project - 複製\TwenGo\TwenGo\Views\Management\Details.cshtml"
                    Write(Html.DisplayFor(model => model.ReceiverName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p>預約者電話：");
#nullable restore
#line 64 "C:\Users\yao\Downloads\TFM103-No.2_Project - 複製\TwenGo\TwenGo\Views\Management\Details.cshtml"
                    Write(Html.DisplayFor(model => model.ReceiverPhone));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p>預約地址：");
#nullable restore
#line 65 "C:\Users\yao\Downloads\TFM103-No.2_Project - 複製\TwenGo\TwenGo\Views\Management\Details.cshtml"
                   Write(Html.DisplayFor(model => model.ReceiverAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n            <div class=\"col-5\">\r\n                <p>訂單備註：");
#nullable restore
#line 68 "C:\Users\yao\Downloads\TFM103-No.2_Project - 複製\TwenGo\TwenGo\Views\Management\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Memo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p>\r\n                    訂單狀態：\r\n");
#nullable restore
#line 71 "C:\Users\yao\Downloads\TFM103-No.2_Project - 複製\TwenGo\TwenGo\Views\Management\Details.cshtml"
                     if (@Model.isPaid)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span>已付款</span> ");
#nullable restore
#line 73 "C:\Users\yao\Downloads\TFM103-No.2_Project - 複製\TwenGo\TwenGo\Views\Management\Details.cshtml"
                                         }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span>未付款</span>");
#nullable restore
#line 76 "C:\Users\yao\Downloads\TFM103-No.2_Project - 複製\TwenGo\TwenGo\Views\Management\Details.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </p>\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n</div>\r\n<p></p>\r\n<hr>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa8e83c796814bb0155b01169655550a243c407614755", async() => {
                WriteLiteral("<i class=\"fa fa-arrow-left\"></i> 返回訂單管理");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</div>


<script>
</script>


<style>

    .progressbar {
        counter-reset: step;
    }

        .progressbar li {
            list-style-type: none;
            width: 25%;
            float: left;
            font-size: 12px;
            position: relative;
            text-align: center;
            text-transform: uppercase;
            color: #7d7d7d;
        }

            .progressbar li:before {
                width: 30px;
                height: 30px;
                content: counter(step);
                counter-increment: step;
                line-height: 30px;
                border: 2px solid #7d7d7d;
                display: block;
                text-align: center;
                margin: 0 auto 10px auto;
                border-radius: 50%;
                background-color: white;
            }

            .progressbar li:after {
                width: 100%;
                height: 2px;
                content: '';
                position:");
            WriteLiteral(@" absolute;
                background-color: #7d7d7d;
                top: 15px;
                left: -50%;
                z-index: -1;
            }

            .progressbar li:first-child:after {
                content: none;
            }

            .progressbar li.active {
                color: green;
            }

                .progressbar li.active:before {
                    border-color: #55b776;
                }

                .progressbar li.active + li:after {
                    background-color: #55b776;
                }
</style>

<style>
    body {
        background-color: ivory
    }

    .card {
        margin-top: 30px;
    }

    .card-text {
        color: black
    }

    .hidding {
        z-index: -1;
    }

    /*.modal.fade .modal-dialog {
            transform: translateY(10vh);
        }

        .modal.show .modal-dialog {
            transform: translateY(0);
        }*/

    .modal-backdrop {
        z-index: 0;
 ");
            WriteLiteral("   }\r\n</style>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TwenGo.Models.Order> Html { get; private set; }
    }
}
#pragma warning restore 1591
