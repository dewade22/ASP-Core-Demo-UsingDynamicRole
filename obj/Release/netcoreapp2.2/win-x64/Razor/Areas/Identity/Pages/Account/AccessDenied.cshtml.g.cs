#pragma checksum "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Areas\Identity\Pages\Account\AccessDenied.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf8c12900eab76c98c9096783fea80e479e82df7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Balimoon_E_Procurement.Areas.Identity.Pages.Account.Areas_Identity_Pages_Account_AccessDenied), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/AccessDenied.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Areas/Identity/Pages/Account/AccessDenied.cshtml", typeof(Balimoon_E_Procurement.Areas.Identity.Pages.Account.Areas_Identity_Pages_Account_AccessDenied), null)]
namespace Balimoon_E_Procurement.Areas.Identity.Pages.Account
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 2 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Areas\Identity\Pages\_ViewImports.cshtml"
using Balimoon_E_Procurement.Areas.Identity;

#line default
#line hidden
#line 3 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 1 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using Balimoon_E_Procurement.Areas.Identity.Pages.Account;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf8c12900eab76c98c9096783fea80e479e82df7", @"/Areas/Identity/Pages/Account/AccessDenied.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68ab5f152bd64542de998ab9e53f864969f1c12c", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16c8ef19e5c373dfcd723f5a5c3cc1e55c92edd3", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_AccessDenied : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Areas\Identity\Pages\Account\AccessDenied.cshtml"
  
    ViewData["Title"] = "Tidak Ada Akses";

#line default
#line hidden
            BeginContext(84, 48, true);
            WriteLiteral("\r\n<header>\r\n    <center><h1 class=\"text-danger\">");
            EndContext();
            BeginContext(133, 17, false);
#line 8 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Areas\Identity\Pages\Account\AccessDenied.cshtml"
                               Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(150, 284, true);
            WriteLiteral(@"</h1></center>
</header>
<div class=""row"">
    <div class=""col-md-1""></div>
    <div class=""col-md-10"">
        <p>
            <h4>Anda Tidak Mendapatkan Akses Ke halaman Ini..!!!</h4><br />
            <h5>silahkan akses halaman lainnya</h5>
        </p>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AccessDeniedModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AccessDeniedModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AccessDeniedModel>)PageContext?.ViewData;
        public AccessDeniedModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
