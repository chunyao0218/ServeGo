#pragma checksum "C:\Users\yao\Downloads\TFM103-No.2_Project - 複製\TwenGo\TwenGo\Views\Home\SpgatewayReturnView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9db3578807b29f3ea99e1f542f553917d9045043"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_SpgatewayReturnView), @"mvc.1.0.view", @"/Views/Home/SpgatewayReturnView.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9db3578807b29f3ea99e1f542f553917d9045043", @"/Views/Home/SpgatewayReturnView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b56eb9d82ec8cefc71110b23990bd931ef39353", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_SpgatewayReturnView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Spgateway.Models.SpgatewayOutputDataModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/success.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:100px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("checkmark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\yao\Downloads\TFM103-No.2_Project - 複製\TwenGo\TwenGo\Views\Home\SpgatewayReturnView.cshtml"
  
    ViewData["Title"] = "交易成功!";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n    <div id=\"content\">\r\n        <div class=\"notify successbox\">\r\n            <h1>交易成功!</h1><br />\r\n            <span class=\"alerticon\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9db3578807b29f3ea99e1f542f553917d90450434668", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</span><br />\r\n        </div>\r\n\r\n        <table class=\"table table-hover\" style=\"width: 50%; margin: auto; text-align: center;\">\r\n            <tbody>\r\n                <tr>\r\n                    <th scope=\"row\">總金額</th>\r\n                    <td>");
#nullable restore
#line 17 "C:\Users\yao\Downloads\TFM103-No.2_Project - 複製\TwenGo\TwenGo\Views\Home\SpgatewayReturnView.cshtml"
                   Write(Html.DisplayFor(model => model.Amt));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <th scope=\"row\">交易編號</th>\r\n                    <td>");
#nullable restore
#line 21 "C:\Users\yao\Downloads\TFM103-No.2_Project - 複製\TwenGo\TwenGo\Views\Home\SpgatewayReturnView.cshtml"
                   Write(Html.DisplayFor(model => model.TradeNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <th scope=\"row\">訂單編號</th>\r\n                    <td>");
#nullable restore
#line 25 "C:\Users\yao\Downloads\TFM103-No.2_Project - 複製\TwenGo\TwenGo\Views\Home\SpgatewayReturnView.cshtml"
                   Write(Html.DisplayFor(model => model.MerchantOrderNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <th scope=\"row\">支付方式</th>\r\n                    <td>");
#nullable restore
#line 29 "C:\Users\yao\Downloads\TFM103-No.2_Project - 複製\TwenGo\TwenGo\Views\Home\SpgatewayReturnView.cshtml"
                   Write(Html.DisplayFor(model => model.PaymentType));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <th scope=\"row\">交易時間</th>\r\n                    <td>");
#nullable restore
#line 33 "C:\Users\yao\Downloads\TFM103-No.2_Project - 複製\TwenGo\TwenGo\Views\Home\SpgatewayReturnView.cshtml"
                   Write(Html.DisplayFor(model => model.PayTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 35 "C:\Users\yao\Downloads\TFM103-No.2_Project - 複製\TwenGo\TwenGo\Views\Home\SpgatewayReturnView.cshtml"
                 if (Model.Card4No != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <th scope=\"row\">交易信用卡號末4碼</th>\r\n                        <td>");
#nullable restore
#line 39 "C:\Users\yao\Downloads\TFM103-No.2_Project - 複製\TwenGo\TwenGo\Views\Home\SpgatewayReturnView.cshtml"
                       Write(Html.DisplayFor(model => model.Card4No));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 41 "C:\Users\yao\Downloads\TFM103-No.2_Project - 複製\TwenGo\TwenGo\Views\Home\SpgatewayReturnView.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Users\yao\Downloads\TFM103-No.2_Project - 複製\TwenGo\TwenGo\Views\Home\SpgatewayReturnView.cshtml"
                 if (Model.PayBankCode != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <th scope=\"row\">付款銀行代碼</th>\r\n                        <td>");
#nullable restore
#line 46 "C:\Users\yao\Downloads\TFM103-No.2_Project - 複製\TwenGo\TwenGo\Views\Home\SpgatewayReturnView.cshtml"
                       Write(Html.DisplayFor(model => model.PayBankCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <th scope=\"row\">付款帳戶末五碼</th>\r\n                        <td>");
#nullable restore
#line 50 "C:\Users\yao\Downloads\TFM103-No.2_Project - 複製\TwenGo\TwenGo\Views\Home\SpgatewayReturnView.cshtml"
                       Write(Html.DisplayFor(model => model.PayerAccount5Code));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 52 "C:\Users\yao\Downloads\TFM103-No.2_Project - 複製\TwenGo\TwenGo\Views\Home\SpgatewayReturnView.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </tbody>
        </table>
    </div>
</div>


<style>
    #content {
        text-align: center;
        display: block;
        width: 100%;
        background: #fff;
        padding: 25px 20px;
        padding-bottom: 15px;
        -webkit-box-shadow: rgba(0, 0, 0, 0.1) 0px 1px 2px 0px;
        -moz-box-shadow: rgba(0, 0, 0, 0.1) 0px 1px 2px 0px;
        box-shadow: rgba(0, 0, 0, 0.1) 0px 1px 2px 0px;
    }

    dt, dd {
        margin: auto;
        width: 50%;
        padding: 10px;
    }

    #Box {
        margin: auto;
        width: 50%;
        padding: 100px;
    }
</style>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Spgateway.Models.SpgatewayOutputDataModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
