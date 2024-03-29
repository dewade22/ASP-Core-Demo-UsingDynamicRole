#pragma checksum "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\PurchaseRequest\Rejected.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8fcb2fb1d9adfef3a51e488851bdf4188e26e1a9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PurchaseRequest_Rejected), @"mvc.1.0.view", @"/Views/PurchaseRequest/Rejected.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/PurchaseRequest/Rejected.cshtml", typeof(AspNetCore.Views_PurchaseRequest_Rejected))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8fcb2fb1d9adfef3a51e488851bdf4188e26e1a9", @"/Views/PurchaseRequest/Rejected.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ca815501e2415492be7fd7738acfe7eb9493282", @"/Views/_ViewImports.cshtml")]
    public class Views_PurchaseRequest_Rejected : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Balimoon_E_Procurement.Models.BalimoonBML.ViewModel.PurchaseRequestVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\PurchaseRequest\Rejected.cshtml"
  
    ViewData["Title"] = "Rejected";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(169, 1291, true);
            WriteLiteral(@"
<h3>BalimOOn Liqueurs</h3>
<section class=""content"">
    <div class=""card"">
        <div class=""row"">
            <div class=""col-12"">
                <div class=""card-header"">
                    <h4 class=""card-title"">Purchase Request - Rejected</h4>
                </div>
                <div class=""card-body"">
                    <div class=""form-group"">
                        <table id=""tabel5"" class=""table table-striped"">
                            <thead>
                                <tr>
                                    <th>PR Id</th>
                                    <th>Document No</th>
                                    <th>Requester</th>
                                    <th>Department</th>
                                    <th>Order Date</th>
                                    <th>Due Date</th>
                                    <th>Notes</th>
                                    <th>Rejected Notes</th>
                                    <th>Details</th>
 ");
            WriteLiteral(@"                               </tr>
                            </thead>
                            <tbody></tbody>
                        </table>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1477, 3358, true);
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
                url: ""/PurchaseRequest/GetPRListRejected"",
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
                { targets: ""no");
                WriteLiteral(@"-search"", searchable: false },
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
                            return moment(data).format(""dd");
                WriteLiteral(@"dd, DD-MM-YYYY HH:mm:ss"");
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
                { data: ""RejectedNotes"", name: ""RejectedNotes"" },
                {
                    render: function (data, type, full, meta) {
                        return ""<a href='#' onclick='PRDetails(\"""" + full.RequisitionHeaderId + ""\"")' class='btn btn-outline-info'><span class='pe-7s-info'> Details</span></a>"";

                    }
                }
            ]
        })
        $("".dataTables_scrollHeadInner"").");
                WriteLiteral(@"css({ ""width"": ""100%"" });
        $("".table "").css({ ""width"": ""100%"" });
    </script>
    <script>
    function PRDetails(RequisitionHeaderId) {
        window.location.href = ""/PurchaseRequest/DetilPRPostedView?RequisitionHeaderId="" + RequisitionHeaderId;
    }
    </script>
");
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
