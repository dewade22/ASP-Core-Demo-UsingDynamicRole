#pragma checksum "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\Users\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "473284bc7a91ee02caa48afbbcfec6e740510c01"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Index), @"mvc.1.0.view", @"/Views/Users/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Users/Index.cshtml", typeof(AspNetCore.Views_Users_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"473284bc7a91ee02caa48afbbcfec6e740510c01", @"/Views/Users/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ca815501e2415492be7fd7738acfe7eb9493282", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Balimoon_E_Procurement.Models.UserRoleVM>
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
            BeginContext(49, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 4 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\Users\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";


#line default
#line hidden
            BeginContext(143, 1712, true);
            WriteLiteral(@"

<br />
<h2>Manage Other User</h2><br />

<section class=""content"">
    <div class=""card"">
        <div class=""row"">
            <div class=""col-12"">
                <div class=""card-header"">
                    <h3 class=""card-title"">Confirmed User</h3>
                </div>
                <div class=""card-body"">
                    <table id=""tabel5"" class=""table table-bordered table-striped"">
                        <thead>
                            <tr>
                                <th>
                                    User ID
                                </th>
                                <th>
                                    Username
                                </th>
                                <th>
                                    E-Mail
                                </th>
                                <th>
                                    Confirmed
                                </th>
                                <th>
             ");
            WriteLiteral(@"                       Phone Number
                                </th>
                                <th>
                                    Role Code
                                </th>
                                <th>
                                    Role Name
                                </th>
                                <th>
                                    Action
                                </th>
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
            DefineSection("Styles", async() => {
                BeginContext(1871, 426, true);
                WriteLiteral(@"
    <!-- modal -->

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
                BeginContext(2297, 2272, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "473284bc7a91ee02caa48afbbcfec6e740510c016419", async() => {
                    BeginContext(2313, 82, true);
                    WriteLiteral("\r\n                        <fieldset id=\"SubmitForm\">\r\n                            ");
                    EndContext();
                    BeginContext(2396, 54, false);
#line 72 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\Users\Index.cshtml"
                       Write(Html.HiddenFor(a => a.usertbl.Id, new { @id = "UId" }));

#line default
#line hidden
                    EndContext();
                    BeginContext(2450, 145, true);
                    WriteLiteral("\r\n                            <div class=\"form-group\">\r\n                                <label>Username</label>\r\n                                ");
                    EndContext();
                    BeginContext(2596, 115, false);
#line 75 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\Users\Index.cshtml"
                           Write(Html.TextBoxFor(a => a.usertbl.UserName, new { @id = "username", @class = "form-control", @readonly = "readonly" }));

#line default
#line hidden
                    EndContext();
                    BeginContext(2711, 179, true);
                    WriteLiteral("\r\n                            </div>\r\n                            <div class=\"form-group\">\r\n                                <label>E-Mail</label>\r\n                                ");
                    EndContext();
                    BeginContext(2891, 100, false);
#line 79 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\Users\Index.cshtml"
                           Write(Html.TextBoxFor(a=>a.usertbl.Email, new { @id="email", @class="form-control", @readonly="readonly"}));

#line default
#line hidden
                    EndContext();
                    BeginContext(2991, 190, true);
                    WriteLiteral("\r\n                            </div>\r\n                            <div class=\"form-group\">\r\n                                <label>E-Mail Confirmed?</label>\r\n                                ");
                    EndContext();
                    BeginContext(3182, 113, false);
#line 83 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\Users\Index.cshtml"
                           Write(Html.TextBoxFor(a=>a.usertbl.EmailConfirmed, new { @id="emailconf", @class="form-control", @readonly="readonly"}));

#line default
#line hidden
                    EndContext();
                    BeginContext(3295, 185, true);
                    WriteLiteral("\r\n                            </div>\r\n                            <div class=\"form-group\">\r\n                                <label>Phone Number</label>\r\n                                ");
                    EndContext();
                    BeginContext(3481, 84, false);
#line 87 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\Users\Index.cshtml"
                           Write(Html.TextBoxFor(a=>a.usertbl.PhoneNumber, new { @id="phone", @class="form-control"}));

#line default
#line hidden
                    EndContext();
                    BeginContext(3565, 192, true);
                    WriteLiteral("\r\n                            </div>\r\n                            <div class=\"form-group\">\r\n                                <label>Access Failed Count</label>\r\n                                ");
                    EndContext();
                    BeginContext(3758, 119, false);
#line 91 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\Users\Index.cshtml"
                           Write(Html.TextBoxFor(a=>a.usertbl.AccessFailedCount, new { @id="accessfailed", @class="form-control", @readonly="readonly"}));

#line default
#line hidden
                    EndContext();
                    BeginContext(3877, 182, true);
                    WriteLiteral("\r\n                            </div>\r\n                            <div class=\"form-group\">\r\n                                <label>Role Code</label>\r\n                                ");
                    EndContext();
                    BeginContext(4060, 118, false);
#line 95 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\Users\Index.cshtml"
                           Write(Html.TextBoxFor(a=>a.roletbl.NormalizedName, new { @id="rolenormalized", @class="form-control", @readonly="readonly"}));

#line default
#line hidden
                    EndContext();
                    BeginContext(4178, 182, true);
                    WriteLiteral("\r\n                            </div>\r\n                            <div class=\"form-group\">\r\n                                <label>Role Name</label>\r\n                                ");
                    EndContext();
                    BeginContext(4361, 106, false);
#line 99 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\Users\Index.cshtml"
                           Write(Html.TextBoxFor(a=>a.roletbl.Name, new { @id="rolename", @class="form-control", @readonly="readonly    "}));

#line default
#line hidden
                    EndContext();
                    BeginContext(4467, 95, true);
                    WriteLiteral("\r\n                            </div>\r\n                        </fieldset>\r\n                    ");
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
                BeginContext(4569, 365, true);
                WriteLiteral(@"
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                    <a href=""#"" class=""btn btn-danger"" id=""UpdateUser""><span class=""pe-7s-upload""> Save</span></a>
                </div>
            </div>
        </div>
    </div>

");
                EndContext();
            }
            );
            DefineSection("Scripts", async() => {
                BeginContext(4954, 5161, true);
                WriteLiteral(@" 
<script>
    $.fn.dataTable.moment(""DD/MM/YYYY HH:mm:ss"");
    $.fn.dataTable.moment(""DD/MM/YYYY"");


    $(""#tabel5"").DataTable({
        //Design Layout
        stateSave: true,
        autoWidth: true,
        scrollX: true,
        scrollY: false,


        //ServerSide
        processing: true,
        serverSide: true,

        //Paging Setup
        paging: true,


        //searching Setup
        searching: { regex: true },

        //ajax Filter
        ajax: {
            url: ""/Users/GetUserList"",
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
            {
                targets: [0],
                searchable: false,
                visible: false
            },
            { targets: ""no-sort"", orderable: false },
  ");
                WriteLiteral(@"          { targets: ""no-search"", searchable: false },
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
            { data: ""UId"", name: ""Id"", isIdentity: true, visible: false },
            { data: ""username"", name: ""username"" },
            { data: ""email"", name: ""email"" },
            {
                data: ""emailconf"",
                render: function (data, type, row) {
                    if (data === true) {
                        data = ""Confirmed""
                    }
                    else {
                        data = ""Not Confirmed""
                    }
                    return data;
                }
            },
            { data: ");
                WriteLiteral(@"""phone"", name: ""phone"" },
            { data: ""rolenormalized"", name: ""rolenormalized"" },
            { data: ""rolename"", name: ""rolename"" },
            {
                render: function (data, type, full, meta) {
                    return ""<a href='#' onclick='UserRecordDetails(\"""" + full.UId + ""\"")' class='btn btn-outline-info'><span class='pe-7s-info'> Details</span></a>"";

                }
            }

        ]
    })
    $("".dataTables_scrollHeadInner"").css({""width"":""100%""});
    $("".table "").css({""width"":""100%""});

    //Show Pop Up Modal For Detail Form

    function UserRecordDetails(UId) {
        var url = ""/Users/GetUserById?Id="" + UId;
        $(""#ModalTitle"").html(""Details User"");
        $(""#MyLargeModal"").modal();
        $.ajax({
            type: ""GET"",
            url: url,
            success: function (data) {
                var obj = JSON.parse(data);
                $(""#UId"").val(obj.UId);
                $(""#username"").val(obj.username);
             ");
                WriteLiteral(@"   $(""#email"").val(obj.email);
                $(""#emailconf"").val(obj.emailconf);
                $(""#phone"").val(obj.phone);
                $(""#accessfailed"").val(obj.accessfailed);
                $(""#rolenormalized"").val(obj.rolenormalized);
                $(""#rolename"").val(obj.rolename);
                $(""#DropDown option:selected"").text(obj.rolename);

            }
        })
    }

     //Edit Phone Number User
     $(""#UpdateUser"").click(function () {
         var data = $(""#SubmitForm"").serialize();
         Swal.fire({
             title: 'Update Users',
             text: 'Are You Sure Want To Update This Users?',
             type: 'info',
             showCancelButton: true,
             confirmButtonColor: '#000dfc',
             cancelButtonColor: '#fca400',
             confirmButtonText: 'Yes, Update Now!'
         }).then((result) => {
             if (result.value) {
                 $.ajax({
                     type: ""POST"",
                     url: ""/User");
                WriteLiteral(@"s/UpdateUserRecord"",
                     data: data,
                     success: function (result) {
                         if (result == true) {
                             Swal.fire(
                                 'Updated!',
                                 'Your file has been saved.',
                                 'success'
                             ).then((result) => {
                                 ;
                                 window.location.href = ""/Users/Index"";
                                 $(""#MyLargeModal"").modal(""hide"");
                             })
                         }
                         else {
                            Swal.fire({
                                type: 'error',
                                title: 'Oops...',
                                text: 'Something went wrong!, Please Check The Field Again'
                            })
                         }
                     }
                 })
             }");
                WriteLiteral("\n         })\r\n     })\r\n   \r\n</script>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Balimoon_E_Procurement.Models.UserRoleVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
