#pragma checksum "C:\Users\Sam\Documents\GitHub\Gym\slnGymEndTerm\prjGymEndTerm\Views\Coach\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d8b54752130219b7b55440ab81251cd939200c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Coach_List), @"mvc.1.0.view", @"/Views/Coach/List.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d8b54752130219b7b55440ab81251cd939200c1", @"/Views/Coach/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"618be0bfc67df1e664227bc268b2805b5a559654", @"/Views/_ViewImports.cshtml")]
    public class Views_Coach_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("LessonForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("ClassForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/CoachCourse/jquery-ui.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/CoachCourse/jquery-ui.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/CoachCourse/main.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/CoachCourse/main.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/CoachCourse/locales-all.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Sam\Documents\GitHub\Gym\slnGymEndTerm\prjGymEndTerm\Views\Coach\List.cshtml"
  
    ViewData["Title"] = "Course_List";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Style", async() => {
                WriteLiteral(@"
    <style>
        .calendat-19 {
            position: relative;
            padding-top: 30px;
            padding-right:30px;
            padding-left:30px;
            padding-bottom:20px;
            background-color: rgb(255,255,255);
            width: 1200px;
            height: 650px;
            border-bottom-right-radius: 30px;
            border-bottom-left-radius: 30px;
        }
        .calendatHeader-19 {
            width: 1200px;
            height: 50px;
            border-top-left-radius: 30px;
            border-top-right-radius:30px;
            background-color: #FFA500;
        }
        .fc-timegrid-slot-lane:hover {
            background-color: #FCFCFC;
        }
        body .fc {
            font-size: 20px;
        }
        .CourseDetail label{
            font-size:20px;
            color:black;
            font-weight:bold;
        }
        .CourseDetail p {
            font-size: 16px;
            color: black;
        }
/*        #hinet");
                WriteLiteral(" {\r\n            list-style-type:disc;\r\n        }*/\r\n/*        #hinet li{\r\n            float: right;\r\n        }*/\r\n    </style>\r\n");
            }
            );
            WriteLiteral(@"

<!-- Class Timetable Section Begin -->
<section class=""contact-section  spad-2"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <div style=""float:right"">
                    <a id=""CreateClass"" style=""color:white;font-size:20px;"" class=""btn btn-primary"">+????????????</a>
                </div>
            </div>
        </div>
        <div class=""row"" style=""margin-top:20px;"">
            <div class=""col-12"">
                <div class=""calendatHeader-19"">
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""calendat-19"">
                    <div id='calendar'></div>
                    <div id=""dialogLessonDetail"" class=""CourseDetail"" title=""????????????"">
                        <label>????????????:</label><p id=""courseName"" styl></p>
                        <label>??????:</label><p id=""ClassRoomName""></p>
                        <label>??????:</label> <label st");
            WriteLiteral("yle=\"color:blue\">??????????????????</label><label style=\"color:red\">????????????</label>\r\n                        <div id=\"partialDetail\"></div>\r\n                    </div>\r\n                    <div id=\"dialogLesson\" title=\"??????????????????\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4d8b54752130219b7b55440ab81251cd939200c19275", async() => {
                WriteLiteral(@"
                            <div class=""form-group"">
                                <label class=""control-label"">????????????</label>
                                <select id=""ClassSelect"" style=""width:300px;height:40px"" name=""ClassId""></select>
                            </div>
                            <div class=""form-group"">
                                <label class=""control-label"">??????</label><br />
                                <input id=""courseTime"" name=""courseTime"" readonly=""readonly"">
                            </div>
                            <div class=""p-t-20 pull-right"" style=""float:right"">
                                <input type=""button"" value=""??????"" id=""AddLesson"" class=""btn btn-warning"" style=""font-weight:900"" />
                            </div>
                        ");
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
            WriteLiteral("\r\n                    </div>\r\n                    <div id=\"dialog\" title=\"????????????\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4d8b54752130219b7b55440ab81251cd939200c111550", async() => {
                WriteLiteral(@"
                            <div class=""form-group"" style=""font-size:20px;"">
                                <label class=""control-label"">????????????</label><br />
                                <select id=""detailSelect"" class=""form-select"" name=""CourseDetail""></select>
                            </div>
                            <div class=""form-group"">
                                <label class=""control-label"">????????????</label>
                                <input id=""ClassName"" class=""form-control"" style=""width: 300px; height: 40px; border: 1px solid #6C6C6C "" name=""ClassName"" />
                            </div>
                            <div class=""form-group"">
                                <label class=""control-label"">????????????</label>
                                <select id=""planSelect"" style=""width:300px;height:40px"" name=""CoursePlan""></select>
                            </div>
                            <div class=""p-t-20 pull-right"" style=""float:right"">
                               ");
                WriteLiteral(@" <input type=""button"" id=""demoCourse"" value=""Demo"" class=""btn btn-warning"" style=""font-weight:900"" />
                                <input type=""button"" value=""??????"" id=""OK"" class=""btn btn-warning"" style=""font-weight:900"" />
                            </div>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n<!-- Class Timetable Section End -->\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4d8b54752130219b7b55440ab81251cd939200c114533", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4d8b54752130219b7b55440ab81251cd939200c115712", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4d8b54752130219b7b55440ab81251cd939200c116816", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4d8b54752130219b7b55440ab81251cd939200c117916", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4d8b54752130219b7b55440ab81251cd939200c119095", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <script>
        $(function () {
            $(""#dialogLesson"").hide();
            $(""#dialog"").hide();
            $(""#dialogLessonDetail"").hide();
        });


        var initial = ""listWeek"";
        const ClassSelect = document.querySelector(""#ClassSelect"");
        const detailSelect = document.querySelector('#detailSelect');
        const planSelect = document.querySelector('#planSelect');
        async function Load() {
            const detailResponse = await fetch('");
#nullable restore
#line 141 "C:\Users\Sam\Documents\GitHub\Gym\slnGymEndTerm\prjGymEndTerm\Views\Coach\List.cshtml"
                                           Write(Url.Content("~/BackApi/detailSelect?CourseCategoryId=4"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\')\r\n            const detailDatas = await detailResponse.json()\r\n            //console.log(detailDatas)\r\n            renderdetailSelect(detailDatas)\r\n\r\n            const classResponse = await fetch(\'");
#nullable restore
#line 146 "C:\Users\Sam\Documents\GitHub\Gym\slnGymEndTerm\prjGymEndTerm\Views\Coach\List.cshtml"
                                          Write(Url.Content("~/api/selectClass/4"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\')\r\n            const classDatas = await classResponse.json()\r\n            renderClassSelect(classDatas)\r\n\r\n            //planSelect\r\n            const planResponse = await fetch(\'");
#nullable restore
#line 151 "C:\Users\Sam\Documents\GitHub\Gym\slnGymEndTerm\prjGymEndTerm\Views\Coach\List.cshtml"
                                         Write(Url.Content("~/BackApi/planSelect"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"')
            const planDatas = await planResponse.json()
            renderplanSelect(planDatas)
        }
        Load();

        function renderdetailSelect(datas) {
            detailSelect.options.length = 0;
            const opt0 = new Option('????????????')
            detailSelect.options.add(opt0)

            datas.forEach((item) => {
                const opt = new Option(`???${item.courseDetailName}`, item.courseDetailId)
                detailSelect.options.add(opt)
            })
        }

        function renderClassSelect(datas) {
            ClassSelect.options.length = 0;
            const opt0 = new Option('????????????')
            ClassSelect.options.add(opt0)

            datas.forEach((item) => {
                const opt = new Option(item.courseClassName, item.courseClassId)
                ClassSelect.options.add(opt)
            })
        }

        function renderplanSelect(datas) {

            const opt0 = new Option('????????????')
            planSelect.options.add(op");
                WriteLiteral(@"t0)

            datas.forEach((item) => {
                const opt = new Option(`???${item.discountPlan1}`, item.discountPlanId)
                planSelect.options.add(opt)
            })
        }

        document.addEventListener('DOMContentLoaded', LoadCalendat);

        function LoadCalendat() {
            var calendarEl = document.getElementById('calendar');
            var calendar = new FullCalendar.Calendar(calendarEl, {
                initialView: initial,
                locale: 'zh-tw',
                height: 582,
                slotMinTime: ""08:00:00"",
                slotMaxTime: ""23:00:00"",
                slotDuration: '01:00:00',
                slotLabelFormat: {
                    hour: '2-digit',
                    minute: '2-digit',
                    hour12: false
                },
                allDaySlot: false,
                navLinks: true,
                headerToolbar: {
                    left: 'prev,next today',
                    center:");
                WriteLiteral(@" 'title',
                    right: 'timeGridWeek,timeGridDay,listWeek'
                },
                views: {
                    timeGrid: {
                        displayEventTime: false,
                    }
                },
                eventClick: async function (info) {
                    $(""#dialogLessonDetail"").dialog({
                        height: 300,
                        width: 400
                    });
                    let response = await fetch('");
#nullable restore
#line 223 "C:\Users\Sam\Documents\GitHub\Gym\slnGymEndTerm\prjGymEndTerm\Views\Coach\List.cshtml"
                                           Write(Url.Content("~/Api/CourseRoom?LessonId="));

#line default
#line hidden
#nullable disable
                WriteLiteral("\' + info.event.id);\r\n                    let RoomName = await response.text();\r\n                    $(\"#courseName\").text(info.event.title);\r\n                    $(\"#ClassRoomName\").text(RoomName);\r\n                    $(\"#partialDetail\").load(\'");
#nullable restore
#line 227 "C:\Users\Sam\Documents\GitHub\Gym\slnGymEndTerm\prjGymEndTerm\Views\Coach\List.cshtml"
                                         Write(Url.Content("~/Coach/CouseList?LessonId="));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"' + info.event.id);
                },
                dateClick: function (info) {
                    $(""#dialogLesson"").dialog({
                        height: 500,
                        width:400
                    });
                    var time = info.dateStr;
                    var a = time.indexOf(""+"");

                    $(""#courseTime"").val(time.substring(0, a));
                },
                eventBackgroundColor: '#FFA500',
                eventTextColor: '#000000',
                events: '");
#nullable restore
#line 241 "C:\Users\Sam\Documents\GitHub\Gym\slnGymEndTerm\prjGymEndTerm\Views\Coach\List.cshtml"
                    Write(Url.Content("~/api/selectAllClass"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"'
            });
            calendar.render();
        };

        $(""#CreateClass"").click(function () {
            $(""#dialog"").dialog({
                        height: 400,
                        width:400
                    });
        })
        $(""#OK"").click(function () {
            const formData = new FormData(document.ClassForm)
            fetch('");
#nullable restore
#line 254 "C:\Users\Sam\Documents\GitHub\Gym\slnGymEndTerm\prjGymEndTerm\Views\Coach\List.cshtml"
              Write(Url.Content("~/api/InsertClass"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"', {
                        method: 'POST',
                        body: formData
                    }).then(async function (response) {
                        if (response.ok) {
                            alert(""????????????"");
                            await Load();
                        }
                        else {
                            alert(""??????"");
                        }
                    })
            $(""#dialog"").dialog(""destroy"");
        })
        $(""#AddLesson"").click(function () {
            const formData = new FormData(document.LessonForm);
            fetch('");
#nullable restore
#line 270 "C:\Users\Sam\Documents\GitHub\Gym\slnGymEndTerm\prjGymEndTerm\Views\Coach\List.cshtml"
              Write(Url.Content("~/api/InsertLesson"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"', {
                method: 'POST',
                body: formData
            }).then(async function (response) {
                if (response.ok) {
                    alert(""????????????"");
                    initial = ""timeGridWeek"";
                    LoadCalendat();
                }
                else {
                    alert(""??????"");
                }
            })
            $(""#dialogLesson"").dialog(""destroy"");
        })
        $(""#demoCourse"").click(function () {
            $(""#detailSelect"").val(""9"");
            $(""#ClassName"").val(""????????????D???"");
            $(""#planSelect"").val(""1"");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
