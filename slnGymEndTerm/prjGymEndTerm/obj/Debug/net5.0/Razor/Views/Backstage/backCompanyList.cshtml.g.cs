#pragma checksum "C:\Users\Sam\Documents\GitHub\Gym\slnGymEndTerm\prjGymEndTerm\Views\Backstage\backCompanyList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f9eeaf461fd29957d97cc638dc4e84cab63b174b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Backstage_backCompanyList), @"mvc.1.0.view", @"/Views/Backstage/backCompanyList.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Sam\Documents\GitHub\Gym\slnGymEndTerm\prjGymEndTerm\Views\_ViewImports.cshtml"
using prjGymEndTerm;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Sam\Documents\GitHub\Gym\slnGymEndTerm\prjGymEndTerm\Views\_ViewImports.cshtml"
using prjGymEndTerm.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9eeaf461fd29957d97cc638dc4e84cab63b174b", @"/Views/Backstage/backCompanyList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"618be0bfc67df1e664227bc268b2805b5a559654", @"/Views/_ViewImports.cshtml")]
    public class Views_Backstage_backCompanyList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<prjGymEndTerm.ViewModels.CCompanyViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "backCompanyCreate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning rounded-pill addbtn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Sam\Documents\GitHub\Gym\slnGymEndTerm\prjGymEndTerm\Views\Backstage\backCompanyList.cshtml"
  
    ViewData["Title"] = "backCompanyList";
    Layout = "~/Views/Shared/_BackstageLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    .coachTitle {
        position:absolute;
        width:100%;
        text-align: center;
        font-weight: 800;
        /*margin:0 0 0 500px*/
    }
    #myTable {
        margin: 15px 0;
        /*border: 1px solid #D0D0D0;*/
        /*padding:10px 0 0 0*/
    }
    /*    tr {
        border-bottom: 2px solid gray;
    }*/
    th {
        text-align: center;
        width: 100px;
        /*background-color: #FBFBFF;*/
        height: 40px
    }
    .page-breadcrumb {
        margin: 60px 0 15px 0;
    }

    .breadcrumb-item {
        font-size: 15px
    }
    td {
        text-align: center;
    }

    .table {

        width: 1300px;
        border: 1px solid #D0D0D0;
        background-color: #FCFCFC
    }

    .backTh {
        width: 100px
    }

    .backCBody {
        padding: 50px 0 0 80px;
        width: 1280px
    }

    .frame{
        position:relative;
        display:flex;
        justify-content:space-between;
    }

   ");
            WriteLiteral(@" .form {
        display: inline;
        position:absolute;
        right:0;
    }

    body {
        background-color: #efeff6
    }
    .divnone {
        height: 40px
    }
    .addbtn{
        margin:10px 0 0 0 
    }
    .thCount {
        width:7%
    }
    .thbtn {
        width: 15%
    }
    .th10 {
        width: 10%
    }
    #myTable th {
        background-color: #4F4F4F;
        color: white;
        height: 90%
    }

    #myTable a {
        font-size: 12px
    }
</style>

<script src='//ajax.googleapis.com/ajax/libs/jquery/2.0.0/jquery.min.js'></script>
<script src='//cdn.datatables.net/1.10.20/js/jquery.dataTables.min.js'></script>
<link href='//cdn.datatables.net/1.10.20/css/jquery.dataTables.min.css' rel='stylesheet' />


<div class=""backCBody"">
    <div class=""frame"">
        <h1 class=""coachTitle"">所有廠商</h1>
");
#nullable restore
#line 106 "C:\Users\Sam\Documents\GitHub\Gym\slnGymEndTerm\prjGymEndTerm\Views\Backstage\backCompanyList.cshtml"
         using (Html.BeginForm(FormMethod.Post, new { @class = "form" }))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f9eeaf461fd29957d97cc638dc4e84cab63b174b6471", async() => {
                WriteLiteral("<i class=\"fas fa-plus-circle\"></i> 新增廠商");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 109 "C:\Users\Sam\Documents\GitHub\Gym\slnGymEndTerm\prjGymEndTerm\Views\Backstage\backCompanyList.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n\r\n    <div class=\"page-breadcrumb\">\r\n        <nav aria-label=\"breadcrumb\" style=\"border-top: 1px solid #ADADAD \">\r\n            <ol class=\"breadcrumb\">\r\n                <li class=\"breadcrumb-item\"><a");
            BeginWriteAttribute("href", " href=", 2518, "", 2555, 1);
#nullable restore
#line 115 "C:\Users\Sam\Documents\GitHub\Gym\slnGymEndTerm\prjGymEndTerm\Views\Backstage\backCompanyList.cshtml"
WriteAttributeValue("", 2524, Url.Action("List", "BackHome"), 2524, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""breadcrumb-link"">首頁</a></li>
                <li class=""breadcrumb-item active"" aria-current=""page"">所有廠商</li>
            </ol>
        </nav>
    </div>

    <div class=""card"">
        <div class=""card-body"">
            <div class=""table-responsive"">
                <div id=""zero_config_wrapper"" class=""dataTables_wrapper container-fluid dt-bootstrap4"" style="" padding: 5px 0;"">


                    <table id=""myTable"" class=""display"">
                        <thead>
                            <tr>
                                <th class=""thCount"">序號</th>
                                <th>
                                    ");
#nullable restore
#line 132 "C:\Users\Sam\Documents\GitHub\Gym\slnGymEndTerm\prjGymEndTerm\Views\Backstage\backCompanyList.cshtml"
                               Write(Html.DisplayNameFor(model => model[0].CompanyName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
#nullable restore
#line 135 "C:\Users\Sam\Documents\GitHub\Gym\slnGymEndTerm\prjGymEndTerm\Views\Backstage\backCompanyList.cshtml"
                               Write(Html.DisplayNameFor(model => model[0].CompanyTaxId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
#nullable restore
#line 138 "C:\Users\Sam\Documents\GitHub\Gym\slnGymEndTerm\prjGymEndTerm\Views\Backstage\backCompanyList.cshtml"
                               Write(Html.DisplayNameFor(model => model[0].ComapnyPhone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                                <th class=\"thbtn\">資料異動</th>\r\n                            </tr>\r\n                        </thead>\r\n                        <tbody>\r\n");
#nullable restore
#line 144 "C:\Users\Sam\Documents\GitHub\Gym\slnGymEndTerm\prjGymEndTerm\Views\Backstage\backCompanyList.cshtml"
                              
                                int count = 0;

                                foreach (var item in Model)
                                {
                                    count++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 152 "C:\Users\Sam\Documents\GitHub\Gym\slnGymEndTerm\prjGymEndTerm\Views\Backstage\backCompanyList.cshtml"
                                       Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 155 "C:\Users\Sam\Documents\GitHub\Gym\slnGymEndTerm\prjGymEndTerm\Views\Backstage\backCompanyList.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.CompanyName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 158 "C:\Users\Sam\Documents\GitHub\Gym\slnGymEndTerm\prjGymEndTerm\Views\Backstage\backCompanyList.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.CompanyTaxId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 161 "C:\Users\Sam\Documents\GitHub\Gym\slnGymEndTerm\prjGymEndTerm\Views\Backstage\backCompanyList.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.ComapnyPhone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            <a class=\"btn btn-success rounded-pill\"");
            BeginWriteAttribute("href", " href=\"", 4908, "\"", 4987, 1);
#nullable restore
#line 164 "C:\Users\Sam\Documents\GitHub\Gym\slnGymEndTerm\prjGymEndTerm\Views\Backstage\backCompanyList.cshtml"
WriteAttributeValue("", 4915, Url.Action("backCompanyEdit", "Backstage", new { id = item.CompanyId }), 4915, 72, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-pencil-alt\"></i></a>\r\n");
            WriteLiteral("                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 168 "C:\Users\Sam\Documents\GitHub\Gym\slnGymEndTerm\prjGymEndTerm\Views\Backstage\backCompanyList.cshtml"
                                }
                            

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </tbody>
                    </table>


                </div>
            </div>

        </div>
    </div>
</div>



<script>
    $('#myTable').DataTable({
        language: {
            ""emptyTable"": ""無資料..."",
            ""processing"": ""處理中..."",
            ""loadingRecords"": ""載入中..."",
            ""lengthMenu"": ""每頁 _MENU_ 筆資料"",
            ""zeroRecords"": ""無搜尋結果"",
            ""info"": ""_START_ 至 _END_ / 共 _TOTAL_ 筆"",
            ""infoEmpty"": ""尚無資料"",
            ""infoFiltered"": ""(從 _MAX_ 筆資料過濾)"",
            ""infoPostFix"": """",
            ""search"": ""搜尋:"",
            ""paginate"": {
                ""first"": ""首頁"",
                ""last"": ""末頁"",
                ""next"": ""下一頁"",
                ""previous"": ""上一頁""
            },
            ""aria"": {
                ""sortAscending"": "": 升冪"",
                ""sortDescending"": "": 降冪""
            }
        }
    });
</script>




");
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<prjGymEndTerm.ViewModels.CCompanyViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591