#pragma checksum "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\BMIPurchaseOrder\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d853fa9382074d3fdc98cb5e6fd6967f08b5342"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BMIPurchaseOrder_List), @"mvc.1.0.view", @"/Views/BMIPurchaseOrder/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/BMIPurchaseOrder/List.cshtml", typeof(AspNetCore.Views_BMIPurchaseOrder_List))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d853fa9382074d3fdc98cb5e6fd6967f08b5342", @"/Views/BMIPurchaseOrder/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ca815501e2415492be7fd7738acfe7eb9493282", @"/Views/_ViewImports.cshtml")]
    public class Views_BMIPurchaseOrder_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Balimoon_E_Procurement.Models.BalimoonBMI.ViewModel.BMIPurchaseOrderVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\BMIPurchaseOrder\List.cshtml"
  
    ViewData["Title"] = "List";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(166, 1122, true);
            WriteLiteral(@"
<br />
<h2>BalimOOn Indonesia</h2>
<section class=""content"">
    <div class=""card"">
        <div class=""row"">
            <div class=""col-12"">
                <div class=""card-header"">
                    <h3 class=""card-title"">Purchase Order List</h3>
                </div>
                <div class=""card-body"">
                    <table id=""tabel5"" class=""table table-bordered table-striped"">
                        <thead>
                            <tr>
                                <th>PO Id</th>
                                <th>PO Number</th>
                                <th>PR Number</th>
                                <th>Vendor</th>
                                <th>Order Date</th>
                                <th>Expected Receive Date</th>
                                <th>Amount</th>
                                <th>Details</th>
                            </tr>
                        </thead>
                        <tbody></tbody>
                  ");
            WriteLiteral("  </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1305, 7758, true);
                WriteLiteral(@"
    <script>
        $.fn.dataTable.moment(""DD/MM/YYYY HH:mm:ss"");
        $.fn.dataTable.moment(""DD/MM/YYYY"");
        //datatable pada index
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
                url: ""/BMIPurchaseOrder/GetBMIPOList"",
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
                { targets: ""no-sea");
                WriteLiteral(@"rch"", searchable: false },
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
                { data: ""PurchaseHeaderId"", isIdentity: true, visible: false },
                { data: ""No"" },
                { data: ""RefPrno"" },
                { data: ""BuyfromVendorName"" },
                {
                    data: ""OrderDate"", render: function (data, type, row) {
                        if (type === ""display"" || type === ""filter"") {
                            return moment(data).format(""dddd, DD-MM-YYYY"");
                        }
                        return data;
                    }
                },
     ");
                WriteLiteral(@"           {
                    data: ""ExpectedReceiptDate"", render: function (data, type) {
                        if (type === ""display"" || type === ""filter"") {
                            return moment(data).format(""dddd, DD-MM-YYYY"");
                        }
                        return data;
                    }
                },
                { data: ""Amount"", render: $.fn.dataTable.render.number(',', '.', 2) },
                {
                    render: function (data, type, full, meta) {
                        return ""<a href='#' onclick='PODetails(\"""" + full.PurchaseHeaderId + ""\"")' class='btn btn-outline-info'><span class='pe-7s-info'> Details</span></a>"";
                    }
                }
            ]
        })
        $("".dataTables_scrollHeadInner"").css({ ""width"": ""100%"" });
        $("".table "").css({ ""width"": ""100%"" });

        //show detail PR to PopUp Modal Dialog
        function PODetails(PurchaseHeaderId) {
            var url = ""/BMIPurchaseOrder");
                WriteLiteral(@"/GetPO?PurchaseHeaderId="" + PurchaseHeaderId;
            $(""#exampleModalLongTitle"").html(""Detail PO"");
            $(""#MyLargeModal"").modal();
            $.ajax({
                type: ""GET"",
                url: url,
                success: function (data) {
                    var obj = JSON.parse(data);
                    $(""#PurchaseHeaderId"").val(obj.PurchaseHeaderId);
                    $(""#DocumentNo"").val(obj.DocumentNo);
                    $(""#RefPRNo"").val(obj.RefPRNo);
                    $(""#DimensionValue"").val(obj.DimensionValue);
                    $(""#AssignedUserI"").val(obj.AssignedUserI);
                    $(""#CreatedBy"").val(obj.CreatedBy);
                    $(""#OrderDate"").val(obj.OrderDate);
                    $(""#ExpectedReceiptDate"").val(obj.ExpectedReceiptDate);
                    $(""#VendorName"").val(obj.VendorName);
                    $(""#Amount"").val(obj.Amount);
                    $(""#AmountIncludingVAT"").val(obj.AmountIncludingVAT);
             ");
                WriteLiteral(@"   }
            })
            //Get PO Line
            $(""#tabel6"").DataTable({
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
                    url: ""/BMIPurchaseOrder/GetPODetails?PurchaseHeaderId="" + PurchaseHeaderId,
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
                    { targets: ""no-sort"", orderable: false }");
                WriteLiteral(@",
                    { targets: ""no-search"", searchable: false },
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
                    { data: ""PurchaseLineId"", isIdentity: true, searchable: false, visible: false },
                    { data: ""Description"" },
                    { data: ""VendorName"" },
                    { data: ""Quantity"" },
                    { data: ""QuantityReceive"" },
                    { data: ""Amount"", render: $.fn.dataTable.render.number(',', '.', 2) },
                    { data: ""AmountVAT"", render: $.fn.dataTable.render.number(',', '.', 2) ");
                WriteLiteral(@"}
                ],
                footerCallback: function (row, data, start, end, display) {
                    var api = this.api(), data;
                    var numFormat = $.fn.dataTable.render.number('\,', '.', 2).display;
                    //Get Integer Data
                    var intVal = function (i) {
                        return typeof i === 'string' ?
                            i.replace(/[\$,]/g, '') * 1 :
                            typeof i === 'number' ?
                                i : 0;
                    };
                    //Sum All Pages
                    total = api
                        .column(6)
                        .data()
                        .reduce(function (a, b) {
                            return intVal(a) + intVal(b);
                        }, 0);
                    // Update footer 1
                    $(api.column(6).footer()).html(
                        numFormat(total)
                    );
                }
      ");
                WriteLiteral(@"      })
            $("".dataTables_scrollHeadInner"").css({ ""width"": ""100%"" });
            $("".table "").css({ ""width"": ""100%"" });
        }
        //on close event
        $('#MyLargeModal').on('hidden.bs.modal', function () {
            $('#tabel6').dataTable().fnDestroy();
            $(this)
                .find(""input[type=text],input[type=email],textarea,select"")
                .val('')
                .end()
                .find(""input[type=checkbox], input[type=radio]"")
                .prop(""checked"", """")
                .end();
        })
    </script>
");
                EndContext();
            }
            );
            BeginContext(9066, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Styles", async() => {
                BeginContext(9084, 444, true);
                WriteLiteral(@"
    <div class=""modal fade bd-example-modal-lg"" id=""MyLargeModal"">
        <div class=""modal-dialog modal-lg"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h4 class=""modal-title"" id=""exampleModalLongTitle""></h4>
                    <a href=""#"" class=""close"" data-dismiss=""modal"">&times;</a>
                </div>
                <div class=""modal-body"">
                    ");
                EndContext();
                BeginContext(9528, 5244, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d853fa9382074d3fdc98cb5e6fd6967f08b534214335", async() => {
                    BeginContext(9544, 82, true);
                    WriteLiteral("\r\n                        <fieldset id=\"SubmitForm\">\r\n                            ");
                    EndContext();
                    BeginContext(9627, 89, false);
#line 245 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\BMIPurchaseOrder\List.cshtml"
                       Write(Html.HiddenFor(a => a.purchasesHeader.PurchaseHeaderId, new { @id = "PurchaseHeaderId" }));

#line default
#line hidden
                    EndContext();
                    BeginContext(9716, 208, true);
                    WriteLiteral("\r\n                            <div class=\"form-row\">\r\n                                <div class=\"col-md-6\">\r\n                                    <label>PO Number</label>\r\n                                    ");
                    EndContext();
                    BeginContext(9925, 125, false);
#line 249 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\BMIPurchaseOrder\List.cshtml"
                               Write(Html.TextBoxFor(a => a.purchasesLine.DocumentNo, new { @id = "DocumentNo", @class = "form-control", @readonly = "readonly" }));

#line default
#line hidden
                    EndContext();
                    BeginContext(10050, 196, true);
                    WriteLiteral("\r\n                                </div>\r\n                                <div class=\"col-md-6\">\r\n                                    <label>PR Number</label>\r\n                                    ");
                    EndContext();
                    BeginContext(10247, 121, false);
#line 253 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\BMIPurchaseOrder\List.cshtml"
                               Write(Html.TextBoxFor(a => a.purchasesHeader.RefPrno, new { @id = "RefPRNo", @class = "form-control", @readonly = "readonly" }));

#line default
#line hidden
                    EndContext();
                    BeginContext(10368, 287, true);
                    WriteLiteral(@"
                                </div>
                            </div>
                            <div class=""form-row"">
                                <div class=""col-md-4"">
                                    <label>Requester PR</label>
                                    ");
                    EndContext();
                    BeginContext(10656, 135, false);
#line 259 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\BMIPurchaseOrder\List.cshtml"
                               Write(Html.TextBoxFor(a => a.purchasesHeader.AssignedUserId, new { @id = "AssignedUserId", @class = "form-control", @readonly = "readonly" }));

#line default
#line hidden
                    EndContext();
                    BeginContext(10791, 200, true);
                    WriteLiteral("\r\n                                </div>\r\n                                <div class=\"col-md-4\">\r\n                                    <label>PO Created By</label>\r\n                                    ");
                    EndContext();
                    BeginContext(10992, 125, false);
#line 263 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\BMIPurchaseOrder\List.cshtml"
                               Write(Html.TextBoxFor(a => a.purchasesHeader.CreatedBy, new { @id = "CreatedBy", @class = "form-control", @readonly = "readonly" }));

#line default
#line hidden
                    EndContext();
                    BeginContext(11117, 195, true);
                    WriteLiteral("\r\n                                </div>\r\n                                <div class=\"col-md-4\">\r\n                                    <label>Location</label>\r\n                                    ");
                    EndContext();
                    BeginContext(11313, 141, false);
#line 267 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\BMIPurchaseOrder\List.cshtml"
                               Write(Html.TextBoxFor(a => a.purchasesLine.ShortcutDimension1Code, new { @id = "DimensionValue", @class = "form-control", @readonly = "readonly" }));

#line default
#line hidden
                    EndContext();
                    BeginContext(11454, 285, true);
                    WriteLiteral(@"
                                </div>
                            </div>
                            <div class=""form-row"">
                                <div class=""col-md-6"">
                                    <label>Order Date</label>
                                    ");
                    EndContext();
                    BeginContext(11740, 151, false);
#line 273 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\BMIPurchaseOrder\List.cshtml"
                               Write(Html.TextBoxFor(a => a.purchasesHeader.OrderDate, new { @id = "OrderDate", @class = "form-control", @readonly = "readonly", @Type = "datetime-local" }));

#line default
#line hidden
                    EndContext();
                    BeginContext(11891, 208, true);
                    WriteLiteral("\r\n                                </div>\r\n                                <div class=\"col-md-6\">\r\n                                    <label>Expected Receive Date</label>\r\n                                    ");
                    EndContext();
                    BeginContext(12100, 171, false);
#line 277 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\BMIPurchaseOrder\List.cshtml"
                               Write(Html.TextBoxFor(a => a.purchasesHeader.ExpectedReceiptDate, new { @id = "ExpectedReceiptDate", @class = "form-control", @readonly = "readonly", @Type = "datetime-local" }));

#line default
#line hidden
                    EndContext();
                    BeginContext(12271, 224, true);
                    WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                            <div class=\"form-group\">\r\n                                <label>Vendor Name</label>\r\n                                ");
                    EndContext();
                    BeginContext(12496, 126, false);
#line 282 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\BMIPurchaseOrder\List.cshtml"
                           Write(Html.TextBoxFor(a => a.purchasesHeader.PaytoName, new { @id = "VendorName", @class = "form-control", @readonly = "readonly" }));

#line default
#line hidden
                    EndContext();
                    BeginContext(12622, 241, true);
                    WriteLiteral("\r\n                            </div>\r\n                            <div class=\"form-row\">\r\n                                <div class=\"col-md-6\">\r\n                                    <label>Amount</label>\r\n                                    ");
                    EndContext();
                    BeginContext(12864, 119, false);
#line 287 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\BMIPurchaseOrder\List.cshtml"
                               Write(Html.TextBoxFor(a => a.purchasesHeader.Amount, new { @id = "Amount", @class = "form-control", @readonly = "readonly" }));

#line default
#line hidden
                    EndContext();
                    BeginContext(12983, 205, true);
                    WriteLiteral("\r\n                                </div>\r\n                                <div class=\"col-md-6\">\r\n                                    <label>Amount Include VAT</label>\r\n                                    ");
                    EndContext();
                    BeginContext(13189, 143, false);
#line 291 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\BMIPurchaseOrder\List.cshtml"
                               Write(Html.TextBoxFor(a => a.purchasesHeader.AmountIncludingVat, new { @id = "AmountIncludingVAT", @class = "form-control", @readonly = "readonly" }));

#line default
#line hidden
                    EndContext();
                    BeginContext(13332, 1433, true);
                    WriteLiteral(@"
                                </div>
                            </div>
                            <div><br /></div>
                            <div class=""form-group"">
                                <table id=""tabel6"" class=""table table-striped"">
                                    <thead>
                                        <tr>
                                            <th>PurchaseLineId</th>
                                            <th>Item Name</th>
                                            <th>Vendor</th>
                                            <th>Quantity</th>
                                            <th>Quantity Receive</th>
                                            <th>Amount</th>
                                            <th>Amount Including VAT</th>
                                        </tr>
                                    </thead>
                                    <tbody></tbody>
                                    <tfoot>
                  ");
                    WriteLiteral(@"                      <tr>
                                            <th colspan=""6"" style=""text-align:right"">Total:</th>
                                            <th></th>
                                        </tr>
                                    </tfoot>
                                </table>
                            </div>
                        </fieldset>
                    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(14772, 247, true);
                WriteLiteral("\r\n                </div>\r\n                <div class=\"modal-footer\">\r\n                    <button type=\"button\" class=\"btn btn-secondary\" data-dismiss=\"modal\">Close</button>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Balimoon_E_Procurement.Models.BalimoonBMI.ViewModel.BMIPurchaseOrderVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
