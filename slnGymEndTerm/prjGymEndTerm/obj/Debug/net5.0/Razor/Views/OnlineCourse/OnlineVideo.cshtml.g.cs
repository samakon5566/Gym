#pragma checksum "C:\Users\Sam\Documents\GitHub\Gym\slnGymEndTerm\prjGymEndTerm\Views\OnlineCourse\OnlineVideo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "664d69dc6cf8dde5abeb44bdf24290b914d40013"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_OnlineCourse_OnlineVideo), @"mvc.1.0.view", @"/Views/OnlineCourse/OnlineVideo.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"664d69dc6cf8dde5abeb44bdf24290b914d40013", @"/Views/OnlineCourse/OnlineVideo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"618be0bfc67df1e664227bc268b2805b5a559654", @"/Views/_ViewImports.cshtml")]
    public class Views_OnlineCourse_OnlineVideo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<prjGymEndTerm.ViewModels.CFitnessVideoViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/online.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("select_option"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Sam\Documents\GitHub\Gym\slnGymEndTerm\prjGymEndTerm\Views\OnlineCourse\OnlineVideo.cshtml"
  
    ViewData["Title"] = "OnlineVideo";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    .div_all {
        display: flex;
    }

    .section_title {
        margin: 50px 50px 50px 50px;
        padding: 40px;
    }

    .select_choose {
        background-color: #151515;
        font-size: 25px;
        color: dimgray;
        font-weight: bold;
        font-family: monospace;
    }

    .video_title {
        position: absolute;
        color: orange;
        font-size: 22px;
        font-weight: bold;
        text-decoration: underline;
        padding-left: 600px;
        margin: auto;
        margin-top: -450px;
    }

    .video_text {
        width: 800px;
        position: absolute;
        font-size: 18px;
        padding-left: 200px;
        margin-left: 400px;
        padding-top: 50px;
        margin-top: -450px;
    }

        .video_text:hover {
            width: 800px;
            position: absolute;
            font-size: 20px;
            font-weight: bold;
            line-height: 35px;
            color: lightyellow;");
            WriteLiteral(@"
            padding-left: 200px;
            margin-left: 400px;
            padding-top: 50px;
            margin-top: -450px;
        }

    .ul_title {
        font-size: 14px;
        color: white;
        text-align: right;
    }

    .coach_text {
        position: absolute;
        color: lightblue;
        font-size: 22px;
        font-weight: bold;
        text-decoration: underline;
        margin-top: -180px;
        margin-left: 1050px;
    }

    .select_option {
        font-weight: bold;
        font-family: monospace;
    }



    /*  .span_total {
        color:white;
        font-size: 25px;
        font-weight: bold;
        margin-left: 100px;
    }*/
</style>


<section class=""outer-frame"">
    <div class=""div-container-out"">
        <div class=""div-container"">
            <h2 class=""topheader-title object-fit: cover;"">線上影片專區</h2>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "664d69dc6cf8dde5abeb44bdf24290b914d400136602", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n<div class=\"container\" style=\"margin-top: 40px;margin-left:700px\">\r\n    <select class=\"select_choose\" id=\"CategorySelect\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "664d69dc6cf8dde5abeb44bdf24290b914d400137826", async() => {
                WriteLiteral("請選擇課程種類");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </select>\r\n    <select class=\"select_choose\" style=\"margin-left:40px\" id=\"CoachSelect\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "664d69dc6cf8dde5abeb44bdf24290b914d400139180", async() => {
                WriteLiteral("請選擇教練");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </select>\r\n");
            WriteLiteral("</div>\r\n\r\n\r\n\r\n\r\n<section class=\"section_title\">\r\n    <div class=\"div_all\">\r\n        <div class=\"container\">\r\n            <div class=\"row\">\r\n                <div class=\"blog-item\" id=\"Video\">\r\n\r\n");
#nullable restore
#line 119 "C:\Users\Sam\Documents\GitHub\Gym\slnGymEndTerm\prjGymEndTerm\Views\OnlineCourse\OnlineVideo.cshtml"
                      
                        int count = 0;
                        foreach (var item in Model)
                        {
                            count++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div style=\"line-height:300px\">\r\n                                <iframe width=\"560\" height=\"315\"");
            BeginWriteAttribute("src", " src=", 3047, "", 3103, 1);
#nullable restore
#line 125 "C:\Users\Sam\Documents\GitHub\Gym\slnGymEndTerm\prjGymEndTerm\Views\OnlineCourse\OnlineVideo.cshtml"
WriteAttributeValue("", 3052, Html.DisplayFor(modelItem => item.FitnessVideoUrl), 3052, 51, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" title=\"YouTube video player\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture\" allowfullscreen></iframe>\r\n                                <p class=\"video_title\">");
#nullable restore
#line 126 "C:\Users\Sam\Documents\GitHub\Gym\slnGymEndTerm\prjGymEndTerm\Views\OnlineCourse\OnlineVideo.cshtml"
                                                  Write(Html.DisplayFor(modelItem => item.FitnessVideoTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <a href=\"https://msit132gym.azurewebsites.net/GroupCourse/%E6%8E%88%E8%AA%B2%E6%95%99%E7%B7%B4%E4%BB%8B%E7%B4%B9\"><p class=\"coach_text\">");
#nullable restore
#line 127 "C:\Users\Sam\Documents\GitHub\Gym\slnGymEndTerm\prjGymEndTerm\Views\OnlineCourse\OnlineVideo.cshtml"
                                                                                                                                                                   Write(Html.DisplayFor(modelItem => item.FitnessVideoCoachName));

#line default
#line hidden
#nullable disable
            WriteLiteral(" 教練</p></a>\r\n                                <p class=\"video_text\">");
#nullable restore
#line 128 "C:\Users\Sam\Documents\GitHub\Gym\slnGymEndTerm\prjGymEndTerm\Views\OnlineCourse\OnlineVideo.cshtml"
                                                 Write(Html.DisplayFor(modelItem => item.FitnessVideoContent));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                            </div>\r\n");
#nullable restore
#line 130 "C:\Users\Sam\Documents\GitHub\Gym\slnGymEndTerm\prjGymEndTerm\Views\OnlineCourse\OnlineVideo.cshtml"
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script src=""https://code.jquery.com/jquery-3.6.0.min.js"" integrity=""sha256-/xUj+3OJU5yExlq6GSYGSHk7tPXikynS7ogEvDej/m4="" crossorigin=""anonymous""></script>
    <script async src=""https://www.youtube.com/iframe_api""></script>
    <script>

        const categorySelect = document.querySelector('#CategorySelect')
        const coachSelect = document.querySelector('#CoachSelect')

        $(function () {

            $('#Video').DataTable({
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
                        ""firs");
                WriteLiteral(@"t"": ""首頁"",
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
        });




        async function Load() {

            //categorySelect
            const category = await fetch('/OnlineCourse/categoryselect')
            rendercategorySelect(await category.json())
        }
        Load();


        //categorySelect-change
        categorySelect.addEventListener('change', async function () {
            const categoryIndex = categorySelect.selectedIndex
            const coachResponse = await fetch(('/OnlineCourse/coachSelect?SkillCourseCategoryId=') + categoryIndex)
            rendercoachSelect(await coachResponse.json())
            //Videodisplay
            const VideoResponse = await fetch(('/OnlineC");
                WriteLiteral(@"ourse/coachvideodisplay?SkillCourseCategoryId=') + categoryIndex)
            const Videodatas = await VideoResponse.json();
            rendervideo(await Videodatas);

            coachSelect.addEventListener('change', async function () {
                const categoryIndex = categorySelect.selectedIndex;
                const coachIndex = coachSelect.selectedIndex;
                const coachValue = coachSelect.options[coachIndex].value;
                console.log(""---"" + categoryIndex + ""---"" + coachValue);
                //Videodisplay
                const VideoResponse = await fetch(('/OnlineCourse/videodisplay?SkillCourseCategoryId=') + coachValue + ""&categoryid="" + categoryIndex)
                const Videodatas = await VideoResponse.json();
                rendervideo(await Videodatas);
            })


        })


        function rendercategorySelect(datas) {
            datas.forEach((item) => {
                //console.log(item)
                const opt = new Option(ite");
                WriteLiteral(@"m.courseCategoryName, item.courseCategoryId)
                categorySelect.options.add(opt)
            })
        }

        function rendercoachSelect(datas) {
            coachSelect.options.length = 0;
            coachSelect.options.add(new Option(""請選擇教練"", ""0""))
            datas.forEach((item) => {
                console.log(item)
                const opt = new Option(item.logInName, item.fitnessVideoCoachId)
                coachSelect.options.add(opt)
            })
        }

        function rendervideo(datas) {
            var videoblock = $(""#Video"");
            $(""#Video"").empty();
            datas.forEach((item) => {
                console.log(item)

                const videoiframe = $(""<iframe/>"").attr({
                    width: 560,
                    height: 315,
                    src: item.videourl,
                    title: ""YouTube video player"",
                    frameborder: 0,
                    allow: ""accelerometer; autoplay; clipboard-write");
                WriteLiteral(@"; encrypted-media; gyroscope; picture-in-picture"",
                });
                const videotitle = $(""<p/>"").addClass(""video_title"").text(item.videoname);
                const coachnamehyperlink = $(""<a/>"").attr(""href"", ""https://msit132gym.azurewebsites.net/GroupCourse/授課教練介紹"");
                const videocoachname = $(""<p/>"").addClass(""coach_text"").text(`${item.coachname}    教練`);
                coachnamehyperlink.append(videocoachname);
                const videocontent = $(""<p/>"").addClass(""video_text"").text(item.videocontent);
                const divblock = $(""<div/>"").css(""line-height"", ""300px"").append([videoiframe, videotitle, coachnamehyperlink, videocontent]);
                videoblock.append(divblock);
            })
        }


        $(""#CategorySelect"").click(function () {
            $(""#CategorySelect"").css(""background-color"", ""#F0F0F0"");
        })

        $(""#CoachSelect"").click(function () {
            $(""#CoachSelect"").css(""background-color"", ""	#FFFFFF"");
 ");
                WriteLiteral("       })\r\n    </script>\r\n\r\n");
            }
            );
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<prjGymEndTerm.ViewModels.CFitnessVideoViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
