#pragma checksum "C:\Users\User\Documents\Visual Studio 2019\Projects\TimeSheet Management\WebApplication1\Views\User\ChangeProjectRequests.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "68947e8e5eb4117662b8f68f5cf62238b2d941d4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_ChangeProjectRequests), @"mvc.1.0.view", @"/Views/User/ChangeProjectRequests.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/ChangeProjectRequests.cshtml", typeof(AspNetCore.Views_User_ChangeProjectRequests))]
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
#line 1 "C:\Users\User\Documents\Visual Studio 2019\Projects\TimeSheet Management\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#line 2 "C:\Users\User\Documents\Visual Studio 2019\Projects\TimeSheet Management\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68947e8e5eb4117662b8f68f5cf62238b2d941d4", @"/Views/User/ChangeProjectRequests.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_User_ChangeProjectRequests : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TimeSheetManagement.ViewModels.RequestsListViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\User\Documents\Visual Studio 2019\Projects\TimeSheet Management\WebApplication1\Views\User\ChangeProjectRequests.cshtml"
  
    ViewData["Title"] = "ChangeProjectRequests";

#line default
#line hidden
            BeginContext(132, 378, true);
            WriteLiteral(@"
<h1>Requests List</h1>

<table class=""table"">
        <thead>
            <tr>
                <th>
                    Project Name
                </th>
                <th>
                    Project Description
                </th>
                <th>
                    Status
                </th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 23 "C:\Users\User\Documents\Visual Studio 2019\Projects\TimeSheet Management\WebApplication1\Views\User\ChangeProjectRequests.cshtml"
             if (Model.Any())
            {

                foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(622, 84, true);
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(707, 46, false);
#line 30 "C:\Users\User\Documents\Visual Studio 2019\Projects\TimeSheet Management\WebApplication1\Views\User\ChangeProjectRequests.cshtml"
                       Write(Html.DisplayFor(modelItem => item.ProjectName));

#line default
#line hidden
            EndContext();
            BeginContext(753, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(845, 53, false);
#line 33 "C:\Users\User\Documents\Visual Studio 2019\Projects\TimeSheet Management\WebApplication1\Views\User\ChangeProjectRequests.cshtml"
                       Write(Html.DisplayFor(modelItem => item.ProjectDescription));

#line default
#line hidden
            EndContext();
            BeginContext(898, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(990, 41, false);
#line 36 "C:\Users\User\Documents\Visual Studio 2019\Projects\TimeSheet Management\WebApplication1\Views\User\ChangeProjectRequests.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
            EndContext();
            BeginContext(1031, 60, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 39 "C:\Users\User\Documents\Visual Studio 2019\Projects\TimeSheet Management\WebApplication1\Views\User\ChangeProjectRequests.cshtml"
                }
            }

#line default
#line hidden
            BeginContext(1125, 36, true);
            WriteLiteral("            </tbody>\r\n</table>\r\n\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TimeSheetManagement.ViewModels.RequestsListViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
