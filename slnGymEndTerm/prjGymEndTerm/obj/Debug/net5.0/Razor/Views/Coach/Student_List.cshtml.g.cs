#pragma checksum "C:\Users\Sam\Documents\GitHub\Gym\slnGymEndTerm\prjGymEndTerm\Views\Coach\Student_List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a7b945c3f7f44bf8837480d10e03d51d342cdbef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Coach_Student_List), @"mvc.1.0.view", @"/Views/Coach/Student_List.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7b945c3f7f44bf8837480d10e03d51d342cdbef", @"/Views/Coach/Student_List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"618be0bfc67df1e664227bc268b2805b5a559654", @"/Views/_ViewImports.cshtml")]
    public class Views_Coach_Student_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<prjGymEndTerm.ViewModels.CoachArea.CoachArea_StudentViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Coach", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "List", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color:#FFF"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\Sam\Documents\GitHub\Gym\slnGymEndTerm\prjGymEndTerm\Views\Coach\Student_List.cshtml"
  
    ViewData["Title"] = "Student_List";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            DefineSection("Style", async() => {
                WriteLiteral(@"
    <style>
        #tb1-19 {
            text-align: center;
            width: 1140px;
            margin-left: auto;
            margin-right: auto;
            /*transform:scaleX(0.8);*/
        }

        #tb1-19_length {
            color: white;
        }

        #tb1-19_filter {
            color: white;
        }

        #tb1-19_info {
            color: white;
        }

        #tb1-19_paginate > a {
            filter: invert(1);
        }

        #tb1-19_paginate > span {
            filter: invert(1);
        }
        #tb1-19 thead {
            font-size: 22px;
        }

        #tb1-19 tbody {
            color: black;
            font-size:18px;
            margin-left: auto;
            margin-right: auto;
        }

        .container > div > a {
            color: #FFA500;
        }

            .container > div > a:visited {
                color: #FFA500;
            }
    </style>
");
            }
            );
            WriteLiteral("<section class=\"contact-section spad-3\">\r\n    <div class=\"container\">\r\n        <div>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a7b945c3f7f44bf8837480d10e03d51d342cdbef5601", async() => {
                WriteLiteral("\r\n                教練首頁\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            <label style=""color:#FFF"">
                >
            </label>
            <a href=""#"">
                目前頁面
            </a>
        </div>
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""class-details-text"">
                    <div class=""cd-trainer"">
                        <div class=""row"">
");
            WriteLiteral(@"                            <div class=""col-md-12"">
                                <input type=""button"" value=""Demo"" id=""demo""  class=""btn btn-warning"" style=""float:right""/>
                                <table class=""table table-dark table-hover"" id=""tb1-19"">
                                    <thead>
                                        <tr>
");
            WriteLiteral("                                            <th>\r\n                                                ");
#nullable restore
#line 83 "C:\Users\Sam\Documents\GitHub\Gym\slnGymEndTerm\prjGymEndTerm\Views\Coach\Student_List.cshtml"
                                           Write(Html.DisplayNameFor(model => model[0].LogInName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </th>\r\n                                            <th>\r\n                                                ");
#nullable restore
#line 86 "C:\Users\Sam\Documents\GitHub\Gym\slnGymEndTerm\prjGymEndTerm\Views\Coach\Student_List.cshtml"
                                           Write(Html.DisplayNameFor(model => model[0].LogInGender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </th>\r\n                                            <th>\r\n                                                ");
#nullable restore
#line 89 "C:\Users\Sam\Documents\GitHub\Gym\slnGymEndTerm\prjGymEndTerm\Views\Coach\Student_List.cshtml"
                                           Write(Html.DisplayNameFor(model => model[0].LogInPhone));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            </th>
                                            <th>
                                                課程資料
                                            </th>
                                        </tr>
                                    </thead>
                                    <tbody>
");
#nullable restore
#line 97 "C:\Users\Sam\Documents\GitHub\Gym\slnGymEndTerm\prjGymEndTerm\Views\Coach\Student_List.cshtml"
                                          
                                            int count = 0;
                                            foreach (var item in Model)
                                            {
                                                count++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <tr>\r\n");
            WriteLiteral("                                                    <td>\r\n                                                        ");
#nullable restore
#line 107 "C:\Users\Sam\Documents\GitHub\Gym\slnGymEndTerm\prjGymEndTerm\Views\Coach\Student_List.cshtml"
                                                   Write(Html.DisplayFor(modelItem => item.LogInName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </td>\r\n                                                    <td>\r\n                                                        ");
#nullable restore
#line 110 "C:\Users\Sam\Documents\GitHub\Gym\slnGymEndTerm\prjGymEndTerm\Views\Coach\Student_List.cshtml"
                                                   Write(Html.DisplayFor(modelItem => item.LogInGender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </td>\r\n                                                    <td>\r\n                                                        ");
#nullable restore
#line 113 "C:\Users\Sam\Documents\GitHub\Gym\slnGymEndTerm\prjGymEndTerm\Views\Coach\Student_List.cshtml"
                                                   Write(Html.DisplayFor(modelItem => item.LogInPhone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </td>\r\n                                                    <td>\r\n                                                        <a class=\"btn btn-primary rounded-pill\"");
            BeginWriteAttribute("href", " href=\"", 4589, "\"", 4651, 1);
#nullable restore
#line 116 "C:\Users\Sam\Documents\GitHub\Gym\slnGymEndTerm\prjGymEndTerm\Views\Coach\Student_List.cshtml"
WriteAttributeValue("", 4596, Url.Action("Student_Course",new { id = item.LogInId }), 4596, 55, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-address-book\"></i> 課程資料 </a>\r\n");
            WriteLiteral("                                                    </td>\r\n                                                </tr>\r\n");
#nullable restore
#line 122 "C:\Users\Sam\Documents\GitHub\Gym\slnGymEndTerm\prjGymEndTerm\Views\Coach\Student_List.cshtml"
                                            }
                                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </tbody>\r\n                                </table>\r\n                            </div>\r\n");
            WriteLiteral("                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n</section>\r\n<!-- Class Details Section End -->\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script src='//ajax.googleapis.com/ajax/libs/jquery/2.0.0/jquery.min.js'></script>
    <script src='//cdn.datatables.net/1.10.20/js/jquery.dataTables.min.js'></script>
    <link href='//cdn.datatables.net/1.10.20/css/jquery.dataTables.min.css' rel='stylesheet' />

    <script>
        $(function () {
            $('#tb1-19').DataTable({
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
               ");
                WriteLiteral(@"         ""previous"": ""上一頁""
                    },
                    ""aria"": {
                        ""sortAscending"": "": 升冪"",
                        ""sortDescending"": "": 降冪""
                    }
                }
            });
        })

        $(""#demo"").click(function () {
            $(""#tb1-19_filter input"").val(""若瑄"");
        })

    </script>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<prjGymEndTerm.ViewModels.CoachArea.CoachArea_StudentViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591