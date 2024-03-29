#pragma checksum "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\BMLPurchaseOrder\PurchasingIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a23d4adc9c7fbb4ef73deeb143c1ea9bf4e66da8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BMLPurchaseOrder_PurchasingIndex), @"mvc.1.0.view", @"/Views/BMLPurchaseOrder/PurchasingIndex.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/BMLPurchaseOrder/PurchasingIndex.cshtml", typeof(AspNetCore.Views_BMLPurchaseOrder_PurchasingIndex))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a23d4adc9c7fbb4ef73deeb143c1ea9bf4e66da8", @"/Views/BMLPurchaseOrder/PurchasingIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ca815501e2415492be7fd7738acfe7eb9493282", @"/Views/_ViewImports.cshtml")]
    public class Views_BMLPurchaseOrder_PurchasingIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Balimoon_E_Procurement.Models.BalimoonBML.ViewModel.BMLPurchaseOrderVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\BMLPurchaseOrder\PurchasingIndex.cshtml"
  
    ViewData["Title"] = "PR Ready Create";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(177, 1037, true);
            WriteLiteral(@"
<h2>BalimOOn Liqueurs</h2>
<section class=""content"">
    <div class=""card"">
        <div class=""row"">
            <div class=""col-12"">
                <div class=""card-header"">
                    <h3 class=""card-title"">PR Ready To Create</h3>
                </div>
                <div class=""card-body"">
                    <table class=""table table-warning"" id=""MySimpleTable"">
                        <thead>
                            <tr>
                                <th>PR ID</th>
                                <th>PR No.</th>
                                <th>Requester</th>
                                <th>Department</th>
                                <th>Order Date</th>
                                <th>Notes</th>
                                <th>Action</th>
                            </tr>
                        </thead>
                        <tbody></tbody>
                    </table>
                </div>
            </div>
        </div>
    </div>");
            WriteLiteral("\n</section>\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1231, 2348, true);
                WriteLiteral(@"
<script>
    $.fn.dataTable.moment(""DD/MM/YYYY HH:mm:ss"");
    $.fn.dataTable.moment(""DD/MM/YYYY"");
    $(""#MySimpleTable"").DataTable({
        //Design
        stateSave: true,
        autoWidth: true,
        scrollX:true,

        //serverside
        processing: true,
        serverSide: true,

        //Paging Setup
        paging: true,

        //searching Setup
        searching: { regex: true },

        //ajax
        ajax: {
            url: ""/BMLPurchaseOrder/GetPRReadyPO"",
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
                targets: ""trim"",
                render: function (data, type, full, meta) {
                    if (t");
                WriteLiteral(@"ype === ""display"") {
                        data = strtrunc(data, 10);
                    }
                    return data;
                }
            },
            { targets: ""data-type"", type: ""date-eu"" }
        ],
        columns: [
            { data: ""PRID"", isIdentity: true, visible: false },
            { data: ""PRNo"" },
            { data: ""Requester"" },
            { data: ""Departement"" },
            {
                data: ""OrderDate"", render: function(data, type) {
                    if (type === ""display"" || type === ""filter"") {
                        return moment(data).format(""ddd, DD-MM-YYYY"");
                    }
                    return data;
                }
            },
            { data: ""Notes"" },
            {
                render: function (data, type, full, meta) {
                    return ""<a href='#' onclick='Show(\"""" + full.PRID + ""\"")' class='btn btn-outline-info'><span class='pe-7s-info'> Details</span></a>"";
                }
     ");
                WriteLiteral(@"       }
        ]
    })
    $("".dataTables_scrollHeadInner"").css({ ""width"": ""100%"" });
    $("".table "").css({ ""width"": ""100%"" });
</script>
    <script>
        function Show(PRID) {
            window.location.href = ""/BMLPurchaseOrder/DetilPROK?PRID="" + PRID;
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Balimoon_E_Procurement.Models.BalimoonBML.ViewModel.BMLPurchaseOrderVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
