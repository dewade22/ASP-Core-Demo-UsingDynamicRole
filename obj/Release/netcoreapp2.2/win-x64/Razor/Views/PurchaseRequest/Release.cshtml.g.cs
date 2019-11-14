#pragma checksum "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\PurchaseRequest\Release.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "29e4792144f8c27c2c8596ec03b6619e521b01cd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PurchaseRequest_Release), @"mvc.1.0.view", @"/Views/PurchaseRequest/Release.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/PurchaseRequest/Release.cshtml", typeof(AspNetCore.Views_PurchaseRequest_Release))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29e4792144f8c27c2c8596ec03b6619e521b01cd", @"/Views/PurchaseRequest/Release.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ca815501e2415492be7fd7738acfe7eb9493282", @"/Views/_ViewImports.cshtml")]
    public class Views_PurchaseRequest_Release : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Balimoon_E_Procurement.Models.BalimoonBML.ViewModel.PurchaseRequestVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\PurchaseRequest\Release.cshtml"
  
    ViewData["Title"] = "Open";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(165, 1257, true);
            WriteLiteral(@"
<br />
<h2>BalimOOn Liqueurs</h2>
<section class=""content"">
    <div class=""card"">
        <div class=""row"">
            <div class=""col-12"">
                <div class=""card-header"">
                    <h3 class=""card-title"">Purchases Requisition - Release</h3>
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
                                </t");
            WriteLiteral("r>\r\n                            </thead>\r\n                            <tbody></tbody>\r\n                        </table>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1439, 3274, true);
                WriteLiteral(@"
    <script>
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
                url: ""/PurchaseRequest/GetPRListRe"",
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
                { targets: ""no-searc");
                WriteLiteral(@"h"", searchable: false },
                {
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
                            return moment(data).format(""dddd, DD");
                WriteLiteral(@"-MM-YYYY HH:mm:ss"");
                        }
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
        $("".table "").css({ ""width"": ""100%"" });");
                WriteLiteral("\r\n    </script>\r\n<script>\r\n    function Details(RequisitionHeaderId) {\r\n        window.location.href = \"/PurchaseRequest/DetilPRReleaseView?RequisitionHeaderId=\"+RequisitionHeaderId;\r\n    }\r\n</script>\r\n");
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
