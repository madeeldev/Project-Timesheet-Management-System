#pragma checksum "C:\Users\User\Documents\Visual Studio 2019\Projects\TimeSheet Management\WebApplication1\Views\User\ShowTimeSheetViewOnly.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "032f0a7bc61a29a9adda66ef1eb37092107bb6e2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_ShowTimeSheetViewOnly), @"mvc.1.0.view", @"/Views/User/ShowTimeSheetViewOnly.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/ShowTimeSheetViewOnly.cshtml", typeof(AspNetCore.Views_User_ShowTimeSheetViewOnly))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"032f0a7bc61a29a9adda66ef1eb37092107bb6e2", @"/Views/User/ShowTimeSheetViewOnly.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_User_ShowTimeSheetViewOnly : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TimeSheetManagement.ViewModels.DisplayTimeSheet>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\User\Documents\Visual Studio 2019\Projects\TimeSheet Management\WebApplication1\Views\User\ShowTimeSheetViewOnly.cshtml"
  
    ViewData["Title"] = "TimesheetViewOnly";
    Layout = "~/Views/Layouts/_IndLayout.cshtml";

#line default
#line hidden
            BeginContext(173, 1302, true);
            WriteLiteral(@"
    <div class=""col-md-12"">
        <!-- Area Chart -->
        <div class="""">
            <div class=""card shadow mb-4 border-left-primary shadow h-100 py-2"">
                <!-- Card Header - Dropdown -->
                <div class=""card-header py-3 d-flex flex-row align-items-center justify-content-between"">
                    <h6 class=""m-0 font-weight-bold text-primary"">View Timesheet</h6>
                </div>
                <!-- Card Body -->
                <div class=""card-body"">
                    <div class="""">
                        <div class=""table-responsive"">
                            <table class=""table table-hover"">
                                <thead>
                                    <tr>
                                        <th>
                                            Date
                                        </th>
                                        <th>Task</th>
                                        <th>Task Type</th>
                  ");
            WriteLiteral(@"                      <th>Hours Spent</th>
                                        <th>Status</th>
                                        <th></th>
                                    </tr>
                                </thead>
                                <tbody>
");
            EndContext();
#line 33 "C:\Users\User\Documents\Visual Studio 2019\Projects\TimeSheet Management\WebApplication1\Views\User\ShowTimeSheetViewOnly.cshtml"
                                     foreach (var item in Model)
                                    {

#line default
#line hidden
            BeginContext(1580, 94, true);
            WriteLiteral("                                        <tr>\r\n                                            <td>");
            EndContext();
            BeginContext(1675, 9, false);
#line 36 "C:\Users\User\Documents\Visual Studio 2019\Projects\TimeSheet Management\WebApplication1\Views\User\ShowTimeSheetViewOnly.cshtml"
                                           Write(item.Date);

#line default
#line hidden
            EndContext();
            BeginContext(1684, 55, true);
            WriteLiteral("</td>\r\n                                            <td>");
            EndContext();
            BeginContext(1740, 9, false);
#line 37 "C:\Users\User\Documents\Visual Studio 2019\Projects\TimeSheet Management\WebApplication1\Views\User\ShowTimeSheetViewOnly.cshtml"
                                           Write(item.Task);

#line default
#line hidden
            EndContext();
            BeginContext(1749, 55, true);
            WriteLiteral("</td>\r\n                                            <td>");
            EndContext();
            BeginContext(1805, 13, false);
#line 38 "C:\Users\User\Documents\Visual Studio 2019\Projects\TimeSheet Management\WebApplication1\Views\User\ShowTimeSheetViewOnly.cshtml"
                                           Write(item.TaskType);

#line default
#line hidden
            EndContext();
            BeginContext(1818, 55, true);
            WriteLiteral("</td>\r\n                                            <td>");
            EndContext();
            BeginContext(1874, 15, false);
#line 39 "C:\Users\User\Documents\Visual Studio 2019\Projects\TimeSheet Management\WebApplication1\Views\User\ShowTimeSheetViewOnly.cshtml"
                                           Write(item.HoursSpent);

#line default
#line hidden
            EndContext();
            BeginContext(1889, 55, true);
            WriteLiteral("</td>\r\n                                            <td>");
            EndContext();
            BeginContext(1945, 11, false);
#line 40 "C:\Users\User\Documents\Visual Studio 2019\Projects\TimeSheet Management\WebApplication1\Views\User\ShowTimeSheetViewOnly.cshtml"
                                           Write(item.Status);

#line default
#line hidden
            EndContext();
            BeginContext(1956, 56, true);
            WriteLiteral("</td>\r\n\r\n                                        </tr>\r\n");
            EndContext();
#line 43 "C:\Users\User\Documents\Visual Studio 2019\Projects\TimeSheet Management\WebApplication1\Views\User\ShowTimeSheetViewOnly.cshtml"
                                    }

#line default
#line hidden
            BeginContext(2051, 214, true);
            WriteLiteral("                                </tbody>\r\n                            </table>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TimeSheetManagement.ViewModels.DisplayTimeSheet>> Html { get; private set; }
    }
}
#pragma warning restore 1591