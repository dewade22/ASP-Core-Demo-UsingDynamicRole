#pragma checksum "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement - Copy\Views\BMIPurchaseRequest\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7fda24d5aaca1b2a60950cc7876414eada30d51e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BMIPurchaseRequest_List), @"mvc.1.0.view", @"/Views/BMIPurchaseRequest/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/BMIPurchaseRequest/List.cshtml", typeof(AspNetCore.Views_BMIPurchaseRequest_List))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7fda24d5aaca1b2a60950cc7876414eada30d51e", @"/Views/BMIPurchaseRequest/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ca815501e2415492be7fd7738acfe7eb9493282", @"/Views/_ViewImports.cshtml")]
    public class Views_BMIPurchaseRequest_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Balimoon_E_Procurement.Models.BalimoonBMI.ViewModel.PurchaseRequestBMIVM>
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
#line 2 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement - Copy\Views\BMIPurchaseRequest\List.cshtml"
  
    ViewData["Title"] = "List";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(168, 1262, true);
            WriteLiteral(@"
<br />
<h2>Balimoon Indonesia</h2>
<section class=""content"">
    <div class=""card"">
        <div class=""row"">
            <div class=""col-12"">
                <div class=""card-header"">
                    <h3 class=""card-title"">
                        List of Balimoon Indonesia PR
                    </h3>
                </div>
                <div class=""card-body"">
                    <table id=""tabel5"" class=""table table-bordered table-striped table-responsive-md table-responsive-sm"" width=""100%"" cellspacing=""0"">
                        <thead>
                            <tr>
                                <th>PR Header ID</th>
                                <th>Document No</th>
                                <th>Requster</th>
                                <th>Department</th>
                                <th>Order Date</th>
                                <th>Due Date</th>
                                <th>Notes</th>
                                <th>Details</th>
   ");
            WriteLiteral("                         </tr>\r\n                        </thead>\r\n                        <tbody id=\"SetPRList\"></tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1447, 7886, true);
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
                url: ""/BMIPurchaseRequest/GetPRList"",
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
                WriteLiteral(@"             {
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
                WriteLiteral(@"                 }
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
                        return ""<a href='#' onclick='PRDetails(\"""" + full.RequisitionHeaderId + ""\"")' class='btn btn-outline-info'><span class='pe-7s-info'> Details</span></a>"";
                    }
                }
            ]
        })
        $("".dataTables_scrollHeadInner"").css({""width"":""100%""});
        $("".table "").css({""width"":""100%""});

        //show detail PR to Pop");
                WriteLiteral(@"Up Modal Dialog
        function PRDetails(RequisitionHeaderId) {
            var url = ""/BMIPurchaseRequest/GetPR?RequisitionHeaderId="" + RequisitionHeaderId;
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
                WriteLiteral(@"        })
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
                    url: ""/BMIPurchaseRequest/GetPRDetails?RequisitionHeaderId="" +RequisitionHeaderId,
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
");
                WriteLiteral(@"                    { targets: ""no-search"", searchable: false },
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
                    { data: ""UnitCost"", render: $.fn.dataTable.render.number(',', '.', 2) },
                    { data: ""CostAmount"", render: $.fn.dataTable.render.number(',', '.', 2) }
                ],
                footerCallback: function (row, data, start, end, display) {
                    var api = this.api(), data;
   ");
                WriteLiteral(@"                 var numFormat = $.fn.dataTable.render.number( '\,', '.', 2 ).display;
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
                    // Sum Current Page
                    pageTotal = api
                        .column(4, { page: 'current'})
                        .data()
                        .reduce(function (a, b) {
                            return intVal(a) + intVal(b);
                        }, 0);
                    // Up");
                WriteLiteral(@"date footer 1
                    $( api.column( 4 ).footer() ).html(
                        numFormat(total)
                    );
                }
            })
            $("".dataTables_scrollHeadInner"").css({""width"":""100%""});
            $("".table "").css({""width"":""100%""});
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
            BeginContext(9336, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Styles", async() => {
                BeginContext(9354, 444, true);
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
                BeginContext(9798, 4286, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7fda24d5aaca1b2a60950cc7876414eada30d51e14663", async() => {
                    BeginContext(9814, 82, true);
                    WriteLiteral("\r\n                        <fieldset id=\"SubmitForm\">\r\n                            ");
                    EndContext();
                    BeginContext(9897, 89, false);
#line 253 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement - Copy\Views\BMIPurchaseRequest\List.cshtml"
                       Write(Html.HiddenFor(a => a.HeaderTbl.RequisitionHeaderId, new { @id = "RequisitionHeaderId" }));

#line default
#line hidden
                    EndContext();
                    BeginContext(9986, 156, true);
                    WriteLiteral("\r\n                            <div class=\"form-group\">\r\n                                <label>Purchase Request No</label>\r\n                                ");
                    EndContext();
                    BeginContext(10143, 127, false);
#line 256 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement - Copy\Views\BMIPurchaseRequest\List.cshtml"
                           Write(Html.TextBoxFor(a => a.HeaderTbl.RequisitionNo, new { @id = "RequisitionNo", @class = "form-control", @readonly = "readonly" }));

#line default
#line hidden
                    EndContext();
                    BeginContext(10270, 244, true);
                    WriteLiteral("\r\n                            </div>\r\n                            <div class=\"form-row\">\r\n                                <div class=\"col-md-6\">\r\n                                    <label>Requester</label>\r\n                                    ");
                    EndContext();
                    BeginContext(10515, 123, false);
#line 261 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement - Copy\Views\BMIPurchaseRequest\List.cshtml"
                               Write(Html.TextBoxFor(a => a.HeaderTbl.RequesterId, new { @id = "RequesterID", @class = "form-control", @readonly = "readonly" }));

#line default
#line hidden
                    EndContext();
                    BeginContext(10638, 197, true);
                    WriteLiteral("\r\n                                </div>\r\n                                <div class=\"col-md-6\">\r\n                                    <label>Department</label>\r\n                                    ");
                    EndContext();
                    BeginContext(10836, 145, false);
#line 265 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement - Copy\Views\BMIPurchaseRequest\List.cshtml"
                               Write(Html.TextBoxFor(a => a.HeaderTbl.ShortcutDimension1Code, new { @id = "ShortcutDimension1Code", @class = "form-control", @readonly = "readonly" }));

#line default
#line hidden
                    EndContext();
                    BeginContext(10981, 285, true);
                    WriteLiteral(@"
                                </div>
                            </div>
                            <div class=""form-row"">
                                <div class=""col-md-6"">
                                    <label>Order Date</label>
                                    ");
                    EndContext();
                    BeginContext(11267, 144, false);
#line 271 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement - Copy\Views\BMIPurchaseRequest\List.cshtml"
                               Write(Html.TextBoxFor(a => a.HeaderTbl.OrderDate, new { Type = "datetime-local", @id = "OrderDate", @class = "form-control", @readonly = "readonly" }));

#line default
#line hidden
                    EndContext();
                    BeginContext(11411, 195, true);
                    WriteLiteral("\r\n                                </div>\r\n                                <div class=\"col-md-6\">\r\n                                    <label>Due Date</label>\r\n                                    ");
                    EndContext();
                    BeginContext(11607, 140, false);
#line 275 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement - Copy\Views\BMIPurchaseRequest\List.cshtml"
                               Write(Html.TextBoxFor(a => a.HeaderTbl.DueDate, new { Type = "datetime-local", @id = "DueDate", @class = "form-control", @readonly = "readonly" }));

#line default
#line hidden
                    EndContext();
                    BeginContext(11747, 218, true);
                    WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                            <div class=\"form-group\">\r\n                                <label>Notes</label>\r\n                                ");
                    EndContext();
                    BeginContext(11966, 126, false);
#line 280 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement - Copy\Views\BMIPurchaseRequest\List.cshtml"
                           Write(Html.TextAreaFor(a => a.HeaderTbl.RequestNotes, new { @id = "RequestNotes", @class = "form-control", @readonly = "readonly" }));

#line default
#line hidden
                    EndContext();
                    BeginContext(12092, 241, true);
                    WriteLiteral("\r\n                            </div>\r\n                            <div class=\"form-row\">\r\n                                <div class=\"col-md-6\">\r\n                                    <label>Status</label>\r\n                                    ");
                    EndContext();
                    BeginContext(12334, 113, false);
#line 285 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement - Copy\Views\BMIPurchaseRequest\List.cshtml"
                               Write(Html.TextBoxFor(a => a.HeaderTbl.Status, new { @id = "Status", @class = "form-control", @readonly = "readonly" }));

#line default
#line hidden
                    EndContext();
                    BeginContext(12447, 195, true);
                    WriteLiteral("\r\n                                </div>\r\n                                <div class=\"col-md-6\">\r\n                                    <label>Priority</label>\r\n                                    ");
                    EndContext();
                    BeginContext(12643, 117, false);
#line 289 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement - Copy\Views\BMIPurchaseRequest\List.cshtml"
                               Write(Html.TextBoxFor(a => a.HeaderTbl.Priority, new { @id = "Priority", @class = "form-control", @readonly = "readonly" }));

#line default
#line hidden
                    EndContext();
                    BeginContext(12760, 1317, true);
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
                                            <th>Unit Cost</th>
                                            <th>Cost Amount</th>
                                        </tr>
                                    </thead>
                                    <tbody></tbody>
                                    <tfoot>
                                        <tr>
                                            <th colspan=""4"" style=""text-align:right"">Tot");
                    WriteLiteral(@"al:</th>
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
                BeginContext(14084, 247, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Balimoon_E_Procurement.Models.BalimoonBMI.ViewModel.PurchaseRequestBMIVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
