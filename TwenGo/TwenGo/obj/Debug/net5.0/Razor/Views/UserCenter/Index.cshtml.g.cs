#pragma checksum "C:\Users\yao\Downloads\TFM103-No.2_Project - 複製\TwenGo\TwenGo\Views\UserCenter\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "16a490e30df7b1fda583ea47993f4b105801639b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserCenter_Index), @"mvc.1.0.view", @"/Views/UserCenter/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16a490e30df7b1fda583ea47993f4b105801639b", @"/Views/UserCenter/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b56eb9d82ec8cefc71110b23990bd931ef39353", @"/Views/_ViewImports.cshtml")]
    public class Views_UserCenter_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TwenGo.Models.Repository.Entity.Users>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CustomerRegister", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/jquery/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"container\">\r\n\r\n    <div class=\"tab-pane active\" id=\"home\">\r\n\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 9 "C:\Users\yao\Downloads\TFM103-No.2_Project - 複製\TwenGo\TwenGo\Views\UserCenter\Index.cshtml"
         foreach (var item in Model)
        {
           

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card bg-light\" style=\"margin-top:30px\">\r\n            <h1 style=\"text-align:center\">會員中心</h1>\r\n            <article class=\"card-body mx-auto\" style=\"width: 48rem\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "16a490e30df7b1fda583ea47993f4b105801639b5234", async() => {
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "16a490e30df7b1fda583ea47993f4b105801639b5512", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 16 "C:\Users\yao\Downloads\TFM103-No.2_Project - 複製\TwenGo\TwenGo\Views\UserCenter\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                    <div class=""form-group input-group"">
                        <div class=""input-group-prepend"">
                            <span class=""input-group-text""> <i class=""fa fa-user""></i> </span>
                        </div>
                        <input class=""form-control""");
                BeginWriteAttribute("value", " value=\"", 975, "\"", 1027, 1);
#nullable restore
#line 21 "C:\Users\yao\Downloads\TFM103-No.2_Project - 複製\TwenGo\TwenGo\Views\UserCenter\Index.cshtml"
WriteAttributeValue("", 983, Html.DisplayFor(modelItem => item.RealName), 983, 44, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" disabled=\"disabled\" />\r\n");
                WriteLiteral(@"                    </div> <!-- form-group// -->

                    <div class=""form-group input-group"">
                        <div class=""input-group-prepend"">
                            <span class=""input-group-text""> <i class=""fa fa-envelope""></i> </span>
                        </div>
                        <input class=""form-control""");
                BeginWriteAttribute("value", " value=\"", 1548, "\"", 1597, 1);
#nullable restore
#line 29 "C:\Users\yao\Downloads\TFM103-No.2_Project - 複製\TwenGo\TwenGo\Views\UserCenter\Index.cshtml"
WriteAttributeValue("", 1556, Html.DisplayFor(modelItem => item.Email), 1556, 41, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" disabled=""disabled"" />
                    </div> <!-- form-group// -->

                    <div class=""form-group input-group"">
                        <div class=""input-group-prepend"">
                            <span class=""input-group-text""> <i class=""fas fa-user""></i> </span>
                        </div>
                        <input class=""form-control""");
                BeginWriteAttribute("value", " value=\"", 1972, "\"", 2030, 1);
#nullable restore
#line 36 "C:\Users\yao\Downloads\TFM103-No.2_Project - 複製\TwenGo\TwenGo\Views\UserCenter\Index.cshtml"
WriteAttributeValue("", 1980, Html.DisplayFor(modelItem => item.IdentityNumber), 1980, 50, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" disabled=""disabled"" />
                    </div> <!-- form-group// -->

                    <div class=""form-group input-group"">
                        <div class=""input-group-prepend"">
                            <span class=""input-group-text""> <i class=""fas fa-user""></i> </span>
                        </div>
                        <input class=""form-control""");
                BeginWriteAttribute("value", " value=\"", 2405, "\"", 2453, 1);
#nullable restore
#line 43 "C:\Users\yao\Downloads\TFM103-No.2_Project - 複製\TwenGo\TwenGo\Views\UserCenter\Index.cshtml"
WriteAttributeValue("", 2413, Html.DisplayFor(modelItem => item.City), 2413, 40, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" disabled=""disabled"" />
                    </div> <!-- form-group// -->

                    <div class=""form-group input-group"">
                        <div class=""input-group-prepend"">
                            <span class=""input-group-text""> <i class=""fas fa-user""></i> </span>
                        </div>
                        <input class=""form-control""");
                BeginWriteAttribute("value", " value=\"", 2828, "\"", 2876, 1);
#nullable restore
#line 50 "C:\Users\yao\Downloads\TFM103-No.2_Project - 複製\TwenGo\TwenGo\Views\UserCenter\Index.cshtml"
WriteAttributeValue("", 2836, Html.DisplayFor(modelItem => item.Town), 2836, 40, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" disabled=""disabled"" />
                    </div> <!-- form-group// -->

                    <div class=""form-group input-group"">
                        <div class=""input-group-prepend"">
                            <span class=""input-group-text""> <i class=""fas fa-user""></i> </span>
                        </div>
                        <input class=""form-control""");
                BeginWriteAttribute("value", " value=\"", 3251, "\"", 3302, 1);
#nullable restore
#line 57 "C:\Users\yao\Downloads\TFM103-No.2_Project - 複製\TwenGo\TwenGo\Views\UserCenter\Index.cshtml"
WriteAttributeValue("", 3259, Html.DisplayFor(modelItem => item.Address), 3259, 43, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" disabled=\"disabled\" />\r\n                    </div> <!-- form-group// -->\r\n\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </article>\r\n        </div> <!-- card.// -->\r\n");
#nullable restore
#line 63 "C:\Users\yao\Downloads\TFM103-No.2_Project - 複製\TwenGo\TwenGo\Views\UserCenter\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </div>
</div>

<script>
    var real = document.getElementById(""btnRealName"")
    real.addEventListener(""click"", function{
        alert(""123"")
    })

</script>

            <style>
                .divider-text {
                    position: relative;
                    text-align: center;
                    margin-top: 15px;
                    margin-bottom: 15px;
                }

                    .divider-text span {
                        padding: 7px;
                        font-size: 12px;
                        position: relative;
                        z-index: 2;
                    }

                    .divider-text:after {
                        content: """";
                        position: absolute;
                        width: 100%;
                        border-bottom: 1px solid #ddd;
                        top: 55%;
                        left: 0;
                        z-index: 1;
                    }

                .btn-facebo");
            WriteLiteral(@"ok {
                    background-color: #405D9D;
                    color: #fff;
                }

                a:hover {
                    text-decoration: none !important;
                    color: #000000;
                }
            </style>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 112 "C:\Users\yao\Downloads\TFM103-No.2_Project - 複製\TwenGo\TwenGo\Views\UserCenter\Index.cshtml"
                  await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
                WriteLiteral("                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "16a490e30df7b1fda583ea47993f4b105801639b15272", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                <script src=""https://cdn.jsdelivr.net/npm/jquery-twzipcode@1.7.14/jquery.twzipcode.min.js""></script>
                <script>
                    $(document).ready(function () {
                        $(""#twzipcode"").twzipcode({
                            zipcodeIntoDistrict: true, // 郵遞區號自動顯示在區別選單中
                            css: [""city form-control"", ""town form-control""], // 自訂 ""城市""、""地別"" class 名稱
                            countyName: ""City"", // 自訂城市 select 標籤的 name 值
                            districtName: ""Town"" // 自訂區別 select 標籤的 name 值
                        });
                    });

                    var edit = document.getElementById
                </script>
            ");
            }
            );
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TwenGo.Models.Repository.Entity.Users>> Html { get; private set; }
    }
}
#pragma warning restore 1591
