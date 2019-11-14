#pragma checksum "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement - Copy\Views\PurchaseRequest\Archived.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "79e4bd4b9702764d88217037fdcaca75d1adf07d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PurchaseRequest_Archived), @"mvc.1.0.view", @"/Views/PurchaseRequest/Archived.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/PurchaseRequest/Archived.cshtml", typeof(AspNetCore.Views_PurchaseRequest_Archived))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79e4bd4b9702764d88217037fdcaca75d1adf07d", @"/Views/PurchaseRequest/Archived.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ca815501e2415492be7fd7738acfe7eb9493282", @"/Views/_ViewImports.cshtml")]
    public class Views_PurchaseRequest_Archived : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Balimoon_E_Procurement.Models.BalimoonBML.ViewModel.PurchaseRequestVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement - Copy\Views\PurchaseRequest\Archived.cshtml"
  
    ViewData["Title"] = "Open";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(165, 1258, true);
            WriteLiteral(@"
<br />
<h2>BalimOOn Liqueurs</h2>
<section class=""content"">
    <div class=""card"">
        <div class=""row"">
            <div class=""col-12"">
                <div class=""card-header"">
                    <h3 class=""card-title"">Purchases Requisition - Archived</h3>
                </div>
                <div class=""card-body"">
                    <div class=""form-group"">
                        <table id=""tabel5"" class=""table table-striped table-bordered"">
                            <thead>
                                <tr>
                                    <th>PR Id</th>
                                    <th>Document No</th>
                                    <th>Requester</th>
                                    <th>Department</th>
                                    <th>Order Date</th>
                                    <th>Due Date</th>
                                    <th>Notes</th>
                                    <th>Details</th>
                                </");
            WriteLiteral("tr>\r\n                            </thead>\r\n                            <tbody></tbody>\r\n                        </table>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1440, 3246, true);
                WriteLiteral(@"
    <script>
        $.fn.dataTable.moment(""DD/MM/YYYY HH:mm:ss"");
        $.fn.dataTable.moment(""DD/MM/YYYY"");


        $(""#tabel5"").DataTable({
            //Design Layout
            stateSave: true,
            autoWidth: true,

            //ServerSide
            processing: true,
            serverSide: true,

            //Paging Setup
            paging: true,

            //searching Setup
            searching: { regex: true },

            //ajax Filter
            ajax: {
                url: ""/PurchaseRequest/GetPRListAcv"",
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
 ");
                WriteLiteral(@"               {
                    targets: ""trim"",
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
                { data: ""RequisitionHeaderId"", name: ""RequisitionHeaderId"", isIdentity: true, visible: false },
                { data: ""RequisitionNo"", name: ""RequisitionNo"" },
                { data: ""RequesterId"", name: ""RequesterId"" },
                { data: ""ShortcutDimension1Code"", name: ""ShortcutDimension1Code"" },
                {
                    data: ""OrderDate"", render: function (data, type, row) {
                        if (type === ""display"" || type === ""filter"") {
                            return moment(data).format(""dddd, DD-MM-YYYY HH:mm:ss"");
     ");
                WriteLiteral(@"                   }
                        return data;
                    }
                },
                {
                    data: ""DueDate"",
                    render: function (data, type, row) {
                        if (type === ""display"" || type === ""filter"") {
                            return moment(data).format(""dddd, DD-MM-YYYY HH:mm:ss"");
                        }
                        return data;
                    }
                },
                { data: ""RequestNotes"", name: ""RequestNotes"" },

                {
                    render: function (data, type, full, meta) {
                        return ""<a href='#' onclick='Details(\"""" + full.RequisitionHeaderId + ""\"")' class='btn btn-outline-info'><span class='pe-7s-info'> Details</span></a>"";

                    }
                }
            ]
        })
        $("".dataTables_scrollHeadInner"").css({ ""width"": ""100%"" });
        $("".table "").css({ ""width"": ""100%"" });
    </script>
<script>
");
                WriteLiteral("    function Details(RequisitionHeaderId) {\r\n        window.location.href = \"/PurchaseRequest/DetilPRArchived?RequisitionHeaderId=\" + RequisitionHeaderId;\r\n    }\r\n</script>\r\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Balimoon_E_Procurement.Models.BalimoonBML.ViewModel.PurchaseRequestVM> Html { get; private set; }
    }
}
#pragma warning restore 1591