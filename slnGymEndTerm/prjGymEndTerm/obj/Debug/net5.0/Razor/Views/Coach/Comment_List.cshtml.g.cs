#pragma checksum "C:\Users\Sam\Documents\GitHub\Gym\slnGymEndTerm\prjGymEndTerm\Views\Coach\Comment_List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d8259b04b192fb16013583e2c5141b6cadc43fa6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Coach_Comment_List), @"mvc.1.0.view", @"/Views/Coach/Comment_List.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8259b04b192fb16013583e2c5141b6cadc43fa6", @"/Views/Coach/Comment_List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"618be0bfc67df1e664227bc268b2805b5a559654", @"/Views/_ViewImports.cshtml")]
    public class Views_Coach_Comment_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<prjGymEndTerm.ViewModels.CoachArea.CoachCommentListViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<table class=\"table table-dark table-hover\" id=\"myTable\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 7 "C:\Users\Sam\Documents\GitHub\Gym\slnGymEndTerm\prjGymEndTerm\Views\Coach\Comment_List.cshtml"
           Write(Html.DisplayNameFor(model => model[0].StudentName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 10 "C:\Users\Sam\Documents\GitHub\Gym\slnGymEndTerm\prjGymEndTerm\Views\Coach\Comment_List.cshtml"
           Write(Html.DisplayNameFor(model => model[0].ClassName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 13 "C:\Users\Sam\Documents\GitHub\Gym\slnGymEndTerm\prjGymEndTerm\Views\Coach\Comment_List.cshtml"
           Write(Html.DisplayNameFor(model => model[0].CoachName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\Sam\Documents\GitHub\Gym\slnGymEndTerm\prjGymEndTerm\Views\Coach\Comment_List.cshtml"
           Write(Html.DisplayNameFor(model => model[0].ClassScore));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\Sam\Documents\GitHub\Gym\slnGymEndTerm\prjGymEndTerm\Views\Coach\Comment_List.cshtml"
           Write(Html.DisplayNameFor(model => model[0].ClassRecord));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\Sam\Documents\GitHub\Gym\slnGymEndTerm\prjGymEndTerm\Views\Coach\Comment_List.cshtml"
           Write(Html.DisplayNameFor(model => model[0].RecordTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 27 "C:\Users\Sam\Documents\GitHub\Gym\slnGymEndTerm\prjGymEndTerm\Views\Coach\Comment_List.cshtml"
          
            int count = 0;
            foreach (var item in Model)
            {
                count++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 34 "C:\Users\Sam\Documents\GitHub\Gym\slnGymEndTerm\prjGymEndTerm\Views\Coach\Comment_List.cshtml"
                   Write(Html.DisplayFor(modelItem => item.StudentName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 37 "C:\Users\Sam\Documents\GitHub\Gym\slnGymEndTerm\prjGymEndTerm\Views\Coach\Comment_List.cshtml"
                   Write(Html.DisplayFor(modelItem => item.ClassName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 40 "C:\Users\Sam\Documents\GitHub\Gym\slnGymEndTerm\prjGymEndTerm\Views\Coach\Comment_List.cshtml"
                   Write(Html.DisplayFor(modelItem => item.CoachName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 43 "C:\Users\Sam\Documents\GitHub\Gym\slnGymEndTerm\prjGymEndTerm\Views\Coach\Comment_List.cshtml"
                   Write(Html.DisplayFor(modelItem => item.ClassScore));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 46 "C:\Users\Sam\Documents\GitHub\Gym\slnGymEndTerm\prjGymEndTerm\Views\Coach\Comment_List.cshtml"
                   Write(Html.DisplayFor(modelItem => item.ClassRecord));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 49 "C:\Users\Sam\Documents\GitHub\Gym\slnGymEndTerm\prjGymEndTerm\Views\Coach\Comment_List.cshtml"
                   Write(Html.DisplayFor(modelItem => item.RecordTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 52 "C:\Users\Sam\Documents\GitHub\Gym\slnGymEndTerm\prjGymEndTerm\Views\Coach\Comment_List.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<prjGymEndTerm.ViewModels.CoachArea.CoachCommentListViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
