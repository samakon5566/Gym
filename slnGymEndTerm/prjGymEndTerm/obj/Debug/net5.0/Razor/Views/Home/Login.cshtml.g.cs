#pragma checksum "C:\Users\Sam\Documents\GitHub\Gym\slnGymEndTerm\prjGymEndTerm\Views\Home\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d1a3321d3f90cef9d5a36dd6173aae72494fae31"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Login), @"mvc.1.0.view", @"/Views/Home/Login.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1a3321d3f90cef9d5a36dd6173aae72494fae31", @"/Views/Home/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"618be0bfc67df1e664227bc268b2805b5a559654", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<int>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color: #FFA500"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("Login"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("Login-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("LoginData"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("forgetForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/16img/tdeeback1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-top: 200px; position: absolute; opacity: 0.3; height: 100%; width: 100%; z-index: -1; top: -200px "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Sam\Documents\GitHub\Gym\slnGymEndTerm\prjGymEndTerm\Views\Home\Login.cshtml"
  
    ViewData["Title"] = "List";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    .demo-button {
        text-align:center;
        display: flex;
        justify-content: center;
        align-items: center;
        flex-grow: 1;
        font-weight: 700;
        /*        height: 50px;*/
        /*        text-align:center;*/
        background-color: #FFA500;
        color: #151515;
        width: 30%;
        margin: 20px;
        font-size: 15px;
        cursor: pointer;
    }
</style>

<!DOCTYPE html>
<html>


");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d1a3321d3f90cef9d5a36dd6173aae72494fae317971", async() => {
                WriteLiteral("\r\n    <title>??????</title>\r\n\r\n    <meta charset=\"utf-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0, user-scalable=0, minimal-ui\">\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\" />\r\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 784, "\"", 794, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <meta name=\"keywords\"");
                BeginWriteAttribute("content", " content=\"", 825, "\"", 835, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n    <meta name=\"author\" content=\"Phoenixcoded\" />\r\n    <!-- Favicon icon -->\r\n    <link rel=\"icon\" href=\"assets/images/favicon.ico\" type=\"image/x-icon\">\r\n\r\n    <!-- vendor css -->\r\n    <link rel=\"stylesheet\" href=\"assets/css/style.css\">\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d1a3321d3f90cef9d5a36dd6173aae72494fae319825", async() => {
                WriteLiteral(@"
    <!-- [ auth-signin ] start -->
    <div class=""row"" style=""width: 100%; margin:200px auto; "">
        <div class=""col-lg-6"" style=""margin:80px auto;padding:0 200px"">
            <div class=""section-title chart-calculate-title"">
                <span style=""color:#FFA500"">Login Member</span>
                <h2>????????????</h2>
            </div>
            <div class=""chart-calculate-form"">
                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d1a3321d3f90cef9d5a36dd6173aae72494fae3110512", async() => {
                    WriteLiteral(@"
                    <div>
                        <div class=""col-sm-6"">
                            <input type=""text"" name=""txtAccount"" placeholder=""???????????????"" style=""width:210%;border:1px solid #8E8E8E"">
                        </div>
                        <div class=""col-sm-6"">
                            <input type=""password"" name=""txtPassword"" placeholder=""???????????????"" style=""width:210%;border:1px solid #8E8E8E"">
                        </div>

                        <div class=""custom-control custom-checkbox text-left mb-4 mt-2"" style=""margin:0 20px"">
                            <input type=""checkbox"" class=""custom-control-input"" id=""customCheck1"">
                            <label class=""custom-control-label"" for=""customCheck1"" style=""color:#E0E0E0;"">??????????????????</label>
                        </div>
                        <div class=""col-lg-12"" style=""display:flex;margin:auto"">
                            <button id=""Login""  type=""button"" style=""background-color: #FFA500; color: #151515; width:");
                    WriteLiteral(@" 30%; margin:20px auto;font-size:15px"" >??????</button>
                            <a class=""demo-button"" id=""Coach-Demo"">??????Demo</a>
                            <a class=""demo-button"" id=""Member-Demo"">??????Demo</a>
                            <a class=""demo-button"" id=""Admin-Demo1"" style=""width:32%"">?????????Demo</a>
                        </div>

                        <hr style=""background-color: #5B5B5B "">
                        <div>
                            <div style="" text-align: center "">
                                <p class=""mb-2 text-muted"">????????????? ???<a data-toggle=""modal"" href=""#forgetpassword"" class=""f-w-400"" style=""color: #FFA500"">????????????</a></p>
                            </div>
                            <div style=""text-align: center "">
                                <p class=""mb-0 text-muted"">???????????????????");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d1a3321d3f90cef9d5a36dd6173aae72494fae3112753", async() => {
                        WriteLiteral("????????????");
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
                    WriteLiteral("</p>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
            </div>
        </div>
    </div>

    <div>
        <div class=""modal fade"" id=""forgetpassword"" tabindex=""-1"" aria-hidden=""true"">
            <div class=""modal-dialog modal-dialog-centered modal-dialog-scrollable"">
                <div class=""modal-content"" style=""width:80%"">
                    <div class=""modal-header"">
                        <h5 class=""modal-title "" id=""exampleModalLabel"">????????????</h5>
                        <a class=""close"" data-dismiss=""modal""><i class=""fas fa-times""></i></a>
                    </div>
                    <div style=""margin: auto; position: relative"" class=""modal-body text-center"">
                        <p style=""color:#5B5B5B;margin-top:20px"">?????????????????????????????????<br>?????????????????????????????????????????????????????????????????????</p>
                    </div>
                    <div style="" margin: auto; position: relative"" class=""login-form formplate"">
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d1a3321d3f90cef9d5a36dd6173aae72494fae3116691", async() => {
                    WriteLiteral(@"
                            <div>
                                <label>????????????:</label>
                                <input placeholder=""????????????"" name=""email"" type=""email"" id=""accountInput"">
                            </div>
                            <div>
                                <label>????????????:</label>
                                <input placeholder=""??????????????????"" name=""email"" type=""email"" id=""emailInput"">
                            </div>
                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                        <P style=""margin: 20px auto; display: flex; justify-content: center; color: whitesmoke; background-color: #9D9D9D "" id=""check""></P>
                        <hr />
                        <input style=""width: 25%; margin:auto; position: relative"" type=""submit"" value=""??????"" class=""btn btn-block btn-primary mb-4"" id=""submitBtn"">
                        <div style=""display:flex;justify-content:center"">
                            <a class=""demo-button"" id=""errDemo"">??????Demo</a>
                            <a class=""demo-button"" id=""rightDemo"">??????Demo</a>
                        </div>
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d1a3321d3f90cef9d5a36dd6173aae72494fae3119232", async() => {
                    WriteLiteral(@"
                            <input type=""text"" name=""MemberName"" id=""MemberName"" hidden>
                            <input type=""text"" name=""password"" id=""password"" hidden>
                            <input type=""text"" name=""MemberEmail"" id=""MemberEmail"" hidden>
                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n        <button type=\"button\" hidden=\"hidden\" id=\"trigger-no-session\" ");
                WriteLiteral(@" class=""btn btn-primary"" data-toggle=""modal"" data-target=""#exampleModal"">
            trigger no-session
        </button>
        <div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
            <div class=""modal-dialog"">
                <div class=""modal-content"">
                    <div class=""modal-header"">
                        <h5 class=""modal-title"" id=""exampleModalLabel"">??????</h5>
                        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                            <span aria-hidden=""true"">&times;</span>
                        </button>
                    </div>
                    <div class=""modal-body"">
                        ????????????????????????
                    </div>
                    <div class=""modal-footer"">
                        <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">??????</button>
                    </div>
                </div>
            </di");
                WriteLiteral("v>\r\n        </div>\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d1a3321d3f90cef9d5a36dd6173aae72494fae3122277", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    </div>\r\n    <!-- [ auth-signin ] end -->\r\n    <!-- Required Js -->\r\n    <script src=\"assets/js/vendor-all.min.js\"></script>\r\n    <script src=\"assets/js/plugins/bootstrap.min.js\"></script>\r\n    <script src=\"assets/js/pcoded.min.js\"></script>\r\n");
                DefineSection("Scripts", async() => {
                    WriteLiteral("\r\n        <script>\r\n            $(\"#Login\").click(function () {\r\n                const formData = new FormData(document.LoginData);\r\n                fetch(\'");
#nullable restore
#line 161 "C:\Users\Sam\Documents\GitHub\Gym\slnGymEndTerm\prjGymEndTerm\Views\Home\Login.cshtml"
                  Write(Url.Content("~/api/Login"));

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"', {
                    method: 'POST',  //GET???POST???PUT???DELETE
                    body: formData    //json string
                }).then(response => response.text())
                    .then(data => {
                        if (data == 1)
                            window.location.href = '");
#nullable restore
#line 167 "C:\Users\Sam\Documents\GitHub\Gym\slnGymEndTerm\prjGymEndTerm\Views\Home\Login.cshtml"
                                               Write(Url.Action("List", "BackHome"));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\';\r\n                        else if (data == 2)\r\n                            window.location.href = \'");
#nullable restore
#line 169 "C:\Users\Sam\Documents\GitHub\Gym\slnGymEndTerm\prjGymEndTerm\Views\Home\Login.cshtml"
                                               Write(Url.Action("List", "PersonalArea"));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\';\r\n                        else if (data == 3)\r\n                            window.location.href = \'");
#nullable restore
#line 171 "C:\Users\Sam\Documents\GitHub\Gym\slnGymEndTerm\prjGymEndTerm\Views\Home\Login.cshtml"
                                               Write(Url.Action("List", "Coach"));

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"';
                        else {
                            swal('????????????','','warning');
                        }
                    })
            })


                $(""#Coach-Demo"").click(function () {
                    $(""#Login-form input"").eq(0).val(""jason555"");
                    $(""#Login-form input"").eq(1).val(""jason123"");
                })
                $(""#Member-Demo"").click(function () {
                    $(""#Login-form input"").eq(0).val(""uCNT3829"");
                    $(""#Login-form input"").eq(1).val(""kuGZ8535"");
                })
                $(""#Admin-Demo1"").click(function () {
                    $(""#Login-form input"").eq(0).val(""FhRl1481"");
                    $(""#Login-form input"").eq(1).val(""TlVq0105"");
                })
            $(""#errDemo"").click(function () {
                $(""#forgetForm input"").eq(0).val(""FhRl148"");
                $(""#forgetForm input"").eq(1).val(""a102362000@gmail.com"");
            })
            $(""#rightDemo"").click(f");
                    WriteLiteral("unction () {\r\n                $(\"#forgetForm input\").eq(0).val(\"FhRl1481\");\r\n                $(\"#forgetForm input\").eq(1).val(\"a102362000@gmail.com\");\r\n            })\r\n\r\n                $(function () {\r\n                    console.log(");
#nullable restore
#line 201 "C:\Users\Sam\Documents\GitHub\Gym\slnGymEndTerm\prjGymEndTerm\Views\Home\Login.cshtml"
                           Write(Model);

#line default
#line hidden
#nullable disable
                    WriteLiteral(");\r\n                    if(!");
#nullable restore
#line 202 "C:\Users\Sam\Documents\GitHub\Gym\slnGymEndTerm\prjGymEndTerm\Views\Home\Login.cshtml"
                   Write(Model);

#line default
#line hidden
#nullable disable
                    WriteLiteral(")\r\n                    $(\"#trigger-no-session\").trigger(\"click\");\r\n                })\r\n        </script>\r\n\r\n\r\n");
                    WriteLiteral(@"        <script>

            const submitBtn = document.querySelector('#submitBtn')


            submitBtn.addEventListener('click', async function () {

            const account = $('#accountInput').val()
            const email = $('#emailInput').val()

            const passwordResponse = await fetch('");
#nullable restore
#line 219 "C:\Users\Sam\Documents\GitHub\Gym\slnGymEndTerm\prjGymEndTerm\Views\Home\Login.cshtml"
                                             Write(Url.Content("~/BackApi/ForgotPassword?account="));

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"' + account + '&email=' + email)


            const passwordDatas = await passwordResponse.json()
            //console.log(passwordDatas)

             if (passwordDatas == '????????????')
             {
                 $('#check')[0].innerHTML = '????????????????????????????????????<a href=""");
#nullable restore
#line 227 "C:\Users\Sam\Documents\GitHub\Gym\slnGymEndTerm\prjGymEndTerm\Views\Home\Login.cshtml"
                                                             Write(Url.Action("create", "Home"));

#line default
#line hidden
#nullable disable
                    WriteLiteral(@""" style=""margin-left:10px"">????????????</a>'
             }
             else
             {
                 console.log(""A"")
                 sendLetterDetail(passwordDatas)
                 console.log(""B"")


                 // ??????????????????
                 var evt = document.createEvent(""HTMLEvents"");
                 // ?????????
                 evt.initEvent(""submit"", false, false);
                 //????????????
                 document.querySelector('#form').dispatchEvent(evt)


             }

    })

            //????????????????????????????????????input
    function sendLetterDetail(passwordDatas) {

        $('#MemberName').val(passwordDatas.logInName)
        $('#password').val(passwordDatas.logInPassword)
        $('#MemberEmail').val(passwordDatas.logInEmail)

    }


        </script>



");
                    WriteLiteral(@"        <script>

            $('#accountInput').focus(function () { $('#check')[0].innerHTML = """" });
            $('#emailInput').focus(function () { $('#check')[0].innerHTML = """" });

        </script>




        <script type=""text/javascript"" src=""https://cdn.jsdelivr.net/npm/emailjs-com@3/dist/email.min.js""></script>
        <script type=""text/javascript"">emailjs.init('user_bPwkeJvMOntP9asXPUyOe')</script>


");
                    WriteLiteral(@"        <script>

        const btn = document.getElementById('button');

        document.getElementById('form').addEventListener('submit', function (event) {

            event.preventDefault();

            const serviceID = 'default_service';
            const templateID = 'template_3w1awpf';

            emailjs.sendForm(serviceID, templateID, this)
                .then(() => {

                    confirm('?????????????????????????????????Email??????????????????!')

                    if (confirm) {
                        console.log(""A"")
                        window.location.href = '");
#nullable restore
#line 296 "C:\Users\Sam\Documents\GitHub\Gym\slnGymEndTerm\prjGymEndTerm\Views\Home\Login.cshtml"
                                           Write(Url.Action("Login", "Home"));

#line default
#line hidden
#nullable disable
                    WriteLiteral("?flag=1\';\r\n\r\n                    }\r\n\r\n                }\r\n                    , (err) => {\r\n                        alert(\'????????????????????????????????????????????????????\');\r\n                    });\r\n        });\r\n\r\n        </script>\r\n\r\n\r\n    ");
                }
                );
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<int> Html { get; private set; }
    }
}
#pragma warning restore 1591
