#pragma checksum "C:\Users\User\Documents\Visual Studio 2019\Projects\TimeSheet Management\WebApplication1\Views\User\Workspace.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4575b4651743121fef67ef125488ae92d9ae429e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Workspace), @"mvc.1.0.view", @"/Views/User/Workspace.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/Workspace.cshtml", typeof(AspNetCore.Views_User_Workspace))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4575b4651743121fef67ef125488ae92d9ae429e", @"/Views/User/Workspace.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Workspace : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TimeSheetManagement.ViewModels.WorkspaceListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\User\Documents\Visual Studio 2019\Projects\TimeSheet Management\WebApplication1\Views\User\Workspace.cshtml"
  
    ViewData["Title"] = "Workspace";
    Layout = "~/Views/Layouts/_PMLayout.cshtml";
    var XLabels = Newtonsoft.Json.JsonConvert.SerializeObject(Model.ProductivityList.Select(x => x.EmployeeName).ToList());
    var YValues = Newtonsoft.Json.JsonConvert.SerializeObject(Model.ProductivityList.Select(x => x.WorkingHours).ToList());

#line default
#line hidden
            BeginContext(407, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 12 "C:\Users\User\Documents\Visual Studio 2019\Projects\TimeSheet Management\WebApplication1\Views\User\Workspace.cshtml"
  
    ViewBag.Name = Model.WorkspaceName;
    ViewBag.WorkspaceId = Model.WorkspaceId;
    ViewBag.Username = Model.Username;


#line default
#line hidden
            BeginContext(726, 414, true);
            WriteLiteral(@"<div class=""col-xl-3 col-md-6 mb-4"">
    <div class=""card border-left-primary shadow h-100 py-2"">
        <div class=""card-body"">
            <div class=""row no-gutters align-items-center"">
                <div class=""col mr-2"">
                    <div class=""text-xs font-weight-bold text-primary text-uppercase mb-1"">Workspace</div>
                    <div class=""h5 mb-0 font-weight-bold text-gray-800"">");
            EndContext();
            BeginContext(1141, 12, false);
#line 24 "C:\Users\User\Documents\Visual Studio 2019\Projects\TimeSheet Management\WebApplication1\Views\User\Workspace.cshtml"
                                                                   Write(ViewBag.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1153, 647, true);
            WriteLiteral(@"</div>
                </div>
                <div class=""col-auto"">
                    <i class=""fas fa-project-diagram fa-2x text-gray-300""></i>
                </div>
            </div>
        </div>
    </div>
</div>

<div class=""col-xl-3 col-md-6 mb-4"">
    <div class=""card border-left-primary shadow h-100 py-2"">
        <div class=""card-body"">
            <div class=""row no-gutters align-items-center"">
                <div class=""col mr-2"">
                    <div class=""text-xs font-weight-bold text-primary text-uppercase mb-1"">Projects</div>
                    <div class=""h5 mb-0 font-weight-bold text-gray-800"">");
            EndContext();
            BeginContext(1801, 20, false);
#line 40 "C:\Users\User\Documents\Visual Studio 2019\Projects\TimeSheet Management\WebApplication1\Views\User\Workspace.cshtml"
                                                                   Write(ViewBag.ProjectCount);

#line default
#line hidden
            EndContext();
            BeginContext(1821, 646, true);
            WriteLiteral(@"</div>
                </div>
                <div class=""col-auto"">
                    <i class=""fas fa-project-diagram fa-2x text-gray-300""></i>
                </div>
            </div>
        </div>
    </div>
</div>
<div class=""col-xl-3 col-md-6 mb-4"">
    <div class=""card border-left-primary shadow h-100 py-2"">
        <div class=""card-body"">
            <div class=""row no-gutters align-items-center"">
                <div class=""col mr-2"">
                    <div class=""text-xs font-weight-bold text-primary text-uppercase mb-1"">Employees</div>
                    <div class=""h5 mb-0 font-weight-bold text-gray-800"">");
            EndContext();
            BeginContext(2468, 21, false);
#line 55 "C:\Users\User\Documents\Visual Studio 2019\Projects\TimeSheet Management\WebApplication1\Views\User\Workspace.cshtml"
                                                                   Write(ViewBag.EmployeeCount);

#line default
#line hidden
            EndContext();
            BeginContext(2489, 649, true);
            WriteLiteral(@"</div>
                </div>
                <div class=""col-auto"">
                    <i class=""fas fa-user-friends fa-2x text-gray-300""></i>
                </div>
            </div>
        </div>
    </div>
</div>
<div class=""col-xl-3 col-md-6 mb-4"">
    <div class=""card border-left-primary shadow h-100 py-2"">
        <div class=""card-body"">
            <div class=""row no-gutters align-items-center"">
                <div class=""col mr-2"">
                    <div class=""text-xs font-weight-bold text-primary text-uppercase mb-1"">Request Pending</div>
                    <div class=""h5 mb-0 font-weight-bold text-gray-800"">");
            EndContext();
            BeginContext(3139, 28, false);
#line 70 "C:\Users\User\Documents\Visual Studio 2019\Projects\TimeSheet Management\WebApplication1\Views\User\Workspace.cshtml"
                                                                   Write(ViewBag.EmployeeCountPending);

#line default
#line hidden
            EndContext();
            BeginContext(3167, 1050, true);
            WriteLiteral(@"</div>
                </div>
            </div>
        </div>
    </div>
</div>

<div class=""col-md-12"">
    <!-- Area Chart -->
    <div class="""">
        <div class=""card shadow mb-4 border-left-primary shadow h-100 py-2"">
            <!-- Card Header - Dropdown -->
            <div class=""card-header py-3 d-flex flex-row align-items-center justify-content-between"">
                <h6 class=""m-0 font-weight-bold text-primary"">Productivity Chart</h6>
            </div>
            <!-- Card Body -->
            <div class=""card-body"">
                <div class="""">

                    <div class=""chart-container"">
                        <canvas id=""chart"" style=""width:100%; height:500px""></canvas>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<script type=""text/javascript"">

        $(function () {
    var chartName = ""chart"";
        var ctx = document.getElementById(chartName).getContext('2d');
        var data = {");
            WriteLiteral("\r\n                labels: ");
            EndContext();
            BeginContext(4218, 17, false);
#line 103 "C:\Users\User\Documents\Visual Studio 2019\Projects\TimeSheet Management\WebApplication1\Views\User\Workspace.cshtml"
                   Write(Html.Raw(XLabels));

#line default
#line hidden
            EndContext();
            BeginContext(4235, 1418, true);
            WriteLiteral(@",
                datasets: [{
                    label: ""Working Hours"",
                    backgroundColor: [
                        'rgba(255, 99, 132, 0.2)',
                        'rgba(54, 162, 235, 0.2)',
                        'rgba(255, 206, 86, 0.2)',
                        'rgba(75, 192, 192, 0.2)',
                        'rgba(153, 102, 255, 0.2)',
                        'rgba(255, 159, 64, 0.2)',
                        'rgba(255, 0, 0)',
                        'rgba(0, 255, 0)',
                        'rgba(0, 0, 255)',
                        'rgba(192, 192, 192)',
                        'rgba(255, 255, 0)',
                        'rgba(255, 0, 255)'
                    ],
                    borderColor: [
                        'rgba(255,99,132,1)',
                        'rgba(54, 162, 235, 1)',
                        'rgba(255, 206, 86, 1)',
                        'rgba(75, 192, 192, 1)',
                        'rgba(153, 102, 255, 1)',
              ");
            WriteLiteral(@"          'rgba(255, 159, 64, 1)',
                        'rgba(255, 0, 0)',
                        'rgba(0, 255, 0)',
                        'rgba(0, 0, 255)',
                        'rgba(192, 192, 192)',
                        'rgba(255, 255, 0)',
                        'rgba(255, 0, 255)'
                    ],
                    borderWidth: 1,
                    data: ");
            EndContext();
            BeginContext(5654, 17, false);
#line 135 "C:\Users\User\Documents\Visual Studio 2019\Projects\TimeSheet Management\WebApplication1\Views\User\Workspace.cshtml"
                     Write(Html.Raw(YValues));

#line default
#line hidden
            EndContext();
            BeginContext(5671, 989, true);
            WriteLiteral(@"
    }]
            };

var options = {
                maintainAspectRatio: false,
                scales: {
                    yAxes: [{
                        ticks: {
                            min: 0,
                            beginAtZero: true
                        },
                        gridLines: {
                            display: true,
                            color: ""rgba(255,99,164,0.2)""
                        }
}],
                    xAxes: [{
                        ticks: {
                            min: 0,
                            beginAtZero: true
                        },
                        gridLines: {
                            display: false
                        }
                    }]
                }
            };

       var myChart = new  Chart(ctx, {
                options: options,
                data: data,
                type:'bar'

            });
        });
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TimeSheetManagement.ViewModels.WorkspaceListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
