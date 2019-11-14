#pragma checksum "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\PurchaseRequest\MyReleasePR.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "78c807792216e651ae80024c2bc90897d1dfbf4a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PurchaseRequest_MyReleasePR), @"mvc.1.0.view", @"/Views/PurchaseRequest/MyReleasePR.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/PurchaseRequest/MyReleasePR.cshtml", typeof(AspNetCore.Views_PurchaseRequest_MyReleasePR))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78c807792216e651ae80024c2bc90897d1dfbf4a", @"/Views/PurchaseRequest/MyReleasePR.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ca815501e2415492be7fd7738acfe7eb9493282", @"/Views/_ViewImports.cshtml")]
    public class Views_PurchaseRequest_MyReleasePR : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Balimoon_E_Procurement.Models.BalimoonBML.ViewModel.PurchaseRequestVM>
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
#line 2 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\PurchaseRequest\MyReleasePR.cshtml"
  
    ViewData["Title"] = "MyReleasePR";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(173, 1099, true);
            WriteLiteral(@"
<h2>BalimOOn Liqueurs</h2>
<section class=""content"">
    <div class=""card"">
        <div class=""row"">
            <div class=""col-12"">
                <div class=""card-header"">
                    <h3 class=""card-title"">MY PR - Release</h3>
                </div>
                <div class=""card-body"">
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
                            </tr>
                        </thead>
                        <tbody></tbody>
                    </table>
         ");
            WriteLiteral("       </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1289, 8342, true);
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
                url: ""/PurchaseRequest/MyReleasePRCode"",
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
                { targets: ""no-search"", searchable: f");
                WriteLiteral(@"alse },
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
                            return moment(data).format(""dddd, DD-MM-YYYY"");
    ");
                WriteLiteral(@"                    }
                        return data;
                    }
                },
                {
                    data: ""DueDate"",
                    render: function (data, type, row) {
                        if (type === ""display"" || type === ""filter"") {
                            return moment(data).format(""dddd, DD-MM-YYYY"");
                        }
                        return data;
                    }
                },
                { data: ""RequestNotes"", name: ""RequestNotes"" },

                {
                    render: function (data, type, full, meta) {
                        return ""<a href='#' onclick='PRDetails(\"""" + full.RequisitionHeaderId + ""\"")' class='btn btn-outline-info'><span class='pe-7s-info'> Details</span></a>"";

                    }
                }
            ]
        })
        $("".dataTables_scrollHeadInner"").css({ ""width"": ""100%"" });
        $("".table "").css({ ""width"": ""100%"" });
         //show detail PR to Po");
                WriteLiteral(@"pUp Modal Dialog
        function PRDetails(RequisitionHeaderId) {
            var url = ""/PurchaseRequest/GetPR?RequisitionHeaderId="" + RequisitionHeaderId;
            $(""#exampleModalLongTitle"").html(""Detail PR"");
            $(""#MyLargeModal"").modal();
            $.ajax({
                type: ""GET"",
                url: url,
                success: function (data) {
                    var obj = JSON.parse(data);
                    $(""#RequisitionHeaderId"").val(obj.RequisitionHeaderId);
                    $(""#RequisitionNo"").val(obj.RequisitionNo);
                    $(""#RequesterID"").val(obj.RequesterID);
                    $(""#ShortcutDimension1Code"").val(obj.ShortcutDimension1Code);
                    $(""#OrderDate"").val(obj.OrderDate);
                    $(""#DueDate"").val(obj.DueDate);
                    $(""#RequestNotes"").val(obj.RequestNotes);
                    $(""#Status"").val(obj.Status);
                    $(""#Priority"").val(obj.Priority);
                }
      ");
                WriteLiteral(@"      })
            //Get PR Line with JSON (Modal Tabel)
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
                    url: ""/PurchaseRequest/GetPRDetails?RequisitionHeaderId="" + RequisitionHeaderId,
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
                    { targets: ""no-sort"", o");
                WriteLiteral(@"rderable: false },
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
                    { data: ""DocumentNo"" },
                    { data: ""Description"" },
                    { data: ""Quantity"" },
                    { data: ""CurrencyCode"" },
                    { data: ""UnitCost"", render: $.fn.dataTable.render.number(',', '.', 2) },
                    { data: ""CostAmount"", render: $.fn.dataTable.render.number(',', '.', 2) }
                ],
                footerCallback: function (row, data, start, en");
                WriteLiteral(@"d, display) {
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
                        .column(4)
                        .data()
                        .reduce(function (a, b) {
                            return intVal(a) + intVal(b);
                        }, 0);
                    total2 = api
                        .column(5)
                        .data()
                        .reduce(function (a, b) {
                            return intVal(a) + intVal(b);
                        }, 0);
                    // S");
                WriteLiteral(@"um Current Page
                    pageTotal = api
                        .column(4, { page: 'current' })
                        .data()
                        .reduce(function (a, b) {
                            return intVal(a) + intVal(b);
                        }, 0);
                    // Update footer 1
                    $(api.column(4).footer()).html(
                        numFormat(total)
                    );
                    $(api.column(5).footer()).html(
                        numFormat(total2)
                    );
                }
            })
        }
        $("".dataTables_scrollHeadInner"").css({ ""width"": ""100%"" });
        $("".table "").css({ ""width"": ""100%"" });

        //on close event
        $('#MyLargeModal').on('hidden.bs.modal', function () {
            $('#tabel6').dataTable().fnDestroy();
            $(this)
                .find(""input[type=text],input[type=email],textarea,select"")
                .val('')
                .end()
      ");
                WriteLiteral("          .find(\"input[type=checkbox], input[type=radio]\")\r\n                .prop(\"checked\", \"\")\r\n                .end();\r\n        })\r\n    </script>\r\n");
                EndContext();
            }
            );
            DefineSection("Styles", async() => {
                BeginContext(9650, 444, true);
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
                BeginContext(10094, 4544, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "78c807792216e651ae80024c2bc90897d1dfbf4a14892", async() => {
                    BeginContext(10110, 82, true);
                    WriteLiteral("\r\n                        <fieldset id=\"SubmitForm\">\r\n                            ");
                    EndContext();
                    BeginContext(10193, 89, false);
#line 262 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\PurchaseRequest\MyReleasePR.cshtml"
                       Write(Html.HiddenFor(a => a.HeaderTbl.RequisitionHeaderId, new { @id = "RequisitionHeaderId" }));

#line default
#line hidden
                    EndContext();
                    BeginContext(10282, 156, true);
                    WriteLiteral("\r\n                            <div class=\"form-group\">\r\n                                <label>Purchase Request No</label>\r\n                                ");
                    EndContext();
                    BeginContext(10439, 127, false);
#line 265 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\PurchaseRequest\MyReleasePR.cshtml"
                           Write(Html.TextBoxFor(a => a.HeaderTbl.RequisitionNo, new { @id = "RequisitionNo", @class = "form-control", @readonly = "readonly" }));

#line default
#line hidden
                    EndContext();
                    BeginContext(10566, 244, true);
                    WriteLiteral("\r\n                            </div>\r\n                            <div class=\"form-row\">\r\n                                <div class=\"col-md-6\">\r\n                                    <label>Requester</label>\r\n                                    ");
                    EndContext();
                    BeginContext(10811, 123, false);
#line 270 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\PurchaseRequest\MyReleasePR.cshtml"
                               Write(Html.TextBoxFor(a => a.HeaderTbl.RequesterId, new { @id = "RequesterID", @class = "form-control", @readonly = "readonly" }));

#line default
#line hidden
                    EndContext();
                    BeginContext(10934, 197, true);
                    WriteLiteral("\r\n                                </div>\r\n                                <div class=\"col-md-6\">\r\n                                    <label>Department</label>\r\n                                    ");
                    EndContext();
                    BeginContext(11132, 145, false);
#line 274 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\PurchaseRequest\MyReleasePR.cshtml"
                               Write(Html.TextBoxFor(a => a.HeaderTbl.ShortcutDimension1Code, new { @id = "ShortcutDimension1Code", @class = "form-control", @readonly = "readonly" }));

#line default
#line hidden
                    EndContext();
                    BeginContext(11277, 285, true);
                    WriteLiteral(@"
                                </div>
                            </div>
                            <div class=""form-row"">
                                <div class=""col-md-6"">
                                    <label>Order Date</label>
                                    ");
                    EndContext();
                    BeginContext(11563, 144, false);
#line 280 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\PurchaseRequest\MyReleasePR.cshtml"
                               Write(Html.TextBoxFor(a => a.HeaderTbl.OrderDate, new { Type = "datetime-local", @id = "OrderDate", @class = "form-control", @readonly = "readonly" }));

#line default
#line hidden
                    EndContext();
                    BeginContext(11707, 195, true);
                    WriteLiteral("\r\n                                </div>\r\n                                <div class=\"col-md-6\">\r\n                                    <label>Due Date</label>\r\n                                    ");
                    EndContext();
                    BeginContext(11903, 140, false);
#line 284 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\PurchaseRequest\MyReleasePR.cshtml"
                               Write(Html.TextBoxFor(a => a.HeaderTbl.DueDate, new { Type = "datetime-local", @id = "DueDate", @class = "form-control", @readonly = "readonly" }));

#line default
#line hidden
                    EndContext();
                    BeginContext(12043, 218, true);
                    WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                            <div class=\"form-group\">\r\n                                <label>Notes</label>\r\n                                ");
                    EndContext();
                    BeginContext(12262, 126, false);
#line 289 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\PurchaseRequest\MyReleasePR.cshtml"
                           Write(Html.TextAreaFor(a => a.HeaderTbl.RequestNotes, new { @id = "RequestNotes", @class = "form-control", @readonly = "readonly" }));

#line default
#line hidden
                    EndContext();
                    BeginContext(12388, 241, true);
                    WriteLiteral("\r\n                            </div>\r\n                            <div class=\"form-row\">\r\n                                <div class=\"col-md-6\">\r\n                                    <label>Status</label>\r\n                                    ");
                    EndContext();
                    BeginContext(12630, 182, false);
#line 294 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\PurchaseRequest\MyReleasePR.cshtml"
                               Write(Html.DropDownListFor(a => a.HeaderTbl.Status, ViewBag.ListOfStatus as SelectList, "", new { @id = "Status", @class = "form-control", @readonly = "readonly", @disabled = "disabled" }));

#line default
#line hidden
                    EndContext();
                    BeginContext(12812, 195, true);
                    WriteLiteral("\r\n                                </div>\r\n                                <div class=\"col-md-6\">\r\n                                    <label>Priority</label>\r\n                                    ");
                    EndContext();
                    BeginContext(13008, 188, false);
#line 298 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\PurchaseRequest\MyReleasePR.cshtml"
                               Write(Html.DropDownListFor(a => a.HeaderTbl.Priority, ViewBag.ListOfPriority as SelectList, "", new { @id = "Priority", @class = "form-control", @readonly = "readonly", @disabled = "disabled" }));

#line default
#line hidden
                    EndContext();
                    BeginContext(13196, 1435, true);
                    WriteLiteral(@"
                                </div>
                            </div>
                            <div class=""form-group"">
                                <label>Detail Item</label>
                                <table id=""tabel6"" class=""table table-striped"" style=""width:100%"">
                                    <thead>
                                        <tr>
                                            <th>Item No</th>
                                            <th>Description</th>
                                            <th>Qty</th>
                                            <th>Currency</th>
                                            <th>Unit Cost</th>
                                            <th>Cost Amount</th>
                                        </tr>
                                    </thead>
                                    <tbody></tbody>
                                    <tfoot>
                                        <tr>
                         ");
                    WriteLiteral(@"                   <th colspan=""4"" style=""text-align:right"">Total:</th>
                                            <th></th>
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
                BeginContext(14638, 247, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Balimoon_E_Procurement.Models.BalimoonBML.ViewModel.PurchaseRequestVM> Html { get; private set; }
    }
}
#pragma warning restore 1591