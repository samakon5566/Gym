#pragma checksum "C:\Users\Sam\Documents\GitHub\Gym\slnGymEndTerm\prjGymEndTerm\Views\purchase\OrderPurchaselistAll.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "947a8b72b51017255174f1dd453b8793457accd4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_purchase_OrderPurchaselistAll), @"mvc.1.0.view", @"/Views/purchase/OrderPurchaselistAll.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"947a8b72b51017255174f1dd453b8793457accd4", @"/Views/purchase/OrderPurchaselistAll.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"618be0bfc67df1e664227bc268b2805b5a559654", @"/Views/_ViewImports.cshtml")]
    public class Views_purchase_OrderPurchaselistAll : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<prjGymEndTerm.ViewModels.CNormalPurchase>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("purchase-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("formCreditCard"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("accept-charset", new global::Microsoft.AspNetCore.Html.HtmlString("UTF-8"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("https://payment-stage.opay.tw/Cashier/AioCheckOut/V5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Purchase.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Sam\Documents\GitHub\Gym\slnGymEndTerm\prjGymEndTerm\Views\purchase\OrderPurchaselistAll.cshtml"
  
    ViewData["Title"] = "OrderPurchaselistAll";

#line default
#line hidden
#nullable disable
            DefineSection("Style", async() => {
                WriteLiteral(@"
<style>
    .btn:focus{
        box-shadow:none;
    }
    .modal-content .modal-body .each-comment{
            height:25px;
    }
    .form-group th,td{
        text-align:center;
    }
    #purch-list td {
        line-height: 200px;
    }
    .modal-header {
        display: flex;
        justify-content: flex-start;
        align-items: center;
        align-content: stretch;
        flex-wrap: wrap;
        flex-direction: column;
        font-size:18px;
        margin-bottom:5px;
    }
    .modal-title {
        display: flex;
        flex-wrap: wrap;
        flex-direction: row;
        align-content: flex-start;
        justify-content: center;
        font-size: 24px;
        font-weight: 900;
        margin-bottom: -20px;
    }
    .modal-title div, span {
        text-align: center;
        width: 100%;
        font-size: 18px;
        font-weight: 500;
        margin-top: 5px;
    }
    .modal-header a.close {
        bottom: 60px;
        left: -10px;
                WriteLiteral(@"
        width: 50px;
        height: 50px;
        float: right;
        font-size: 1.5rem;
        font-weight: 700;
        line-height: 1;
        color: #000;
        text-shadow: 0 1px 0 #fff;
        opacity: .5;
        border-radius: 50%;
        position: relative;
    }
    a.close i {
        position: absolute;
        top: 50%;
        left: 50%;
        transform: translate(-50%, -50%);
    }
    .btn-pay-close{
        position:relative;
    }
    .btn-pay-close span{
        position: absolute;
        font-size: 50px;
        right: 28px;
        top: -33px;
    }
    ");
            }
            );
            WriteLiteral(@"</style>
}



<div class=""outer-purchase-frame"">
    <div class=""purchase-frame"">
        <div class=""accordion"" id=""accordionExample"">
            <div class=""card"">
                <div class=""card-header"" id=""headingOne"">
                    <h2 style=""text-align:center"" class=""mb-0"">課　程　結　帳</h2>
                </div>

                <div id=""collapseOne"" class=""collapse show"" aria-labelledby=""headingOne"" data-parent=""#accordionExample"">
                    <div class=""card-body"">
                        <div class=""form-group"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "947a8b72b51017255174f1dd453b8793457accd48313", async() => {
                WriteLiteral(@"
                                <table class=""table"" id=""classtable"">
                                    <thead class=""thead-dark"">
                                    <tr>
                                        <th scope=""col"">#</th>
                                        <th scope=""col"">課程照片</th>
                                        <th scope=""col"">課程種類</th>
                                        <th scope=""col"">課程類型</th>
                                        <th scope=""col"">課程班名</th>
                                        <th scope=""col"">課程資訊</th>
                                        <th scope=""col"">折扣方案</th>
                                        <th scope=""col"">金額</th>
                                    </tr>
                                    </thead>
                                    <tbody id=""purch-list"">
");
#nullable restore
#line 109 "C:\Users\Sam\Documents\GitHub\Gym\slnGymEndTerm\prjGymEndTerm\Views\purchase\OrderPurchaselistAll.cshtml"
                                          
                                            int count = 0;
                                            foreach(var item in Model)
                                            {
                                                count++;

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                <tr>\r\n                                                    <td hidden=\"hidden\" class=\"classID\">");
#nullable restore
#line 115 "C:\Users\Sam\Documents\GitHub\Gym\slnGymEndTerm\prjGymEndTerm\Views\purchase\OrderPurchaselistAll.cshtml"
                                                                                   Write(item.txtclassID);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                                    <td>");
#nullable restore
#line 116 "C:\Users\Sam\Documents\GitHub\Gym\slnGymEndTerm\prjGymEndTerm\Views\purchase\OrderPurchaselistAll.cshtml"
                                                   Write(count);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                                    <td align=\"center\"><div class=\"img-bx-16-pay img-invert\">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "947a8b72b51017255174f1dd453b8793457accd410908", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 4000, "~/img/CourseDetail/", 4000, 19, true);
#nullable restore
#line 117 "C:\Users\Sam\Documents\GitHub\Gym\slnGymEndTerm\prjGymEndTerm\Views\purchase\OrderPurchaselistAll.cshtml"
AddHtmlAttributeValue("", 4019, item.txtClassPic, 4019, 17, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</div></td>\r\n                                                    <td>");
#nullable restore
#line 118 "C:\Users\Sam\Documents\GitHub\Gym\slnGymEndTerm\prjGymEndTerm\Views\purchase\OrderPurchaselistAll.cshtml"
                                                   Write(item.txtCourseCategory);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                                    <td>");
#nullable restore
#line 119 "C:\Users\Sam\Documents\GitHub\Gym\slnGymEndTerm\prjGymEndTerm\Views\purchase\OrderPurchaselistAll.cshtml"
                                                   Write(item.txtCourseDetail);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                                    <td class=\"courseclassname\">");
#nullable restore
#line 120 "C:\Users\Sam\Documents\GitHub\Gym\slnGymEndTerm\prjGymEndTerm\Views\purchase\OrderPurchaselistAll.cshtml"
                                                                           Write(item.txtCourseClassName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                                    <td><a href=\"#exampleModal\" class=\"btn btn-primary lesson-btn\" data-toggle=\"modal\">點選這裡</a></td>\r\n                                                    <td>");
#nullable restore
#line 122 "C:\Users\Sam\Documents\GitHub\Gym\slnGymEndTerm\prjGymEndTerm\Views\purchase\OrderPurchaselistAll.cshtml"
                                                   Write(item.txtDiscountPlan);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                                    <td>");
#nullable restore
#line 123 "C:\Users\Sam\Documents\GitHub\Gym\slnGymEndTerm\prjGymEndTerm\Views\purchase\OrderPurchaselistAll.cshtml"
                                                   Write(item.txtMoney);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                                </tr>\r\n");
#nullable restore
#line 125 "C:\Users\Sam\Documents\GitHub\Gym\slnGymEndTerm\prjGymEndTerm\Views\purchase\OrderPurchaselistAll.cshtml"
                                            }
                                        

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                    </tbody>
                                </table>
                                <div class=""form-group"">
                                    <table class=""table"" id=""price"">
                                        <tbody>
");
#nullable restore
#line 132 "C:\Users\Sam\Documents\GitHub\Gym\slnGymEndTerm\prjGymEndTerm\Views\purchase\OrderPurchaselistAll.cshtml"
                                              
                                                decimal initialmoney = 0;
                                                decimal discountmoney = 0;
                                                foreach(var item in Model)
                                                {
                                                    initialmoney += item.txtinitailMoney;
                                                    discountmoney += item.txtdiscountMoney;
                                                }
                                                decimal totalpaid = initialmoney - discountmoney;


#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <tr><td>總課程金額:</td><td>NT$");
#nullable restore
#line 142 "C:\Users\Sam\Documents\GitHub\Gym\slnGymEndTerm\prjGymEndTerm\Views\purchase\OrderPurchaselistAll.cshtml"
                                                                 Write(initialmoney);

#line default
#line hidden
#nullable disable
                WriteLiteral(".00</td></tr>\r\n                                            <tr><td>折扣金額:</td><td>NT$");
#nullable restore
#line 143 "C:\Users\Sam\Documents\GitHub\Gym\slnGymEndTerm\prjGymEndTerm\Views\purchase\OrderPurchaselistAll.cshtml"
                                                                Write(discountmoney);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td></tr>\r\n                                            <tr><td>總應付金額:</td><td id=\"paidmoney\">NT$");
#nullable restore
#line 144 "C:\Users\Sam\Documents\GitHub\Gym\slnGymEndTerm\prjGymEndTerm\Views\purchase\OrderPurchaselistAll.cshtml"
                                                                                Write(totalpaid);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td></tr>\r\n                                            <tr><td><i class=\"fas fa-money-bill-wave\">付款方式</i></td><td><a data-toggle=\"modal\" href=\"#paidwayModal\" id=\"current-paid-way\" class=\"btn btn-light\"><i class=\"fas fa-sort-down\">請選擇</i></a></td></tr>\r\n");
                WriteLiteral(@"                                        </tbody>
                                    </table>
                                </div>
                                <div class=""form-group"" hidden>
                                    MerchantID 商店代號:
                                    <input type=""text"" name=""MerchantID"" value=""2000132"" /><br />

                                    MerchantTradeNo 商店交易編號:
                                    <input type=""text"" id=""merchantTradeNo"" name=""MerchantTradeNo""");
                BeginWriteAttribute("value", " value=\"", 6817, "\"", 6825, 0);
                EndWriteAttribute();
                WriteLiteral(" /><br />\r\n\r\n                                    MerchantTradeDate 商店交易時間:\r\n                                    <input type=\"text\" id=\"dealtime\" name=\"MerchantTradeDate\"");
                BeginWriteAttribute("value", " value=\"", 6995, "\"", 7003, 0);
                EndWriteAttribute();
                WriteLiteral(@" /><br />

                                    PaymentType 交易類型:
                                    <input type=""text"" name=""PaymentType"" value=""aio"" /><br />

                                    TotalAmount 交易金額:
                                    <input type=""text"" id=""dealmoney"" name=""TotalAmount""");
                BeginWriteAttribute("value", " value=\"", 7313, "\"", 7321, 0);
                EndWriteAttribute();
                WriteLiteral(@" /><br />

                                    TradeDesc 交易描述:
                                    <input type=""text"" name=""TradeDesc"" value=""建立信用卡測試訂單"" /><br />

                                    ItemName 商品名稱:
                                    <input type=""text"" id=""itemName"" name=""ItemName"" value=""aaa"" /><br />

                                    ReturnURL 付款完成通知回傳網址:
                                    <input type=""text"" name=""ReturnURL"" id=""returnURL""");
                BeginWriteAttribute("value", " value=\"", 7796, "\"", 7804, 0);
                EndWriteAttribute();
                WriteLiteral(@" /><br />

                                    ChoosePayment 預設付款方式:
                                    <input type=""text"" id=""choosePayment"" name=""ChoosePayment"" value=""Credit"" /><br />

                                    會員商店代碼:
                                    <input type=""text"" name=""StoreID""");
                BeginWriteAttribute("value", " value=\"", 8113, "\"", 8121, 0);
                EndWriteAttribute();
                WriteLiteral(" /><br />\r\n\r\n                                    ClientBackURL Client端返回廠商網址:\r\n                                    <input type=\"text\" name=\"ClientBackURL\" id=\"clientBackURL\"");
                BeginWriteAttribute("value", " value=\"", 8295, "\"", 8303, 0);
                EndWriteAttribute();
                WriteLiteral(" /><br />\r\n\r\n                                    CreditInstallment 刷卡分期期數:\r\n                                    <input type=\"text\" name=\"CreditInstallment\"");
                BeginWriteAttribute("value", " value=\"", 8459, "\"", 8467, 0);
                EndWriteAttribute();
                WriteLiteral(" /><br />\r\n\r\n                                    InstallmentAmount 使用刷卡分期的付款金額:\r\n                                    <input type=\"text\" name=\"InstallmentAmount\"");
                BeginWriteAttribute("value", " value=\"", 8628, "\"", 8636, 0);
                EndWriteAttribute();
                WriteLiteral(" /><br />\r\n\r\n                                    Redeem 信用卡是否使用紅利折抵:\r\n                                    <input type=\"text\" name=\"Redeem\"");
                BeginWriteAttribute("value", " value=\"", 8775, "\"", 8783, 0);
                EndWriteAttribute();
                WriteLiteral(@" /><br />

                                    CheckMacValue 簽章類型:
                                    <input type=""text"" name=""EncryptType"" value=""1"" /><br />

                                    CheckMacValue 檢查碼:
                                    <input type=""text"" id=""CheckMacValue"" name=""CheckMacValue""");
                BeginWriteAttribute("value", " value=\"", 9100, "\"", 9108, 0);
                EndWriteAttribute();
                WriteLiteral(@" /><br />
                                </div>
                                <div class=""form-group"" id=""check-out"">
                                    <div class=""form-check"">
                                        <input class=""form-check-input"" type=""checkbox"" id=""gridCheck"">
                                        <label class=""form-check-label"" for=""gridCheck"">
                                            確認請點選
                                        </label>
                                    </div>
                                    <input type=""submit"" style="" margin-left: 70px; margin-right: 40px;"" disabled=""disabled"" class=""btn btn-primary 1st-save"" value=""送出訂單"">
                                </div>
                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
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
            </div>                       
        </div>
    </div>
</div>

<div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-dialog-centered modal-dialog-scrollable"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <div class=""modal-title"" id=""exampleModalLabel"">
                    <div>課程名稱：</div>
                    <div>剩餘人數：</div>
                    <div>授課教練：</div>
                </div>
");
            WriteLiteral(@"                <a class=""close"" data-dismiss=""modal""><i class=""fas fa-times""></i></a>
            </div>
            <div class=""modal-body"" style=""padding:0;"">
                <div class=""each-comment"">
                    
                </div>
            </div>
            <div class=""modal-footer"">
                <a href=""#"" class=""btn"" data-dismiss=""modal"">關閉</a>
            </div>
        </div>
    </div>
</div>

<div class=""modal fade"" id=""paidwayModal"" tabindex=""-1"">
  <div class=""modal-dialog"">
    <div class=""modal-content"">
      <div class=""modal-header"">
        <h5 class=""modal-title"">付款方式</h5>>
        <button type=""button"" class=""close btn-pay-close"" data-dismiss=""modal"" aria-label=""Close"">
          <span aria-hidden=""true"">&times;</span>
        </button>
      </div>
      <div class=""modal-body"">
        <ul class=""list-group"">
          <a class=""list-group-item list-group-item-action"" data-payway=""cash"">
            現金
          </a>
          <a class=""l");
            WriteLiteral(@"ist-group-item list-group-item-action"" data-payway=""Credit"" >信用卡</a>          
          <a class=""list-group-item list-group-item-action"" data-payway=""CVS"">超商代碼繳費</a>
        </ul>
      </div>
      <div class=""modal-footer"">
        <button type=""button"" id=""confirm-paidway"" data-dismiss=""modal"" class=""btn btn-primary"">確認</button>
        <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">返回</button>
      </div>
    </div>
  </div>
</div>
<script src=""https://code.jquery.com/jquery-3.6.0.min.js"" integrity=""sha256-/xUj+3OJU5yExlq6GSYGSHk7tPXikynS7ogEvDej/m4="" crossorigin=""anonymous""></script>
");
            DefineSection("Scripts", async() => {
                WriteLiteral(" \r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "947a8b72b51017255174f1dd453b8793457accd426820", async() => {
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
                WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<prjGymEndTerm.ViewModels.CNormalPurchase>> Html { get; private set; }
    }
}
#pragma warning restore 1591