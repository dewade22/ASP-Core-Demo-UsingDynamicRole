#pragma checksum "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\Users\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "58dd466f8db49eafb369e43f2c30642d152108fd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Delete), @"mvc.1.0.view", @"/Views/Users/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Users/Delete.cshtml", typeof(AspNetCore.Views_Users_Delete))]
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
#line 1 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\_ViewImports.cshtml"
using Balimoon_E_Procurement;

#line default
#line hidden
#line 2 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\_ViewImports.cshtml"
using Balimoon_E_Procurement.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58dd466f8db49eafb369e43f2c30642d152108fd", @"/Views/Users/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ca815501e2415492be7fd7738acfe7eb9493282", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Balimoon_E_Procurement.Models.AspNetUsers>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(50, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\Users\Delete.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(141, 181, true);
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>AspNetUsers</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(323, 44, false);
#line 16 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\Users\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(367, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(431, 40, false);
#line 19 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\Users\Delete.cshtml"
       Write(Html.DisplayFor(model => model.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(471, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(534, 54, false);
#line 22 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\Users\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.NormalizedUserName));

#line default
#line hidden
            EndContext();
            BeginContext(588, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(652, 50, false);
#line 25 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\Users\Delete.cshtml"
       Write(Html.DisplayFor(model => model.NormalizedUserName));

#line default
#line hidden
            EndContext();
            BeginContext(702, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(765, 41, false);
#line 28 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\Users\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(806, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(870, 37, false);
#line 31 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\Users\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(907, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(970, 51, false);
#line 34 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\Users\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.NormalizedEmail));

#line default
#line hidden
            EndContext();
            BeginContext(1021, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1085, 47, false);
#line 37 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\Users\Delete.cshtml"
       Write(Html.DisplayFor(model => model.NormalizedEmail));

#line default
#line hidden
            EndContext();
            BeginContext(1132, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1195, 50, false);
#line 40 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\Users\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.EmailConfirmed));

#line default
#line hidden
            EndContext();
            BeginContext(1245, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1309, 46, false);
#line 43 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\Users\Delete.cshtml"
       Write(Html.DisplayFor(model => model.EmailConfirmed));

#line default
#line hidden
            EndContext();
            BeginContext(1355, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1418, 48, false);
#line 46 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\Users\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PasswordHash));

#line default
#line hidden
            EndContext();
            BeginContext(1466, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1530, 44, false);
#line 49 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\Users\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PasswordHash));

#line default
#line hidden
            EndContext();
            BeginContext(1574, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1637, 49, false);
#line 52 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\Users\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.SecurityStamp));

#line default
#line hidden
            EndContext();
            BeginContext(1686, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1750, 45, false);
#line 55 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\Users\Delete.cshtml"
       Write(Html.DisplayFor(model => model.SecurityStamp));

#line default
#line hidden
            EndContext();
            BeginContext(1795, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1858, 52, false);
#line 58 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\Users\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ConcurrencyStamp));

#line default
#line hidden
            EndContext();
            BeginContext(1910, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1974, 48, false);
#line 61 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\Users\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ConcurrencyStamp));

#line default
#line hidden
            EndContext();
            BeginContext(2022, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2085, 47, false);
#line 64 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\Users\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(2132, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2196, 43, false);
#line 67 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\Users\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(2239, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2302, 56, false);
#line 70 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\Users\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PhoneNumberConfirmed));

#line default
#line hidden
            EndContext();
            BeginContext(2358, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2422, 52, false);
#line 73 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\Users\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PhoneNumberConfirmed));

#line default
#line hidden
            EndContext();
            BeginContext(2474, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2537, 52, false);
#line 76 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\Users\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TwoFactorEnabled));

#line default
#line hidden
            EndContext();
            BeginContext(2589, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2653, 48, false);
#line 79 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\Users\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TwoFactorEnabled));

#line default
#line hidden
            EndContext();
            BeginContext(2701, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2764, 46, false);
#line 82 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\Users\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.LockoutEnd));

#line default
#line hidden
            EndContext();
            BeginContext(2810, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2874, 42, false);
#line 85 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\Users\Delete.cshtml"
       Write(Html.DisplayFor(model => model.LockoutEnd));

#line default
#line hidden
            EndContext();
            BeginContext(2916, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2979, 50, false);
#line 88 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\Users\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.LockoutEnabled));

#line default
#line hidden
            EndContext();
            BeginContext(3029, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3093, 46, false);
#line 91 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\Users\Delete.cshtml"
       Write(Html.DisplayFor(model => model.LockoutEnabled));

#line default
#line hidden
            EndContext();
            BeginContext(3139, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3202, 53, false);
#line 94 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\Users\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.AccessFailedCount));

#line default
#line hidden
            EndContext();
            BeginContext(3255, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3319, 49, false);
#line 97 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\Users\Delete.cshtml"
       Write(Html.DisplayFor(model => model.AccessFailedCount));

#line default
#line hidden
            EndContext();
            BeginContext(3368, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(3406, 206, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "58dd466f8db49eafb369e43f2c30642d152108fd17032", async() => {
                BeginContext(3432, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(3442, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "58dd466f8db49eafb369e43f2c30642d152108fd17425", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 102 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\Users\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3478, 83, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                EndContext();
                BeginContext(3561, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "58dd466f8db49eafb369e43f2c30642d152108fd19331", async() => {
                    BeginContext(3583, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3599, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3612, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Balimoon_E_Procurement.Models.AspNetUsers> Html { get; private set; }
    }
}
#pragma warning restore 1591
