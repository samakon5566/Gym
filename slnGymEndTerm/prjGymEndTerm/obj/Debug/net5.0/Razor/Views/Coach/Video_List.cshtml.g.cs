#pragma checksum "C:\Users\Sam\Documents\GitHub\Gym\slnGymEndTerm\prjGymEndTerm\Views\Coach\Video_List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e5835a31b21926d4d6c5c86765cf97fb34815da"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Coach_Video_List), @"mvc.1.0.view", @"/Views/Coach/Video_List.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e5835a31b21926d4d6c5c86765cf97fb34815da", @"/Views/Coach/Video_List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"618be0bfc67df1e664227bc268b2805b5a559654", @"/Views/_ViewImports.cshtml")]
    public class Views_Coach_Video_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Coach", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "List", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color:#FFF"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Video_Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("float:right;color:white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Sam\Documents\GitHub\Gym\slnGymEndTerm\prjGymEndTerm\Views\Coach\Video_List.cshtml"
  
    ViewData["Title"] = "Video_List";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Style", async() => {
                WriteLiteral(@"
    <style>
        #myTable {
            text-align: center;
            width: 1140px;
            margin-left: auto;
            margin-right: auto;
        }
        #myTable_length {
            color: white;
        }

        #myTable_filter {
            color: white;
        }

        #myTable_info {
            color: white;
        }
        #myTable_paginate > a {
            filter: invert(1);
            /*filter: grayscale(1);*/
            /*            filter: brightness(1);*/
        }

        #myTable_paginate > span {
            filter: invert(1);
            /*filter: grayscale(1);*/
            /*            filter: brightness(1);*/
        }

        #myTable thead {
            font-size: 22px;
        }

        #myTable tbody {
            color: black;
            font-size: 18px;
        }


        .container > div > a {
            color: #FFA500;
        }

            .container > div > a:visited {
                color: #FFA50");
                WriteLiteral("0;\r\n            }\r\n    </style>\r\n");
            }
            );
            WriteLiteral("\r\n<section class=\"class-details-section spad-3\">\r\n    <div class=\"container\">\r\n        <div>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e5835a31b21926d4d6c5c86765cf97fb34815da6536", async() => {
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
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e5835a31b21926d4d6c5c86765cf97fb34815da8320", async() => {
                WriteLiteral("+新增資料");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    <div class=\"cd-text\" style=\"color:white\">\r\n                        <select id=\"course\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e5835a31b21926d4d6c5c86765cf97fb34815da9704", async() => {
                WriteLiteral("請選擇課程分類");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </select>
                    </div>
                    <div class=""cd-trainer"">
                        <div class=""row"">
                            <div class=""col-md-12"">
                                <div class=""cd-trainer-pic"" id=""VideoPartial"" style=""color:white"">

                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script src='//ajax.googleapis.com/ajax/libs/jquery/2.0.0/jquery.min.js'></script>
    <script src='//cdn.datatables.net/1.10.20/js/jquery.dataTables.min.js'></script>
    <link href='//cdn.datatables.net/1.10.20/css/jquery.dataTables.min.css' rel='stylesheet' />

    <script>
        const selCourse = document.querySelector('#course');

        $(function () {
            $(""#VideoPartial"").load('");
#nullable restore
#line 103 "C:\Users\Sam\Documents\GitHub\Gym\slnGymEndTerm\prjGymEndTerm\Views\Coach\Video_List.cshtml"
                                Write(Url.Content("~/Coach/_Video_List"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"', LoadDataTable);
        })

        function LoadDataTable() {
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
 ");
                WriteLiteral("       }\r\n\r\n        async function LoadCourse() {\r\n            const response = await fetch(\'");
#nullable restore
#line 134 "C:\Users\Sam\Documents\GitHub\Gym\slnGymEndTerm\prjGymEndTerm\Views\Coach\Video_List.cshtml"
                                     Write(Url.Content("~/api/selectCategoty"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"');
            RenderCourse(await response.json())
        }
        LoadCourse();


        selCourse.addEventListener('change', async function () {
            const selCourseIndex = selCourse.selectedIndex;
            console.log(selCourseIndex);
            $(""#VideoPartial"").load('");
#nullable restore
#line 143 "C:\Users\Sam\Documents\GitHub\Gym\slnGymEndTerm\prjGymEndTerm\Views\Coach\Video_List.cshtml"
                                Write(Url.Content("~/Coach/_Video_List?FitnessVideo_ID="));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"' + selCourseIndex, LoadDataTable);
        })

        function RenderCourse(datas) {
            datas.forEach((item) => {
                const opt = new Option(item.courseCategoryName, item.courseCategoryId);
                selCourse.options.add(opt)
            })
        }

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591