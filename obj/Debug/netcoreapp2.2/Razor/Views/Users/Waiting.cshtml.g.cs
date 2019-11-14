#pragma checksum "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement - Copy\Views\Users\Waiting.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a0c20cfa8b15ef9377c68e5d37519fa724bbd855"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Waiting), @"mvc.1.0.view", @"/Views/Users/Waiting.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Users/Waiting.cshtml", typeof(AspNetCore.Views_Users_Waiting))]
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
#line 1 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement - Copy\Views\_ViewImports.cshtml"
using Balimoon_E_Procurement;

#line default
#line hidden
#line 2 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement - Copy\Views\_ViewImports.cshtml"
using Balimoon_E_Procurement.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0c20cfa8b15ef9377c68e5d37519fa724bbd855", @"/Views/Users/Waiting.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ca815501e2415492be7fd7738acfe7eb9493282", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_Waiting : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Balimoon_E_Procurement.Models.AspNetUsers>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement - Copy\Views\Users\Waiting.cshtml"
  
    ViewData["Title"] = "Waiting";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(140, 1004, true);
            WriteLiteral(@"<br />
<h2>User not Confirm Their Account</h2><br />
<section class=""content"">
    <div class=""card"">
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""card-header"">
                    <h3 class=""card-title"">User Waiting to Confirm</h3>
                </div>
                <div class=""card-body"">
                    <table id=""tabel5"" class=""table table-bordered table-striped position-relative display nowrap"" style=""width:100%"">
                        <thead>
                            <tr>
                                <th>User ID</th>
                                <th>Username</th>
                                <th>E-Mail</th>
                                <th>Phone Number</th>
                            </tr>
                        </thead>
                        <tbody id=""SetUserList""></tbody>
                    </table>
                </div>
            </div>
        </div>
    </div>
</section>


");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1161, 1728, true);
                WriteLiteral(@"
    <script>
        //Get User waiting to pass to data table

    $.fn.dataTable.moment(""DD/MM/YYYY HH:mm:ss"");
    $.fn.dataTable.moment(""DD/MM/YYYY"");


    $(""#tabel5"").DataTable({
        //Design Layout
        stateSave: true,
        autoWidth: true,
        scrollX: true,
      

        //ServerSide
        processing: true,
        serverSide: true,

        //Paging Setup
        paging: true,
        

        //searching Setup
        searching: { regex: true },

        //ajax Filter
        ajax: {
            url: ""/Users/GetUserWaiting"",
            //""dataSrc"": '',
            type: ""POST"",
            contentType: ""application/json"",
            dataType: ""json"",
            data: function (d) {
                return JSON.stringify(d);
            }
        },

        //column definition
        columnDefs: [
            { targets: ""no-sort"", orderable: false },
            { targets: ""no-search"", searchable: false },
            {
            ");
                WriteLiteral(@"    targets: ""trim"",
                render: function (data, type, full, meta) {
                    if (type === ""display"") {
                        data = strtrunc(data, 10);
                    }
                    return data;
                }
            },
            { targets: ""data-type"", type: ""date-eu"" }
        ],

        columns: [
             { data: ""Id"", name: ""Id"" },
             { data: ""UserName"", name: ""UserName"" },
             { data: ""Email"", name: ""Email"" },
             { data: ""PhoneNumber"", name: ""PhoneNumber"" }
        ]
    })
    $("".dataTables_scrollHeadInner"").css({""width"":""100%""});
    $("".table "").css({""width"":""100%""});

    </script>
");
                EndContext();
            }
            );
            BeginContext(2892, 2, true);
            WriteLiteral("\r\n");
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
