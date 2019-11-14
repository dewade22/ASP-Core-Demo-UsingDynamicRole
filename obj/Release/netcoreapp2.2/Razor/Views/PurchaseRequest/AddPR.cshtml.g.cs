#pragma checksum "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\PurchaseRequest\AddPR.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7347b79221506fcb021161b8b89e28958538b655"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PurchaseRequest_AddPR), @"mvc.1.0.view", @"/Views/PurchaseRequest/AddPR.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/PurchaseRequest/AddPR.cshtml", typeof(AspNetCore.Views_PurchaseRequest_AddPR))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7347b79221506fcb021161b8b89e28958538b655", @"/Views/PurchaseRequest/AddPR.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ca815501e2415492be7fd7738acfe7eb9493282", @"/Views/_ViewImports.cshtml")]
    public class Views_PurchaseRequest_AddPR : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Balimoon_E_Procurement.Models.BalimoonBML.ViewModel.PurchaseRequestVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form_edit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 4 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\PurchaseRequest\AddPR.cshtml"
  
    ViewData["Title"] = "AddPR";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(170, 1472, true);
            WriteLiteral(@"
<br />
<h2>BalimOOn Liqueurs</h2>
<section class=""content"">
    <div class=""card"">
        <div class=""row"">
            <div class=""col-12"">
                <div class=""card-header"">
                    <h3 class=""card-title"">Add Purchase Request</h3>
                </div>
                <div class=""card-body"">
                    <a href=""#"" data-toggle=""modal"" data-target=""#MyLargeModal"" class=""btn btn-outline-primary""><span class=""pe-7s-news-paper""></span>  Add PR</a>
                    <br />
                    <hr />
                    <h5 class=""card-text"">My Recently Open PR</h5>
                    <br />
                    <table id=""tabel5"" class=""table table-primary"">
                        <thead>
                            <tr>
                                <th>PR Header No</th>
                                <th>PR No</th>
                                <th>Requster</th>
                                <th>Department</th>
                                <th>O");
            WriteLiteral(@"rder Date</th>
                                <th>Due Date</th>
                                <th>Notes</th>
                                <th>Edit PR</th>
                                <th>Add/Edit Items</th>
                            </tr>
                        </thead>
                        <tbody></tbody>
                    </table>
                </div>
            </div>
        </div>
    </div>
</section>

");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1659, 10176, true);
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
                url: ""/PurchaseRequest/GetMyPR"",
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
                { targets: ""no-search"", se");
                WriteLiteral(@"archable: false },
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
                { data: ""RequisitionHeaderId"", isIdentity: true, visible: false },
                { data: ""RequisitionNo"" },
                { data: ""RequesterId"" },
                { data: ""ShortcutDimension1Code"" },
                {
                    data: ""OrderDate"", render: function (data, type, row) {
                        if (type === ""display"" || type === ""filter"") {
                            return moment(data).format(""dddd, DD-MM-YYYY"");
                        }
                        return data;
                    }
          ");
                WriteLiteral(@"      },
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
                        return ""<a href='#' onclick='EditHeader(\"""" + full.RequisitionHeaderId + ""\"")' class='btn btn-outline-info btn-block'><span class='fa fa-edit'></span></a>"";
                    }
                },
                {
                    render: function (data, type, full, meta) {
                        return ""<a href='#' onclick='AddLine(\"""" + full.RequisitionNo + ""\"")' class='btn btn-outline-info btn-block'><span class='fa fa-plus-circle'></span></a>"";
    ");
                WriteLiteral(@"                }
                }
            ]
        })

        $("".dataTables_scrollHeadInner"").css({ ""width"": ""100%"" });
        $("".table "").css({ ""width"": ""100%"" });
    </script>
    <script>
        //untuk membuat form edit
        //show detail PR to PopUp Modal Dialog
        function EditHeader(RequisitionHeaderId) {
            var url = ""/PurchaseRequest/EditHeader?RequisitionHeaderId="" + RequisitionHeaderId;
            $(""#exampleModalLongTitle"").html(""Edit PR Header"");
            $(""#My3rdLargeModal"").modal();
            $.ajax({
                type: ""GET"",
                url: url,
                success: function (data) {
                    var obj = JSON.parse(data);
                    $(""#RequisitionHeaderId1"").val(obj.RequisitionHeaderId);
                    $(""#ShortcutDimension1Code1"").val(obj.ShortcutDimension1Code);
                    $(""#ShortcutDimension1Code1"").trigger(""chosen:updated"");
                    $(""#ShortcutDimension2Code1"").val(obj.S");
                WriteLiteral(@"hortcutDimension2Code);
                    $(""#ShortcutDimension2Code1"").trigger(""chosen:updated"");
                    $(""#OrderDate1"").val(obj.OrderDate);
                    $(""#DueDate1"").val(obj.DueDate);
                    $(""#RequestNotes1"").val(obj.RequestNotes);
                    $(""#Priority1"").val(obj.Priority);
                    $(""#Priority1"").trigger(""chosen:updated"");
                    $(""#LocationCode1"").val(obj.LocationCode);
                    $(""#LocationCode1"").trigger(""chosen:updated"");
                    $(""#PRNO1"").val(obj.PRNO);
                    $(""#JudulModalEdit"").html(""Edit "" + obj.PRNO);
                }
            })
        }
    </script>
<script>
    //chosen Style
    $(""#LocationCode1"").chosen();
    $(""#LocationCode"").chosen();
    $(""#Priority1"").chosen();
    $(""#Priority"").chosen();
    $(""#ShortcutDimension1Code"").chosen();
    $(""#ShortcutDimension2Code"").chosen();
    $(""#ShortcutDimension2Code1"").chosen();
    $(""#ShortcutDimensi");
                WriteLiteral(@"on1Code1"").chosen();
    $('.chosen-container').css('width', '100%');
</script>
<script>
    //Add New Header
    $(function () {
        $(""#MyLargeModal form"").validate({
           
            rules: {
                ExpDate: {
                    required: true
                }
            },
            submitHandler: function (form) {
                Swal.fire({
                    title: 'Add New PR',
                    text: 'Are You Sure Want To Add New PR?',
                    type: 'info',
                    showCancelButton: true,
                    confirmButtonColor: '#002afc',
                    cancelButtonColor: '#fc0303',
                    confirmButtonText: 'Add'
                }).then((result) => {
                    if (result.value) {
                        $.ajax({
                            type: ""POST"",
                            url: ""/PurchaseRequest/AddHeader"",
                            data: $(form).serialize(),
                        ");
                WriteLiteral(@"    success: function (result) {
                                if (result == ""Sukses"") {
                                    Swal.fire(
                                        'Added!',
                                        'Your file has been saved.',
                                        'success'
                                    ).then((result) => {
                                        window.location.href = ""/PurchaseRequest/AddPR"";
                                        $(""#MyLargeModal"").modal(""hide"");
                                    })
                                }
                                else {
                                    Swal.fire({
                                        type: 'error',
                                        title: 'Oops...',
                                        text: 'Something went wrong!',
                                        footer: ''+result
                                    })
                                }
   ");
                WriteLiteral(@"                         }
                        })
                    }
                })
            }
        })
    })
</script>
<script>
    $(function () {
        $(""#My3rdLargeModal form"").validate({
           
            rules: {
                RequisitionHeaderId1: {
                    required: true
                }
            },
            submitHandler: function (form) {
                var PRNO = document.getElementById('PRNO1').value;
                Swal.fire({
                    title: 'Edit PR',
                    text: 'Are You Sure Want To Edit '+PRNO+'?',
                    type: 'info',
                    showCancelButton: true,
                    confirmButtonColor: '#002afc',
                    cancelButtonColor: '#fc0303',
                    confirmButtonText: 'Edit'
                }).then((result) => {
                    if (result.value) {
                        $.ajax({
                            type: ""POST"",
                   ");
                WriteLiteral(@"         url: ""/PurchaseRequest/EditHeaderProcess"",
                            data: $(form).serialize(),
                            success: function (result) {
                                if (result == ""Sukses"") {
                                    Swal.fire(
                                        'Edited!',
                                        'Your file has been saved.',
                                        'success'
                                    ).then((result) => {
                                        window.location.href = ""/PurchaseRequest/AddPR"";
                                        $(""#My3rdLargeModal"").modal(""hide"");
                                    })
                                }
                                else {
                                    Swal.fire({
                                        type: 'error',
                                        title: 'Oops...',
                                        text: 'Something went wrong!',
");
                WriteLiteral(@"                                        footer: ''+result
                                    })
                                }
                            }
                        })
                    }
                })
            }
        })
    })
    
</script>    
<script>
    //function untuk edit & add Items pindah page
    function AddLine(RequisitionNo) {
        Swal.fire({
            title: 'Add or Update Item In This PR',
            text: 'Are You Sure Want To Add or Update Item In '+RequisitionNo+'?',
            type: 'warning',
            showCancelButton: true,
            confirmButtonColor: '#002afc',
            cancelButtonColor: '#fc0303',
            confirmButtonText: 'Update'
        }).then((result) => {
            if (result.value) {
                window.location.href = ""/PurchaseRequest/EditLineSubmit?RequisitionNo="" + RequisitionNo;
            }
        })
    }
</script>
");
                EndContext();
            }
            );
            DefineSection("Styles", async() => {
                BeginContext(11854, 480, true);
                WriteLiteral(@"
    <!--Modal For Submit Header-->
    <div class=""modal fade bd-example-modal-lg"" id=""MyLargeModal"">
        <div class=""modal-dialog modal-lg"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h4 class=""modal-title"" id=""ModalTambah"">Add New PR</h4>
                    <a href=""#"" class=""close"" data-dismiss=""modal"">&times;</a>
                </div>
                <div class=""modal-body"">
                    ");
                EndContext();
                BeginContext(12334, 3224, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7347b79221506fcb021161b8b89e28958538b65517915", async() => {
                    BeginContext(12362, 259, true);
                    WriteLiteral(@"
                        <fieldset id=""SubmitForm"">
                            <div class=""form-row"">
                                <div class=""col-md-6"">
                                    <label>Due Date</label>
                                    ");
                    EndContext();
                    BeginContext(12622, 156, false);
#line 315 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\PurchaseRequest\AddPR.cshtml"
                               Write(Html.TextBoxFor(a => a.HeaderTbl.ExpirationDate, "{0:yyyy-MM-dd}", new { @id = "ExpDate", @class = "form-control", @type = "date", @required = "required" }));

#line default
#line hidden
                    EndContext();
                    BeginContext(12778, 195, true);
                    WriteLiteral("\r\n                                </div>\r\n                                <div class=\"col-md-6\">\r\n                                    <label>Priority</label>\r\n                                    ");
                    EndContext();
                    BeginContext(12974, 164, false);
#line 319 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\PurchaseRequest\AddPR.cshtml"
                               Write(Html.DropDownListFor(a => a.HeaderTbl.Priority, ViewBag.ListOfPriority as SelectList, "", new { @id = "Priority", @class = "form-control", @required = "required" }));

#line default
#line hidden
                    EndContext();
                    BeginContext(13138, 231, true);
                    WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                            <div class=\"form-group\">\r\n                                <label>Motive Requisition</label>\r\n                                ");
                    EndContext();
                    BeginContext(13370, 124, false);
#line 324 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\PurchaseRequest\AddPR.cshtml"
                           Write(Html.TextAreaFor(a => a.HeaderTbl.RequestNotes, new { @id = "RequestNotes", @class = "form-control", @required="required" }));

#line default
#line hidden
                    EndContext();
                    BeginContext(13494, 245, true);
                    WriteLiteral("\r\n                            </div>\r\n                            <div class=\"form-row\">\r\n                                <div class=\"col-md-6\">\r\n                                    <label>Dept. Code</label>\r\n                                    ");
                    EndContext();
                    BeginContext(13740, 194, false);
#line 329 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\PurchaseRequest\AddPR.cshtml"
                               Write(Html.DropDownListFor(a => a.HeaderTbl.ShortcutDimension1Code, ViewBag.ListOfDepartment as SelectList, "", new { @id = "ShortcutDimension1Code", @class = "form-control", @required = "required" }));

#line default
#line hidden
                    EndContext();
                    BeginContext(13934, 199, true);
                    WriteLiteral("\r\n                                </div>\r\n                                <div class=\"col-md-6\">\r\n                                    <label>Project Code</label>\r\n                                    ");
                    EndContext();
                    BeginContext(14134, 171, false);
#line 333 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\PurchaseRequest\AddPR.cshtml"
                               Write(Html.DropDownListFor(a => a.HeaderTbl.ShortcutDimension2Code, ViewBag.ListOfProjectCode as SelectList, "", new { @id = "ShortcutDimension2Code", @class = "form-control" }));

#line default
#line hidden
                    EndContext();
                    BeginContext(14305, 283, true);
                    WriteLiteral(@"
                                </div>
                            </div>
                            <div class=""form-row"">
                                <div class=""col-md-6"">
                                    <label>Location</label>
                                    ");
                    EndContext();
                    BeginContext(14589, 170, false);
#line 339 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\PurchaseRequest\AddPR.cshtml"
                               Write(Html.DropDownListFor(a => a.HeaderTbl.LocationCode, ViewBag.ListOfLocation as SelectList, "", new { @id = "LocationCode", @class = "form-control", @required="required" }));

#line default
#line hidden
                    EndContext();
                    BeginContext(14759, 198, true);
                    WriteLiteral("\r\n                                </div>\r\n                                <div class=\"col-md-6\">\r\n                                    <label>Last PO No.</label>\r\n                                    ");
                    EndContext();
                    BeginContext(14958, 124, false);
#line 343 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\PurchaseRequest\AddPR.cshtml"
                               Write(Html.TextBoxFor(a => a.HeaderTbl.PurchaseNo, new { @id = "PurchaseNo", @class = "form-control", @placeholder = "Optional" }));

#line default
#line hidden
                    EndContext();
                    BeginContext(15082, 469, true);
                    WriteLiteral(@"
                                </div>
                            </div>
                        </fieldset>
                        <div class=""modal-footer"">
                            <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                            <button type=""submit"" class=""btn btn-success"" id=""AddHeader""><span class=""fa fa-save""> Save</span></button>
                        </div>
                    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(15558, 548, true);
                WriteLiteral(@"
                </div>
            </div>
        </div>
    </div>

    <!--Modal For Edit Header-->
    <div class=""modal fade bd-example-modal-lg"" id=""My3rdLargeModal"">
        <div class=""modal-dialog modal-lg"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h4 class=""modal-title"" id=""JudulModalEdit""></h4>
                    <a href=""#"" class=""close"" data-dismiss=""modal"">&times;</a>
                </div>
                <div class=""modal-body"">
                    ");
                EndContext();
                BeginContext(16106, 3498, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7347b79221506fcb021161b8b89e28958538b65526184", async() => {
                    BeginContext(16139, 92, true);
                    WriteLiteral("\r\n                        <fieldset id=\"SubmitFormEditHeader\">\r\n                            ");
                    EndContext();
                    BeginContext(16232, 114, false);
#line 368 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\PurchaseRequest\AddPR.cshtml"
                       Write(Html.HiddenFor(a => a.HeaderTbl.RequisitionHeaderId, new { @id = "RequisitionHeaderId1", @required = "required" }));

#line default
#line hidden
                    EndContext();
                    BeginContext(16346, 30, true);
                    WriteLiteral("\r\n                            ");
                    EndContext();
                    BeginContext(16377, 64, false);
#line 369 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\PurchaseRequest\AddPR.cshtml"
                       Write(Html.HiddenFor(a=>a.HeaderTbl.RequisitionNo, new { @id="PRNO1"}));

#line default
#line hidden
                    EndContext();
                    BeginContext(16441, 206, true);
                    WriteLiteral("\r\n                            <div class=\"form-row\">\r\n                                <div class=\"col-6\">\r\n                                    <label>Order Date</label>\r\n                                    ");
                    EndContext();
                    BeginContext(16648, 145, false);
#line 373 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\PurchaseRequest\AddPR.cshtml"
                               Write(Html.TextBoxFor(a => a.HeaderTbl.OrderDate, new { Type = "datetime-local", @id = "OrderDate1", @class = "form-control", @readonly = "readonly" }));

#line default
#line hidden
                    EndContext();
                    BeginContext(16793, 192, true);
                    WriteLiteral("\r\n                                </div>\r\n                                <div class=\"col-6\">\r\n                                    <label>Due Date</label>\r\n                                    ");
                    EndContext();
                    BeginContext(16986, 141, false);
#line 377 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\PurchaseRequest\AddPR.cshtml"
                               Write(Html.TextBoxFor(a => a.HeaderTbl.DueDate, new { Type = "datetime-local", @id = "DueDate1", @class = "form-control", @required = "required" }));

#line default
#line hidden
                    EndContext();
                    BeginContext(17127, 234, true);
                    WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                            <div class=\"form-group\">\r\n                                <label>Motive of Requisition</label>\r\n                                ");
                    EndContext();
                    BeginContext(17362, 127, false);
#line 382 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\PurchaseRequest\AddPR.cshtml"
                           Write(Html.TextAreaFor(a => a.HeaderTbl.RequestNotes, new { @id = "RequestNotes1", @class = "form-control", @required = "required" }));

#line default
#line hidden
                    EndContext();
                    BeginContext(17489, 245, true);
                    WriteLiteral("\r\n                            </div>\r\n                            <div class=\"form-row\">\r\n                                <div class=\"col-md-6\">\r\n                                    <label>Dept. Code</label>\r\n                                    ");
                    EndContext();
                    BeginContext(17735, 195, false);
#line 387 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\PurchaseRequest\AddPR.cshtml"
                               Write(Html.DropDownListFor(a => a.HeaderTbl.ShortcutDimension1Code, ViewBag.ListOfDepartment as SelectList, "", new { @id = "ShortcutDimension1Code1", @class = "form-control", @required = "required" }));

#line default
#line hidden
                    EndContext();
                    BeginContext(17930, 199, true);
                    WriteLiteral("\r\n                                </div>\r\n                                <div class=\"col-md-6\">\r\n                                    <label>Project Code</label>\r\n                                    ");
                    EndContext();
                    BeginContext(18130, 196, false);
#line 391 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\PurchaseRequest\AddPR.cshtml"
                               Write(Html.DropDownListFor(a => a.HeaderTbl.ShortcutDimension2Code, ViewBag.ListOfProjectCode as SelectList, "", new { @id = "ShortcutDimension2Code1", @class = "form-control", @required = "required" }));

#line default
#line hidden
                    EndContext();
                    BeginContext(18326, 283, true);
                    WriteLiteral(@"
                                </div>
                            </div>
                            <div class=""form-row"">
                                <div class=""col-md-6"">
                                    <label>Location</label>
                                    ");
                    EndContext();
                    BeginContext(18610, 149, false);
#line 397 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\PurchaseRequest\AddPR.cshtml"
                               Write(Html.DropDownListFor(a => a.HeaderTbl.LocationCode, ViewBag.ListOfLocation as SelectList, "", new { @id = "LocationCode1", @class = "form-control" }));

#line default
#line hidden
                    EndContext();
                    BeginContext(18759, 195, true);
                    WriteLiteral("\r\n                                </div>\r\n                                <div class=\"col-md-6\">\r\n                                    <label>Priority</label>\r\n                                    ");
                    EndContext();
                    BeginContext(18955, 165, false);
#line 401 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\PurchaseRequest\AddPR.cshtml"
                               Write(Html.DropDownListFor(a => a.HeaderTbl.Priority, ViewBag.ListOfPriority as SelectList, "", new { @id = "Priority1", @class = "form-control", @required = "required" }));

#line default
#line hidden
                    EndContext();
                    BeginContext(19120, 477, true);
                    WriteLiteral(@"
                                </div>
                            </div>
                        </fieldset>
                        <div class=""modal-footer"">
                            <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                            <button type=""submit"" class=""btn btn-primary"" id=""EditHeaderProcess""><span class=""fa fa-save""> Save</span></button>
                        </div>
                    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(19604, 74, true);
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
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
