#pragma checksum "C:\Users\User\Documents\Visual Studio 2019\Projects\TimeSheet Management\WebApplication1\Views\User\AcceptOrRejectTimesheet.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f3a582e3d787b5a9d8b2cf7c263ca69e039abbb1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_AcceptOrRejectTimesheet), @"mvc.1.0.view", @"/Views/User/AcceptOrRejectTimesheet.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/AcceptOrRejectTimesheet.cshtml", typeof(AspNetCore.Views_User_AcceptOrRejectTimesheet))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3a582e3d787b5a9d8b2cf7c263ca69e039abbb1", @"/Views/User/AcceptOrRejectTimesheet.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_User_AcceptOrRejectTimesheet : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TimeSheetManagement.ViewModels.AcceptOrRejectTimesheetViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString("return confirm(\'Are you sure you want to reject this timesheet?\');"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("float: right;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RejectTimesheet", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString("return confirm(\'Are you sure you want to accept this timesheet?\');"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("float:right;margin-right:5px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AcceptTimesheet", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
#line 2 "C:\Users\User\Documents\Visual Studio 2019\Projects\TimeSheet Management\WebApplication1\Views\User\AcceptOrRejectTimesheet.cshtml"
  
    ViewData["Title"] = "AcceptOrRejectTimesheet";
    Layout = "~/Views/Layouts/_PMLayout.cshtml";

#line default
#line hidden
            BeginContext(194, 35, true);
            WriteLiteral("\r\n\r\n\r\n    <div class=\"col-md-12\">\r\n");
            EndContext();
#line 10 "C:\Users\User\Documents\Visual Studio 2019\Projects\TimeSheet Management\WebApplication1\Views\User\AcceptOrRejectTimesheet.cshtml"
         using (Html.BeginForm("RejectTimesheet", "User", new { id = @ViewBag.IndividualId, id2 = @ViewBag.ProjectId }))
        {

#line default
#line hidden
            BeginContext(362, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(374, 236, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f3a582e3d787b5a9d8b2cf7c263ca69e039abbb17089", async() => {
                BeginContext(600, 6, true);
                WriteLiteral("Reject");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 12 "C:\Users\User\Documents\Visual Studio 2019\Projects\TimeSheet Management\WebApplication1\Views\User\AcceptOrRejectTimesheet.cshtml"
                                                                                                                                                                        WriteLiteral(ViewBag.IndividualId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 12 "C:\Users\User\Documents\Visual Studio 2019\Projects\TimeSheet Management\WebApplication1\Views\User\AcceptOrRejectTimesheet.cshtml"
                                                                                                                                                                                                              WriteLiteral(ViewBag.ProjectId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id2"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id2", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id2"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(610, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 13 "C:\Users\User\Documents\Visual Studio 2019\Projects\TimeSheet Management\WebApplication1\Views\User\AcceptOrRejectTimesheet.cshtml"
        }

#line default
#line hidden
            BeginContext(623, 8, true);
            WriteLiteral("        ");
            EndContext();
#line 14 "C:\Users\User\Documents\Visual Studio 2019\Projects\TimeSheet Management\WebApplication1\Views\User\AcceptOrRejectTimesheet.cshtml"
         using (Html.BeginForm("AcceptTimesheet", "User", new { id = @ViewBag.IndividualId, id2 = @ViewBag.ProjectId }))
         {

#line default
#line hidden
            BeginContext(757, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(769, 252, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f3a582e3d787b5a9d8b2cf7c263ca69e039abbb111459", async() => {
                BeginContext(1011, 6, true);
                WriteLiteral("Accept");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 16 "C:\Users\User\Documents\Visual Studio 2019\Projects\TimeSheet Management\WebApplication1\Views\User\AcceptOrRejectTimesheet.cshtml"
                                                                                                                                                                                        WriteLiteral(ViewBag.IndividualId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 16 "C:\Users\User\Documents\Visual Studio 2019\Projects\TimeSheet Management\WebApplication1\Views\User\AcceptOrRejectTimesheet.cshtml"
                                                                                                                                                                                                                              WriteLiteral(ViewBag.ProjectId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id2"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id2", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id2"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1021, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 17 "C:\Users\User\Documents\Visual Studio 2019\Projects\TimeSheet Management\WebApplication1\Views\User\AcceptOrRejectTimesheet.cshtml"
        }

#line default
#line hidden
            BeginContext(1034, 66, true);
            WriteLiteral("    </div>\r\n\r\n<div class=\"col-md-12\">\r\n    <p>Week Start Date: <b>");
            EndContext();
            BeginContext(1101, 21, false);
#line 21 "C:\Users\User\Documents\Visual Studio 2019\Projects\TimeSheet Management\WebApplication1\Views\User\AcceptOrRejectTimesheet.cshtml"
                      Write(ViewBag.WeekStartDate);

#line default
#line hidden
            EndContext();
            BeginContext(1122, 1307, true);
            WriteLiteral(@"</b></p>
    <div class="""">
        <div class=""card shadow mb-4 border-left-primary shadow h-100 py-2"">
            <!-- Card Header - Dropdown -->
            <div class=""card-header py-3 d-flex flex-row align-items-center justify-content-between"">
                <h6 class=""m-0 font-weight-bold text-primary"">Timesheet</h6>
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
                                    <th>Development</th>
                                    <th>Learning</th>
                                    <th>Meeting</th>
                                    <th>Marketing</th>
                             ");
            WriteLiteral(@"       <th>Documentation</th>
                                    <th>
                                        Total Hours
                                    </th>
                                </tr>
                            </thead>
                            <tbody>
");
            EndContext();
#line 49 "C:\Users\User\Documents\Visual Studio 2019\Projects\TimeSheet Management\WebApplication1\Views\User\AcceptOrRejectTimesheet.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
            BeginContext(2526, 132, true);
            WriteLiteral("                                    <tr>\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(2659, 48, false);
#line 53 "C:\Users\User\Documents\Visual Studio 2019\Projects\TimeSheet Management\WebApplication1\Views\User\AcceptOrRejectTimesheet.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.WeekStartDate));

#line default
#line hidden
            EndContext();
            BeginContext(2707, 139, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(2847, 51, false);
#line 56 "C:\Users\User\Documents\Visual Studio 2019\Projects\TimeSheet Management\WebApplication1\Views\User\AcceptOrRejectTimesheet.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.DevelopmentHours));

#line default
#line hidden
            EndContext();
            BeginContext(2898, 139, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(3038, 48, false);
#line 59 "C:\Users\User\Documents\Visual Studio 2019\Projects\TimeSheet Management\WebApplication1\Views\User\AcceptOrRejectTimesheet.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.LearningHours));

#line default
#line hidden
            EndContext();
            BeginContext(3086, 139, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(3226, 47, false);
#line 62 "C:\Users\User\Documents\Visual Studio 2019\Projects\TimeSheet Management\WebApplication1\Views\User\AcceptOrRejectTimesheet.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.MeetingHours));

#line default
#line hidden
            EndContext();
            BeginContext(3273, 139, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(3413, 49, false);
#line 65 "C:\Users\User\Documents\Visual Studio 2019\Projects\TimeSheet Management\WebApplication1\Views\User\AcceptOrRejectTimesheet.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.MarketingHours));

#line default
#line hidden
            EndContext();
            BeginContext(3462, 139, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(3602, 53, false);
#line 68 "C:\Users\User\Documents\Visual Studio 2019\Projects\TimeSheet Management\WebApplication1\Views\User\AcceptOrRejectTimesheet.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.DocumentationHours));

#line default
#line hidden
            EndContext();
            BeginContext(3655, 139, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(3795, 45, false);
#line 71 "C:\Users\User\Documents\Visual Studio 2019\Projects\TimeSheet Management\WebApplication1\Views\User\AcceptOrRejectTimesheet.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.TotalHours));

#line default
#line hidden
            EndContext();
            BeginContext(3840, 94, true);
            WriteLiteral("\r\n                                        </td>\r\n\r\n                                    </tr>\r\n");
            EndContext();
#line 75 "C:\Users\User\Documents\Visual Studio 2019\Projects\TimeSheet Management\WebApplication1\Views\User\AcceptOrRejectTimesheet.cshtml"
                                }

#line default
#line hidden
            BeginContext(3969, 178, true);
            WriteLiteral("                            </tbody>\r\n                        </table>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TimeSheetManagement.ViewModels.AcceptOrRejectTimesheetViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
