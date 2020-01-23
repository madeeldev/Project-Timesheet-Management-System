using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Routing;
using TimeSheetManagement.Models;
using TimeSheetManagement.ViewModels;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class UserController : Controller
    {
        private ApplicationDbContext _context;
        public UserController(ApplicationDbContext context)
        {
            _context = context;
        }
        //Partial View
        //SharedView

        //Admin Dashboard
        [Authorize(Roles = "Admin")]
        public string AdminDashboard()
        {
            return "Admin Login";
        }

        //Project Manager Profile
        [Authorize(Roles = "Project Manager")]
        public IActionResult ProjectMangerProfile(string id)
        {
            if(id == null)
            {
                return NotFound();
            }
            if(_context.ApplicationUsers.SingleOrDefault(x => x.Email == id) == null)
            {
                return NotFound();
            }
            var userid2 = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var workspace2 = _context.Workspaces.SingleOrDefault(x => x.PmId == userid2);
            ViewBag.Name = workspace2.Name;
            ViewBag.WorkspaceId = workspace2.WorkspaceId;
            var user = _context.ApplicationUsers.SingleOrDefault(x=>x.Email == id);
            var profile = new ProfileViewModel();
            profile.FullName = user.FirstName + ' ' + user.LastName;
            profile.Email = user.Email;
            return View(profile);
        }

        //Create workspace
        [Authorize(Roles = "Project Manager")]
        public IActionResult CreateWorkspace()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateWorkspace(WorkspaceViewModel model)
        {
            var userid = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (ModelState.IsValid)
            {
                if (_context.Workspaces.Any(x=>x.PmId == userid))
                {
                    var ws = _context.Workspaces.SingleOrDefault(x => x.PmId == userid);
                    ViewBag.Name = ws.Name;
                    ViewBag.WorkspaceId = ws.WorkspaceId;
                    ModelState.AddModelError("CustomError", "You have already defined Your Workspace");
                    return View(model);
                }

                var workspace = new WorkSpace();
                workspace.Name = model.Name;
                workspace.PmId = userid;
                workspace.DateCreated = DateTime.Now.Date;
                _context.Workspaces.Add(workspace);
                _context.SaveChanges();
                return RedirectToAction("Workspace");
            }

            var userid2 = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var workspace2 = _context.Workspaces.SingleOrDefault(x => x.PmId == userid2);
            ViewBag.Name = workspace2.Name;
            ViewBag.WorkspaceId = workspace2.WorkspaceId;
            return View(model);
        }

        [Authorize(Roles = "Project Manager")]
        //Workspace
        public IActionResult Workspace()
        {
            var userid = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var workspace = _context.Workspaces.SingleOrDefault(x => x.PmId == userid);
            var workspace_view_model = new WorkspaceListViewModel();
            var countProject = _context.Projects.Where(x => x.WorkspaceId == workspace.WorkspaceId).Count();
            ViewBag.ProjectCount = countProject;
            //count eemployee added
            var countEmployee = 0;
            var projects_list = _context.Projects.Where(x=>x.WorkspaceId == workspace.WorkspaceId).ToList();
            var project_assignment_list = _context.ProjectAssignment.Where(x => x.Status == "Accepted").ToList();
            foreach(var a in projects_list)
            {
                foreach(var b in project_assignment_list)
                {
                    if(a.ProjectId == b.ProjectId)
                    {
                        countEmployee += countEmployee + 1; 
                    }
                }
            }
            ViewBag.EmployeeCount = countEmployee;
            //count employee pending
            var countEmployeePending = 0;
            var project_assignment_list_pending = _context.ProjectAssignment.Where(x => x.Status == "Pending").ToList();
            foreach (var a in projects_list)
            {
                foreach (var b in project_assignment_list_pending)
                {
                    if (a.ProjectId == b.ProjectId)
                    {
                        countEmployeePending += countEmployeePending + 1;
                    }
                }
            }
            ViewBag.EmployeeCountPending = countEmployeePending;
            //Productiivty
            var project_list = _context.Projects.Where(x => x.WorkspaceId == workspace.WorkspaceId).ToList();
            var EmployeeIds = new List<EmployeeIdViewModel>();
            var DifferentEmployeeInTimesheet = _context.TimeSheets.GroupBy(t => t.EmployeeId).Select(g => g.First()).ToList();
            var productivityList = new List<ProductivityViewModel>();
            foreach (var a in DifferentEmployeeInTimesheet)
            {
                var countHours = 0;
                var productivity = new ProductivityViewModel();
                
                foreach (var project in project_list)
                {
                    var totalTimesheet = _context.TimeSheets.Where(x => x.Status == "Accepetd" && x.ProjectId == project.ProjectId).ToList();
                    for (var i = 0; i < totalTimesheet.Count(); i++)
                    {
                        if (a.EmployeeId == totalTimesheet[i].EmployeeId)
                        {
                            productivity.EmployeeName = _context.ApplicationUsers.SingleOrDefault(x => x.Id == a.EmployeeId).UserName;
                            countHours += totalTimesheet[i].HoursSpent;
                        }
                    }
                }
                productivity.WorkingHours = countHours;
                productivityList.Add(productivity);

            }
            
            //
            if (workspace != null)
            {
                workspace_view_model.WorkspaceName = workspace.Name;
                workspace_view_model.Username = _context.ApplicationUsers.SingleOrDefault(x => x.Id == userid).UserName;
                workspace_view_model.DateCreated = workspace.DateCreated.Date;
                workspace_view_model.WorkspaceId = workspace.WorkspaceId;
                //AddProductivityListInModel
                var productivity_list = new List<ProductivityViewModel>();
                foreach(var a in productivityList)
                {
                    if (a.WorkingHours != 0 && a.EmployeeName != null)
                    {
                        productivity_list.Add(a);
                    }
                }
                workspace_view_model.ProductivityList = productivity_list;
            }
            return View(workspace_view_model);
        }

        [Authorize(Roles = "Project Manager")]
        //Create Project/WorkspaceId
        public IActionResult CreateProject(int id)
        {
            var userid = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var workspace = _context.Workspaces.SingleOrDefault(x => x.PmId == userid);
            ProjectViewModel model = new ProjectViewModel();
            var shareddata = new SharedData();
            shareddata.WorkspaceName = workspace.Name;
            shareddata.WorkspaceId = workspace.WorkspaceId;
            model.SharedData = shareddata;
            return View(model);
        }

        [HttpPost]
        public IActionResult CreateProject(ProjectViewModel model, int id)
        {
            var userid = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var workspace = _context.Workspaces.SingleOrDefault(x => x.PmId == userid && x.WorkspaceId == id);

            if (ModelState.IsValid)
            {
                var project = new Project();
                project.Name = model.Name;
                project.Description = model.Description;
                project.DateCreated = DateTime.Now.Date;
                project.WorkspaceId = workspace.WorkspaceId;

                _context.Projects.Add(project);
                _context.SaveChanges();
                return RedirectToAction("Projects", new { Id = id });
            }
            ViewBag.Name = workspace.Name;
            ViewBag.WorkspaceId = workspace.WorkspaceId;
            return View(model);
        }

        [Authorize(Roles = "Project Manager")]
        //Projects/WorkspaceId
        public IActionResult Projects(string searchString, int id)
        {
            var userid = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var workspace = _context.Workspaces.SingleOrDefault(x => x.PmId == userid);
            
            List<Project> ProjectList = new List<Project>();
            if (!string.IsNullOrEmpty(searchString))
            {
                var b = _context.Projects.Where(s => s.Name.Contains(searchString));
                foreach (var a in b)
                {
                    if (a.WorkspaceId == workspace.WorkspaceId)
                    {
                        ProjectList.Add(a);
                    }
                }
            }
            else
            {
                foreach (var a in _context.Projects.ToList())
                {
                    if (a.WorkspaceId == workspace.WorkspaceId)
                    {
                        ProjectList.Add(a);
                    }
                }
            }
            var project_list = new ProjectListViewModel
            {
                ProjectsList = ProjectList
            };
            ViewBag.Name = workspace.Name;
            ViewBag.WorkspaceId = workspace.WorkspaceId;
            return View(project_list);
        }

        //Add Project Members
        public IActionResult AddProjectMember(int id)
        {
            var userid = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var workspace = _context.Workspaces.SingleOrDefault(x => x.PmId == userid);
            ViewBag.Name = workspace.Name;
            ViewBag.WorkspaceId = workspace.WorkspaceId;

            ViewBag.ProjectId = id;
            return View();
        }

        [HttpPost]
        public IActionResult AddProjectMember(int id, ProjectAssignmentViewModel model)
        {
            if (ModelState.IsValid)
            {
                var project = _context.Projects.SingleOrDefault(x => x.ProjectId == id);
                if (_context.ApplicationUsers.SingleOrDefault(x => x.Email == model.SearchEmail) == null)
                {
                    var userid = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                    var workspace = _context.Workspaces.SingleOrDefault(x => x.PmId == userid);
                    ViewBag.Name = workspace.Name;
                    ViewBag.WorkspaceId = workspace.WorkspaceId;
                    ModelState.AddModelError("CustomError", "User with this email does not exist");
                    return View(model);
                }
                var individual = _context.ApplicationUsers.SingleOrDefault(x => x.Email == model.SearchEmail);
                if(_context.ProjectAssignment.Any(x=>x.ProjectId == project.ProjectId && x.EmployeeId == individual.Id))
                {
                    var userid = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                    var workspace = _context.Workspaces.SingleOrDefault(x => x.PmId == userid);
                    ViewBag.Name = workspace.Name;
                    ViewBag.WorkspaceId = workspace.WorkspaceId;
                    ModelState.AddModelError("CustomError", "User with this email is already member of this project");
                    return View(model);
                }
                //Check if user is ProjectManager
                var employee = _context.ApplicationUsers.SingleOrDefault(x=>x.Email == model.SearchEmail);
                var roleId = _context.UserRoles.SingleOrDefault(x=>x.UserId == employee.Id).RoleId;
                var role = _context.Roles.SingleOrDefault(x=>x.Id == roleId).Name;
                if(role != "Individual")
                {
                    var userid = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                    var workspace = _context.Workspaces.SingleOrDefault(x => x.PmId == userid);
                    ViewBag.Name = workspace.Name;
                    ViewBag.WorkspaceId = workspace.WorkspaceId;
                    ModelState.AddModelError("CustomError", "User with this email does not exist");
                    return View(model);
                }
                if (individual != null && project != null)
                {
                    var Project_Assignment = new ProjectAssignment();
                    Project_Assignment.EmployeeId = individual.Id;
                    Project_Assignment.ProjectId = project.ProjectId;
                    Project_Assignment.Status = "Pending";
                    _context.ProjectAssignment.Add(Project_Assignment);
                    _context.SaveChanges();
                    return RedirectToAction("ProjectMembers", new { Id = id });
                }
                else
                {

                }
            }
            var userid2 = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var workspace2 = _context.Workspaces.SingleOrDefault(x => x.PmId == userid2);
            ViewBag.Name = workspace2.Name;
            ViewBag.WorkspaceId = workspace2.WorkspaceId;
            return View(model);
        }

        //Members List
        public IActionResult ProjectMembers(int id)
        {
            var project = _context.Projects.SingleOrDefault(x => x.ProjectId == id);
            var project_members = _context.ProjectAssignment.Where(x => x.ProjectId == id).ToList();

            var userid = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var workspace = _context.Workspaces.SingleOrDefault(x => x.PmId == userid);
            ViewBag.Name = workspace.Name;
            ViewBag.WorkspaceId = workspace.WorkspaceId;

            var project_members_viewmodel_list = new List<MembersList>();
            if (project_members != null && project != null)
            {
                foreach (var a in project_members)
                {
                    var project_members_viewmodel = new MembersList();
                    project_members_viewmodel.MemberEmail = _context.ApplicationUsers.SingleOrDefault(x => x.Id == a.EmployeeId).Email;
                    project_members_viewmodel.ProjectAssignmentId = a.ProjectAssignmentId;
                    project_members_viewmodel.IndividualUserId = a.EmployeeId;
                    project_members_viewmodel.ProjectId = a.ProjectId;
                    project_members_viewmodel_list.Add(project_members_viewmodel);
                }
            }
            return View(project_members_viewmodel_list);
        }

        //RemoveProjectMember/ProjectAssignmentId
        public IActionResult RemoveProjectMember(int id)
        {
            var project_assigned = _context.ProjectAssignment.SingleOrDefault(x => x.ProjectAssignmentId == id);
            if (project_assigned != null)
            {
                _context.ProjectAssignment.Remove(project_assigned);
                _context.SaveChanges();
                return RedirectToAction("ProjectMembers", new { Id = id });
            }
            return RedirectToAction("ProjectMembers", new { Id = id });
        }

        //Create Task for Workspace
        //CreateTask/WorkspaceId
        public IActionResult CreateTask(int id)
        {
            ViewBag.WorkspaceId = id;
            ViewBag.Name = _context.Workspaces.SingleOrDefault(x => x.WorkspaceId == id).Name;
            return View();
        }

        [HttpPost]
        public IActionResult CreateTask(int id, CreateTaskViewModel model)
        {

            if (ModelState.IsValid)
            {
                var userid = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                var workspace = _context.Workspaces.SingleOrDefault(x => x.WorkspaceId == id && x.PmId == userid);
                if (workspace != null)
                {
                    if(_context.Tasks.Any(x=>x.TaskName == model.TaskName))
                    {
                        ViewBag.Name = workspace.Name;
                        ViewBag.WorkspaceId = workspace.WorkspaceId;
                        ModelState.AddModelError("CustomError", "Task with this name already exist.");
                        return View(model);
                    }
                }
                if (workspace != null)
                {
                    TimeSheetManagement.Models.Task task = new TimeSheetManagement.Models.Task();
                    task.TaskName = model.TaskName;
                    task.WorkspaceId = workspace.WorkspaceId;
                    _context.Tasks.Add(task);
                    _context.SaveChanges();
                    return RedirectToAction("WorkspaceTasks", new { Id = id });
                }
            }
            var userid2 = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var workspace2 = _context.Workspaces.SingleOrDefault(x => x.PmId == userid2);
            ViewBag.Name = workspace2.Name;
            ViewBag.WorkspaceId = workspace2.WorkspaceId;
            return View(model);
        }

        //Workspace Tasks/WorkspaceId
        public IActionResult WorkspaceTasks(int id)
        {
            ViewBag.WorkspaceId = id;
            ViewBag.Name = _context.Workspaces.SingleOrDefault(x => x.WorkspaceId == id).Name;
            var userid = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var workspace = _context.Workspaces.SingleOrDefault(x => x.WorkspaceId == id && x.PmId == userid);
            var task_list = new List<TaskListViewModel>();
            if (workspace != null)
            {
                var tasklist = _context.Tasks.Where(x => x.WorkspaceId == workspace.WorkspaceId).ToList();
                foreach (var a in tasklist)
                {
                    var t = new TaskListViewModel();
                    t.Name = a.TaskName;
                    task_list.Add(t);
                }
            }
            return View(task_list);
        }

        //WeekSetting/WorkspaceId
        public IActionResult CreateWeekSetting(int id)
        {
            ViewBag.WorkspaceId = id;
            ViewBag.Name = _context.Workspaces.SingleOrDefault(x => x.WorkspaceId == id).Name;
            return View();
        }

        [HttpPost]
        public IActionResult CreateWeekSetting(int id, CreateWeekSettingViewModel model)
        {
            var userid = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var workspace = _context.Workspaces.SingleOrDefault(x => x.PmId == userid);
            if (ModelState.IsValid)
            {
                if (workspace != null)
                {
                    if (_context.WeekSettings.Where(x => x.WorkspaceId == id).Any())
                    {
                        ViewBag.Name = workspace.Name;
                        ViewBag.WorkspaceId = workspace.WorkspaceId;
                        ModelState.AddModelError("CustomError", "You have already defined Week Settings.");
                        return View(model);
                    }
                    else
                    {
                        var weekSetting = new WeekSetting();
                        weekSetting.WorkspaceId = id;
                        weekSetting.StartDate = model.StartDate;
                        weekSetting.StartDay = model.StartDay.ToString();
                        weekSetting.EndDay = model.EndDay.ToString();
                        _context.WeekSettings.Add(weekSetting);
                        _context.SaveChanges();
                        return RedirectToAction("WeekSetting", new { Id = id });
                    }

                }
            }
            ViewBag.Name = workspace.Name;
            ViewBag.WorkspaceId = workspace.WorkspaceId;
            return View(model);
        }

        //Week Setting/WorkspaceId
        public IActionResult WeekSetting(int id)
        {
            var userid = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var workspace = _context.Workspaces.SingleOrDefault(x => x.WorkspaceId == id && x.PmId == userid);
            ViewBag.WorkspaceId = workspace.WorkspaceId;
            ViewBag.Name = workspace.Name;
            var showWeekSetting = new ShowWeekSetting();
            if (workspace != null)
            {
                var weekSetting = _context.WeekSettings.SingleOrDefault(x => x.WorkspaceId == id);
                if (weekSetting != null)
                {
                    showWeekSetting.WeekSettingId = weekSetting.WeekSettingId;
                    showWeekSetting.StartDate = weekSetting.StartDate;
                    showWeekSetting.StartDay = weekSetting.StartDay;
                    showWeekSetting.EndDay = weekSetting.EndDay;
                }
            }
            return View(showWeekSetting);
        }

        //EditWeekSetting/WeekSettingId
        public IActionResult EditWeekSetting(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var weekSetting = _context.WeekSettings.SingleOrDefault(x => x.WeekSettingId == id);
            if (weekSetting == null)
            {
                return NotFound();
            }
            var userid = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var workspace = _context.Workspaces.SingleOrDefault(x=>x.PmId == userid);
            ViewBag.WorkspaceId = workspace.WorkspaceId;
            ViewBag.Name = workspace.Name;
            var week_setting = new EditWeekSetting();
            week_setting.StartDate = weekSetting.StartDate;
            week_setting.StartDay = weekSetting.StartDay;
            week_setting.EndDay = weekSetting.EndDay;
            return View(week_setting);
        }

        [HttpPost]
        public IActionResult EditWeekSetting(int id, EditWeekSetting model)
        {
            if (id == 0)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                var weekSetting = _context.WeekSettings.SingleOrDefault(x => x.WeekSettingId == id);
                weekSetting.StartDate = model.StartDate;
                weekSetting.StartDay = model.StartDay;
                weekSetting.EndDay = model.EndDay;
                _context.Update(weekSetting);
                _context.SaveChanges();
                return RedirectToAction("WeekSetting", new { Id = _context.WeekSettings.SingleOrDefault(x => x.WeekSettingId == id).WorkspaceId });
            }
            var userid2 = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var workspace2 = _context.Workspaces.SingleOrDefault(x => x.PmId == userid2);
            ViewBag.Name = workspace2.Name;
            ViewBag.WorkspaceId = workspace2.WorkspaceId;
            return View(model);
        }

        //Delete Setting/WeekSettingId
        public IActionResult DeleteSetting(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var weekSetting = _context.WeekSettings.SingleOrDefault(x => x.WeekSettingId == id);
            if (weekSetting == null)
            {
                return NotFound();
            }
            var userid = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var workspace = _context.Workspaces.SingleOrDefault(x => x.PmId == userid);
            ViewBag.WorkspaceId = workspace.WorkspaceId;
            ViewBag.Name = workspace.Name;
            return View(weekSetting);
        }

        public IActionResult DeleteSettingConfirmed(int id)
        {
            var weekSetting = _context.WeekSettings.SingleOrDefault(x => x.WeekSettingId == id);
            _context.WeekSettings.Remove(weekSetting);
            _context.SaveChanges();
            return RedirectToAction("Workspace");
        }
        //Individual Dashboard
        [Authorize(Roles = "Individual")]
        public IActionResult IndividualDashboard()
        {
            var userid = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            
            var total_invitation_requests = _context.ProjectAssignment.Where(x => x.Status == "Pending").ToList();
            List<InvitationRequestsViewModel> user_invitations = new List<InvitationRequestsViewModel>();
            foreach (var a in total_invitation_requests)
            {
                var u_invitation = new InvitationRequestsViewModel();
                if (a.EmployeeId == userid)
                {
                    u_invitation.ProjectName = _context.Projects.SingleOrDefault(x => x.ProjectId == a.ProjectId).Name;
                    u_invitation.ProjectDescription = _context.Projects.SingleOrDefault(x => x.ProjectId == a.ProjectId).Description;
                    u_invitation.InvitationId = a.ProjectAssignmentId;
                    u_invitation.Status = a.Status;
                    user_invitations.Add(u_invitation);
                }
            }
            return View(user_invitations);
        }

        //Accept Invitations/InvitationId
        [Authorize(Roles = "Individual")]
        public IActionResult AcceptInvitation(int id)
        {
            var project_assignment = _context.ProjectAssignment.SingleOrDefault(x => x.ProjectAssignmentId == id);
            if (project_assignment != null)
            {
                project_assignment.Status = "Accepted";
                _context.ProjectAssignment.Update(project_assignment);
                _context.SaveChanges();
                return RedirectToAction("IndividualDashboard");
            }
            else
            {
                return NotFound();
            }
        }

        [Authorize(Roles = "Individual")]
        //Active Requests To show Fill Daily Timesheet
        //DailyTimesheets
        public IActionResult DailyTimesheets()
        {
            var userid = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var total_accepted_invitation = _context.ProjectAssignment.Where(x => x.Status == "Accepted").ToList();
            List<DailyTimesheetViewModel> daily_timesheets = new List<DailyTimesheetViewModel>();
            foreach (var a in total_accepted_invitation)
            {
                var dailyTimesheet = new DailyTimesheetViewModel();
                if (a.EmployeeId == userid)
                {
                    dailyTimesheet.ProjectName = _context.Projects.SingleOrDefault(x => x.ProjectId == a.ProjectId).Name;
                    dailyTimesheet.ProjectDescription = _context.Projects.SingleOrDefault(x => x.ProjectId == a.ProjectId).Description;
                    dailyTimesheet.ProjectId = _context.Projects.SingleOrDefault(x => x.ProjectId == a.ProjectId).ProjectId;
                    daily_timesheets.Add(dailyTimesheet);
                }
            }
            return View(daily_timesheets);
        }

        [Authorize(Roles = "Individual")]
        //FillTimesheet/ProjectId
        public IActionResult FillTimeSheet(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            if (_context.Projects.SingleOrDefault(x => x.ProjectId == id) == null)
            {
                return NotFound();
            }
            var project = _context.Projects.SingleOrDefault(x => x.ProjectId == id);
            if (_context.WeekSettings.SingleOrDefault(x => x.WorkspaceId == project.WorkspaceId) == null)
            {
                return RedirectToAction("AccessDenie");
            }
            else
            {
                var workspace = _context.Workspaces.SingleOrDefault(y => y.WorkspaceId == project.WorkspaceId);
                var taskList = _context.Tasks.Where(z => z.WorkspaceId == workspace.WorkspaceId).ToList();
                var listItems = new List<SelectListItem>();
                foreach (var a in taskList)
                {
                    listItems.Add(new SelectListItem { Text = a.TaskName, Value = a.TaskName });
                }
                ViewBag.TaskList = listItems;
                return View();
            }
        }

        [HttpPost]
        public IActionResult FillTimeSheet(int id, CreateTimesheetViewModel model)
        {
            var p = _context.Projects.SingleOrDefault(x => x.ProjectId == id);
            if (_context.WeekSettings.SingleOrDefault(x => x.WorkspaceId == p.WorkspaceId) == null)
            {
                return RedirectToAction("AccessDenie");
            }
            else{
                if (ModelState.IsValid)
                {
                    var project = _context.Projects.SingleOrDefault(x => x.ProjectId == id);
                    if (project != null)
                    {
                        var userid = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                        var timeSheet = new TimeSheet();
                        timeSheet.Date = model.Date.Date;
                        timeSheet.Task = model.Task;
                        timeSheet.TaskType = model.TaskType;
                        timeSheet.HoursSpent = model.HoursSpent;
                        timeSheet.Status = "Saved";
                        timeSheet.EmployeeId = userid;
                        timeSheet.ProjectId = id;
                        _context.TimeSheets.Add(timeSheet);
                        _context.SaveChanges();
                        return RedirectToAction("ShowTimeSheet", new { Id = id });
                    }
                }
                var userid2 = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                var workspace2 = _context.Workspaces.SingleOrDefault(x => x.PmId == userid2);
                ViewBag.Name = workspace2.Name;
                ViewBag.WorkspaceId = workspace2.WorkspaceId;
                return View(model);
            }
        }

        [Authorize(Roles = "Individual")]
        //DisplayTimesheet/ProjectId
        public IActionResult ShowTimeSheet(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var project = _context.Projects.SingleOrDefault(x => x.ProjectId == id);
            var pmId = _context.Workspaces.SingleOrDefault(x => x.WorkspaceId == project.WorkspaceId).PmId;
            //ProjectManagerId
            //Check if its EndDay of week
            //If it is than send this id
            if(_context.WeekSettings.SingleOrDefault(x => x.WorkspaceId == project.WorkspaceId) == null)
            {
                return RedirectToAction("AccessDenie");
            }
            var startDate = _context.WeekSettings.SingleOrDefault(x => x.WorkspaceId == project.WorkspaceId).StartDate;
            var startDay = _context.WeekSettings.SingleOrDefault(x => x.WorkspaceId == project.WorkspaceId).StartDay;
            var endDay = _context.WeekSettings.SingleOrDefault(x => x.WorkspaceId == project.WorkspaceId).EndDay;
            var DateNow = DateTime.Now;
            if (DateNow.DayOfWeek.ToString() == endDay)
            {
                ViewBag.ProjectManagerId = pmId;
                ViewBag.projectId = id;
            }

            if (project == null)
            {
                return NotFound();
            }
            var listOftimeSheet = _context.TimeSheets.Where(x => x.ProjectId == id).ToList();
            var listOfDisplayTimeSheet = new List<DisplayTimeSheet>();
            var userid = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            foreach (var a in listOftimeSheet)
            {
                if (a.EmployeeId == userid && (a.Status == "Saved" || a.Status == "Rejected"))
                {
                    var displayTimesheet = new DisplayTimeSheet();
                    displayTimesheet.Date = a.Date;
                    displayTimesheet.Task = a.Task;
                    displayTimesheet.TaskType = a.TaskType;
                    displayTimesheet.HoursSpent = a.HoursSpent;
                    displayTimesheet.TimeSheetId = a.TimeSheetId;
                    displayTimesheet.Status = a.Status;
                    listOfDisplayTimeSheet.Add(displayTimesheet);
                }
            }
            return View(listOfDisplayTimeSheet);
        }


        [Authorize(Roles = "Individual")]
        //DisplayTimesheetViewOnly/ProjectId
        public IActionResult ShowTimeSheetViewOnly(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var project = _context.Projects.SingleOrDefault(x => x.ProjectId == id);

            if (project == null)
            {
                return NotFound();
            }
            var listOftimeSheet = _context.TimeSheets.Where(x => x.ProjectId == id).ToList();
            var listOfDisplayTimeSheet = new List<DisplayTimeSheet>();
            var userid = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            foreach (var a in listOftimeSheet)
            {
                if (a.EmployeeId == userid && (a.Status == "Submitted" || a.Status == "Rejected"))
                {
                    var displayTimesheet = new DisplayTimeSheet();
                    displayTimesheet.Date = a.Date;
                    displayTimesheet.Task = a.Task;
                    displayTimesheet.TaskType = a.TaskType;
                    displayTimesheet.HoursSpent = a.HoursSpent;
                    //displayTimesheet.TimeSheetId = a.TimeSheetId;
                    displayTimesheet.Status = a.Status;
                    listOfDisplayTimeSheet.Add(displayTimesheet);
                }
            }
            return View(listOfDisplayTimeSheet);
        }

        [Authorize(Roles = "Individual")]
        //EditTimeSheet/TimesheetId
        public IActionResult EditTimeSheet(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var userid = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var timeSheet = _context.TimeSheets.SingleOrDefault(x => x.TimeSheetId == id && x.EmployeeId == userid);
            if (timeSheet == null)
            {
                return NotFound();
            }
            var editTimeSheet = new EditTimeSheetViewModel();
            editTimeSheet.Date = timeSheet.Date;
            editTimeSheet.Task = timeSheet.Task;
            editTimeSheet.TaskType = timeSheet.TaskType;
            editTimeSheet.HoursSpent = timeSheet.HoursSpent;
            return View(editTimeSheet);
        }

        [HttpPost]
        public IActionResult EditTimeSheet(int id, EditTimeSheetViewModel model)
        {
            var userid = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var timeSheet = _context.TimeSheets.SingleOrDefault(x => x.TimeSheetId == id && x.EmployeeId == userid);
            timeSheet.Date = model.Date;
            timeSheet.Task = model.Task;
            timeSheet.TaskType = model.TaskType;
            timeSheet.HoursSpent = model.HoursSpent;
            _context.TimeSheets.Update(timeSheet);
            _context.SaveChanges();
            return RedirectToAction("ShowTimeSheet", new { Id = _context.TimeSheets.SingleOrDefault(x => x.TimeSheetId == id).ProjectId });
        }

        [Authorize(Roles = "Individual")]
        //Submit Timesheet To Manager
        //SubmitTimesheetToManager/ManagerId/ProjectId

        [HttpPost]
        public IActionResult SubmitTimesheetToManager(string id, int id2)
        {
            if (_context.ApplicationUsers.SingleOrDefault(x => x.Id == id) == null)
            {
                return NotFound();
            }
            if (_context.Projects.SingleOrDefault(x => x.ProjectId == id2) == null)
            {
                return NotFound();
            }
            var userid = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var totalTimeSheets = _context.TimeSheets.Where(x => x.EmployeeId == userid && x.ProjectId == id2).ToList();
            foreach (var a in totalTimeSheets)
            {
                if (a.Status == "Saved")
                {
                    var timeSheet = _context.TimeSheets.SingleOrDefault(x => x.TimeSheetId == a.TimeSheetId);
                    timeSheet.Status = "Submitted";
                    _context.SaveChanges();
                }
            }
            return RedirectToAction("ShowTimeSheet", new { Id = id2 });
        }


        [Authorize(Roles = "Project Manager")]
        //Accept or Reject Timesheet
        //AcceptOrRejectTimesheet/IndividualId/ProjectId
        public IActionResult AcceptOrRejectTimesheet(string id, int id2)
        {
            var userid = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var workspace = _context.Workspaces.SingleOrDefault(x => x.PmId == userid);
            ViewBag.WorkspaceId = workspace.WorkspaceId;
            ViewBag.Name = workspace.Name;
            var totalTimesheets = _context.TimeSheets.Where(x => x.EmployeeId == id && x.ProjectId == id2 && x.Status == "Submitted").ToList();
            //accept or reject method
            ViewBag.ProjectId = id2;
            ViewBag.IndividualId = id;

            var list = new List<AcceptOrRejectTimesheetViewModel>();
            foreach (var a in totalTimesheets)
            {
                var timesheet = new AcceptOrRejectTimesheetViewModel();
                timesheet.WeekStartDate = a.Date;
                timesheet.TotalHours = a.HoursSpent;
                if (a.TaskType == "Development")
                {
                    timesheet.DevelopmentHours = a.HoursSpent;
                }
                if (a.TaskType == "Learning")
                {
                    timesheet.LearningHours = a.HoursSpent;
                }
                if (a.TaskType == "Meeting")
                {
                    timesheet.MeetingHours = a.HoursSpent;
                }
                if (a.TaskType == "Marketing")
                {
                    timesheet.MarketingHours = a.HoursSpent;
                }
                if (a.TaskType == "Documentation")
                {
                    timesheet.DocumentationHours = a.HoursSpent;
                }
                list.Add(timesheet);
            }
            if (list.Count > 0)
            {
                ViewBag.WeekStartDate = list[0].WeekStartDate.Date;
            }


            return View(list);
        }

        [Authorize(Roles = "Project Manager")]
        //AcceptTimesheet/IndividualId/ProjectId


        public IActionResult AcceptTimesheet(string id, int id2)
        {
            if (id == null)
            {
                return NotFound();
            }
            if (id2 == 0)
            {
                return NotFound();
            }
            var userid = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var workspace = _context.Workspaces.SingleOrDefault(x => x.PmId == userid);
            ViewBag.WorkspaceId = workspace.WorkspaceId;
            ViewBag.Name = workspace.Name;
            var totalTimeSheets = _context.TimeSheets.Where(x => x.ProjectId == id2 && x.EmployeeId == id).ToList();
            foreach (var a in totalTimeSheets)
            {
                if (a.Status == "Submitted")
                {
                    var timeSheet = _context.TimeSheets.SingleOrDefault(x => x.TimeSheetId == a.TimeSheetId);
                    timeSheet.Status = "Accepetd";
                    _context.SaveChanges();
                }
            }
            return RedirectToAction("AcceptOrRejectTimesheet", new { id = id, id2 = id2 });
        }

        [Authorize(Roles = "Project Manager")]
        //RejectTimesheet/IndividualId/ProjectId

        public IActionResult RejectTimesheet(string id, int id2)
        {
            if (id == null)
            {
                return NotFound();
            }
            if (id2 == 0)
            {
                return NotFound();
            }
            var userid = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var workspace = _context.Workspaces.SingleOrDefault(x => x.PmId == userid);
            ViewBag.WorkspaceId = workspace.WorkspaceId;
            ViewBag.Name = workspace.Name;
            var totalTimeSheets = _context.TimeSheets.Where(x => x.ProjectId == id2 && x.EmployeeId == id).ToList();
            foreach (var a in totalTimeSheets)
            {
                if (a.Status == "Submitted")
                {
                    var timeSheet = _context.TimeSheets.SingleOrDefault(x => x.TimeSheetId == a.TimeSheetId);
                    timeSheet.Status = "Rejected";
                    _context.SaveChanges();
                }
            }
            return RedirectToAction("AcceptOrRejectTimesheet", new { id = id, id2 = id2 });
        }

        [Authorize(Roles = "Individual")]
        //RequestToChangeProject/ProjectId
        public IActionResult RequestToChangeProject(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var userid = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (_context.ChangeProjectRequests.Any(x=>x.ProjectId == id && x.IndividualId == userid))
            {
                //don't do this;
                return RedirectToAction("ChangeProjectRequests");
            }
            else
            {
                if(_context.ProjectAssignment.SingleOrDefault(x=>x.EmployeeId == userid && x.ProjectId == id) == null)
                {
                    return NotFound();
                }
                else
                {
                    var requestToChangeProject = new ChangeProjectRequests();
                    requestToChangeProject.ProjectId = id;
                    requestToChangeProject.IndividualId = userid;
                    requestToChangeProject.Status = "Request Sent";
                    _context.ChangeProjectRequests.Add(requestToChangeProject);
                    _context.SaveChanges();
                    return RedirectToAction("ChangeProjectRequests");
                }
            }    
        }

        //For Individual
        [Authorize(Roles = "Individual")]
        public IActionResult ChangeProjectRequests()
        {
            var totalRequests = _context.ChangeProjectRequests.ToList();
            var requestList = new List<RequestsListViewModel>();
            var userid = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            foreach (var a in totalRequests)
            {
                if(a.IndividualId == userid)
                {
                    var request = new RequestsListViewModel();
                    request.ProjectName = _context.Projects.SingleOrDefault(x => x.ProjectId == a.ProjectId).Name;
                    request.ProjectDescription = _context.Projects.SingleOrDefault(x => x.ProjectId == a.ProjectId).Description;
                    request.Status = _context.ChangeProjectRequests.SingleOrDefault(x => x.ChangeProjectRequestId == a.ChangeProjectRequestId).Status;
                    requestList.Add(request);
                }
            }
            return View(requestList);
        }

        [Authorize(Roles = "Project Manager")]
        //ChangeProjectRequest/For Project Manager
        public IActionResult ChangeProjectRequestsPm()
        {
            var totalRequests = _context.ChangeProjectRequests.ToList();
            var requestList = new List<RequestsListViewModel>();
            var userid = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var workspace = _context.Workspaces.SingleOrDefault(x=>x.PmId == userid);
            ViewBag.WorkspaceId = workspace.WorkspaceId;
            ViewBag.Name = workspace.Name;
            foreach (var a in totalRequests)
            {
                if (_context.Workspaces.SingleOrDefault(x=>x.WorkspaceId == 
                                _context.Projects.SingleOrDefault(y=>y.ProjectId == a.ProjectId).WorkspaceId).PmId == userid)
                {
                    if (a.Status == "Request Sent")
                    {
                        var request = new RequestsListViewModel();
                        request.ProjectName = _context.Projects.SingleOrDefault(x => x.ProjectId == a.ProjectId).Name;
                        request.ProjectDescription = _context.Projects.SingleOrDefault(x => x.ProjectId == a.ProjectId).Description;
                        request.Status = "Incomming Request";
                        request.Member = _context.ApplicationUsers.SingleOrDefault(x => x.Id == a.IndividualId).Email;
                        request.ProjectId = a.ProjectId;
                        request.RequestId = a.ChangeProjectRequestId;
                        ViewBag.CanChange = true;
                        requestList.Add(request);
                    }
                    else if (a.Status == "Accepted")
                    {
                        var request = new RequestsListViewModel();
                        request.ProjectName = _context.Projects.SingleOrDefault(x => x.ProjectId == a.ProjectId).Name;
                        request.ProjectDescription = _context.Projects.SingleOrDefault(x => x.ProjectId == a.ProjectId).Description;
                        request.Status = "Accepted";
                        request.Member = _context.ApplicationUsers.SingleOrDefault(x => x.Id == a.IndividualId).Email;
                        ViewBag.CanChange = false;
                        requestList.Add(request);
                    }
                }
            }
            return View(requestList);
        }

        [Authorize(Roles = "Project Manager")]
        //View The Productivity of Employees
        //ProductivityOfEmployee/ProjectId
        public IActionResult ProductivityOfEmployee(int id, ProductivityViewModel model)
        {
            var userid = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var workspace = _context.Workspaces.SingleOrDefault(x => x.PmId == userid);
            ViewBag.WorkspaceId = workspace.WorkspaceId;
            ViewBag.Name = workspace.Name;
            var totalTimesheet = _context.TimeSheets.Where(x=>x.Status == "Accepetd" && x.ProjectId == id).ToList();
            var productivityList = new List<ProductivityViewModel>();
            //get timesheets with different ids
            var listOfDifferentIds = _context.TimeSheets.Where(x=>x.ProjectId == id).GroupBy(t => t.EmployeeId).Select(g => g.First()).ToList();
            foreach (var a in listOfDifferentIds)
            {
                var countHours = 0;
                var productivity = new ProductivityViewModel();
                for (var i = 0; i < totalTimesheet.Count(); i++)
                {
                    productivity.EmployeeName = _context.ApplicationUsers.SingleOrDefault(x => x.Id == a.EmployeeId).UserName;
                    
                    if (a.EmployeeId == totalTimesheet[i].EmployeeId)
                    {
                        countHours += totalTimesheet[i].HoursSpent;
                        productivity.WorkingHours = countHours;
                        continue;
                    }
                    
                }
                productivityList.Add(productivity);
            }
            return View(productivityList);
        }
        //Change Project
        //ChangeProject/ProjectId
        public IActionResult ChangeProject(int id, int id2)
        {
            var userid = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (id == 0)
            {
                return NotFound();
            }
            if(id2 == 0)
            {
                return NotFound();
            }
            if(_context.Projects.SingleOrDefault(x=>x.ProjectId == id && x.WorkspaceId == _context.Workspaces.SingleOrDefault(y => y.PmId == userid).WorkspaceId) == null)
            {
                return NotFound();
            }
            if (_context.ChangeProjectRequests.SingleOrDefault(x=>x.ChangeProjectRequestId == id2) == null)
            {
                return NotFound();
            }
            var project = _context.Projects.SingleOrDefault(x => x.ProjectId == id && x.WorkspaceId == _context.Workspaces.SingleOrDefault(y => y.PmId == userid).WorkspaceId);
            ViewBag.WorkspaceId = _context.Workspaces.SingleOrDefault(y => y.PmId == userid).WorkspaceId;
            ViewBag.Name = _context.Workspaces.SingleOrDefault(y => y.PmId == userid).Name;
            var p = new ChangeProjectViewModel();
            p.ProjectName = project.Name;
            p.Description = project.Description;
            return View(p);
        }
        [HttpPost]
        public IActionResult ChangeProject(int id, int id2, ChangeProjectViewModel model)
        {
            var userid = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (_context.Projects.SingleOrDefault(x => x.ProjectId == id && x.WorkspaceId == _context.Workspaces.SingleOrDefault(y => y.PmId == userid).WorkspaceId) == null)
            {
                return NotFound();
            }
            if (_context.ChangeProjectRequests.SingleOrDefault(x => x.ChangeProjectRequestId == id2) == null)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                if(_context.Projects.Any(x=>x.Name == model.ProjectName))
                {
                    ViewBag.Name = _context.Workspaces.SingleOrDefault(y => y.PmId == userid).Name;
                    ViewBag.WorkspaceId = _context.Workspaces.SingleOrDefault(y => y.PmId == userid).WorkspaceId;
                    ModelState.AddModelError("CustomError", "This Project already exist in your Workspace");
                    return View(model);
                }
                else
                {
                    var project = _context.Projects.SingleOrDefault(x => x.ProjectId == id);
                    project.Name = model.ProjectName;
                    project.Description = model.Description;
                    _context.Projects.Update(project);
                    _context.SaveChanges();
                    var request = _context.ChangeProjectRequests.SingleOrDefault(x=>x.ChangeProjectRequestId == id2);
                    request.Status = "Accepted";
                    _context.ChangeProjectRequests.Update(request);
                    _context.SaveChanges();
                    return RedirectToAction("ChangeProjectRequestsPm");
                }
            }
            ViewBag.WorkspaceId = _context.Workspaces.SingleOrDefault(y => y.PmId == userid).WorkspaceId;
            ViewBag.Name = _context.Workspaces.SingleOrDefault(y => y.PmId == userid).Name;
            return View(model);
        }


        //Cannot Access the page
        //AccessDenie
        public IActionResult AccessDenie()
        {
            ViewData["Title"] = "Access denied";
            return View();
        }
    }
}