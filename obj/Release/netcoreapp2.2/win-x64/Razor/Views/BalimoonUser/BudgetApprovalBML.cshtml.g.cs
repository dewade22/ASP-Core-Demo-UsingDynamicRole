#pragma checksum "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\BalimoonUser\BudgetApprovalBML.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b0260efc786489e00777091d48a53f5c2ac6014"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BalimoonUser_BudgetApprovalBML), @"mvc.1.0.view", @"/Views/BalimoonUser/BudgetApprovalBML.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/BalimoonUser/BudgetApprovalBML.cshtml", typeof(AspNetCore.Views_BalimoonUser_BudgetApprovalBML))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b0260efc786489e00777091d48a53f5c2ac6014", @"/Views/BalimoonUser/BudgetApprovalBML.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ca815501e2415492be7fd7738acfe7eb9493282", @"/Views/_ViewImports.cshtml")]
    public class Views_BalimoonUser_BudgetApprovalBML : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Balimoon_E_Procurement.Models.BalimoonBML.ViewModel.BMLUserVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\BalimoonUser\BudgetApprovalBML.cshtml"
  
    ViewData["Title"] = "BudgetApprovalBML";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(170, 1306, true);
            WriteLiteral(@"
<br />
<h2>Add Budget Approval - Balimoon Liqueur</h2>
<section class=""content"">
    <div class=""card"">
        <div class=""row"">
            <div class=""col-12"">
                <div class=""card-header"">
                    <h3 class=""card-title"">List of User  - Balimoon Liqueur</h3>
                </div>
                <div class=""card-body"">
                    <div class=""card-body"">
                        <div class=""form-group"">
                            <table id=""tabel5"" class=""table table-bordered table-striped"">
                                <thead>
                                    <tr>
                                        <th>User Id</th>
                                        <th>User Name</th>
                                        <th>Role</th>
                                        <th>Department</th>
                                        <th>Maksimum Budget</th>
                                        <th>Action</th>
                                    ");
            WriteLiteral(@"</tr>
                                </thead>
                                <tbody></tbody>
                            </table>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>

");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1493, 5211, true);
                WriteLiteral(@"
<script>
      //Get User Data To Pass into Tabel
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
                url: ""/BalimoonUser/AddBMLBudget"",
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
                WriteLiteral(@"           { targets: ""no-search"", searchable: false },
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
                { data: ""UserId"", Name: ""UserId"", isIdentity: true, visible: false },
                { data: ""UserName"" },
                { data: ""Role"" },
                { data: ""Department"" },
                { data: ""MaksimumBudget"" },
                {
                    render: function (data, type, full, meta) {
                        return ""<a href='#' onclick='ManageBudget(\"""" + full.UserId + ""\"")' class='btn btn-block btn-outline-primary'><span class='pe-7s-note'> Manage Budget</span></a>"";

        ");
                WriteLiteral(@"            }
                }
            ]
    })
    $("".dataTables_scrollHeadInner"").css({""width"":""100%""});
    $("".table "").css({ ""width"": ""100%"" });

    //Show Pop Up Modal For Detail Form
    function ManageBudget(UserId) {
        var url = ""/BalimoonUser/ManageBudgetBML?UserId="" + UserId;
                $(""#ModalTitle"").html(""Manage Budget"");
                $(""#MyLargeModal"").modal();
                $.ajax({
                    type: ""GET"",
                    url: url,
                    success: function (data) {
                        var obj = JSON.parse(data);
                        $(""#UserId"").val(obj.UserId);
                        $(""#UserName"").val(obj.UserName);
                        $(""#Role"").val(obj.Role);
                        $(""#MaksimumBudget"").val(obj.MaksimumBudget);
                    }
                })
    }
</script>
<script>
    $(function () {
        $(""#MyLargeModal form"").validate({
            rules: {
                UserName:");
                WriteLiteral(@" {
                    required: true
                }
            },
            submitHandler: function (form) {
                var getUser = document.getElementById('UserName').value;
                var getBudget = document.getElementById('MaksimumBudget').value;
                Swal.fire({
                    title: 'Update Budget',
                    text: 'Are You Sure Want To Update Budget ' + getUser + ' to Rp.' + getBudget + '?',
                    type: 'info',
                    showCancelButton: true,
                    confirmButtonColor: '#002afc',
                    cancelButtonColor: '#fc0303',
                    confirmButtonText: 'Update'
                }).then((result) => {
                    if (result.value) {
                        $.ajax({
                            url: ""/BalimoonUser/UpdateBudgetBML"",
                            type: 'POST',
                            data: $(form).serialize(),
                            success: function (result) ");
                WriteLiteral(@"{
                                if (result == true) {
                                    Swal.fire(
                                        'Saved!',
                                        'Your file has been saved.',
                                        'success'
                                    ).then((result) => {
                                        window.location.href = ""/BalimoonUser/BudgetApprovalBML"";
                                        $(""#MyLargeModal"").modal(""hide"");
                                    })
                                }
                                else {
                                    Swal.fire({
                                        type: 'error',
                                        title: 'Oops...',
                                        text: 'Something went wrong!, Check The Require Field Again'
                                    })
                                }
                            }
                        });");
                WriteLiteral("\r\n                    }\r\n                })\r\n            }\r\n        })\r\n    })\r\n</script>\r\n");
                EndContext();
            }
            );
            BeginContext(6707, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Styles", async() => {
                BeginContext(6725, 404, true);
                WriteLiteral(@"
    <div class=""modal fade bd-example-modal-lg"" id=""MyLargeModal"">
        <div class=""modal-dialog"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h4 id=""ModalTitle""></h4>
                    <a href=""#"" class=""close"" data-dismiss=""modal"">&times;</a>
                </div>
                <div class=""modal-body"">
                    ");
                EndContext();
                BeginContext(7129, 1855, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b0260efc786489e00777091d48a53f5c2ac601412205", async() => {
                    BeginContext(7157, 82, true);
                    WriteLiteral("\r\n                        <fieldset id=\"SubmitForm\">\r\n                            ");
                    EndContext();
                    BeginContext(7240, 71, false);
#line 190 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\BalimoonUser\BudgetApprovalBML.cshtml"
                       Write(Html.HiddenFor(a => a.aspNetSystemUsers.UserId, new { @id = "UserId" }));

#line default
#line hidden
                    EndContext();
                    BeginContext(7311, 145, true);
                    WriteLiteral("\r\n                            <div class=\"form-group\">\r\n                                <label>UserName</label>\r\n                                ");
                    EndContext();
                    BeginContext(7457, 119, false);
#line 193 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\BalimoonUser\BudgetApprovalBML.cshtml"
                           Write(Html.TextBoxFor(a => a.aspNetUsers.UserName, new { @id = "UserName", @class = "form-control", @readonly = "readonly" }));

#line default
#line hidden
                    EndContext();
                    BeginContext(7576, 177, true);
                    WriteLiteral("\r\n                            </div>\r\n                            <div class=\"form-group\">\r\n                                <label>Role</label>\r\n                                ");
                    EndContext();
                    BeginContext(7754, 111, false);
#line 197 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\BalimoonUser\BudgetApprovalBML.cshtml"
                           Write(Html.TextBoxFor(a => a.aspNetRoles.Name, new { @id = "Role", @class = "form-control", @readonly = "readonly" }));

#line default
#line hidden
                    EndContext();
                    BeginContext(7865, 183, true);
                    WriteLiteral("\r\n                            </div>\r\n                            <div class=\"form-group\">\r\n                                <label>Department</label>\r\n                                ");
                    EndContext();
                    BeginContext(8049, 133, false);
#line 201 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\BalimoonUser\BudgetApprovalBML.cshtml"
                           Write(Html.TextBoxFor(a => a.aspNetSystemUsers.DepartmentCode, new { @id = "Department", @class = "form-control", @readonly = "readonly" }));

#line default
#line hidden
                    EndContext();
                    BeginContext(8182, 188, true);
                    WriteLiteral("\r\n                            </div>\r\n                            <div class=\"form-group\">\r\n                                <label>Maksimum Budget</label>\r\n                                ");
                    EndContext();
                    BeginContext(8371, 172, false);
#line 205 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\BalimoonUser\BudgetApprovalBML.cshtml"
                           Write(Html.TextBoxFor(a => a.aspNetSystemUsers.PurchaseAmountApprovalLimit, new { @id = "MaksimumBudget", @class = "form-control", @placeholder = "Rp.", @required = "required" }));

#line default
#line hidden
                    EndContext();
                    BeginContext(8543, 434, true);
                    WriteLiteral(@"
                            </div>
                        </fieldset>
                        <div class=""modal-footer"">
                            <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                            <button type=""submit"" class=""btn btn-primary"" id=""UpdateBudget""><span class=""pe-7s-upload""> Save</span></button>
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
                BeginContext(8984, 75, true);
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Balimoon_E_Procurement.Models.BalimoonBML.ViewModel.BMLUserVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
