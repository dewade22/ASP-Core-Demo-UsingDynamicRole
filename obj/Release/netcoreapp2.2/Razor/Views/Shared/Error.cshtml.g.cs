#pragma checksum "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\Shared\Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b9b369c1e26d6d2e9f544ade7c0a98d078110377"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Error), @"mvc.1.0.view", @"/Views/Shared/Error.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Error.cshtml", typeof(AspNetCore.Views_Shared_Error))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9b369c1e26d6d2e9f544ade7c0a98d078110377", @"/Views/Shared/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ca815501e2415492be7fd7738acfe7eb9493282", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Error : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ErrorViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\Shared\Error.cshtml"
  
    ViewData["Title"] = "Error";

#line default
#line hidden
            BeginContext(64, 120, true);
            WriteLiteral("\r\n<h1 class=\"text-danger\">Error.</h1>\r\n<h2 class=\"text-danger\">An error occurred while processing your request.</h2>\r\n\r\n");
            EndContext();
#line 9 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\Shared\Error.cshtml"
 if (Model.ShowRequestId)
{

#line default
#line hidden
            BeginContext(214, 52, true);
            WriteLiteral("    <p>\r\n        <strong>Request ID:</strong> <code>");
            EndContext();
            BeginContext(267, 15, false);
#line 12 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\Shared\Error.cshtml"
                                      Write(Model.RequestId);

#line default
#line hidden
            EndContext();
            BeginContext(282, 19, true);
            WriteLiteral("</code>\r\n    </p>\r\n");
            EndContext();
#line 14 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\Shared\Error.cshtml"
}

#line default
#line hidden
            BeginContext(304, 7, true);
            WriteLiteral("<div>\r\n");
            EndContext();
#line 16 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\Shared\Error.cshtml"
      
        if (Model != null && Model.ErrorMessage != null)
        {

#line default
#line hidden
            BeginContext(388, 16, true);
            WriteLiteral("            <h5>");
            EndContext();
            BeginContext(405, 18, false);
#line 19 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\Shared\Error.cshtml"
           Write(Model.ErrorMessage);

#line default
#line hidden
            EndContext();
            BeginContext(423, 7, true);
            WriteLiteral("</h5>\r\n");
            EndContext();
#line 20 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\Shared\Error.cshtml"
        }
    

#line default
#line hidden
            BeginContext(448, 10, true);
            WriteLiteral("</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ErrorViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
