using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TimeSheetManagement.Models;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        public DbSet<WorkSpace> Workspaces { get; set; }
        public DbSet<Project> Projects { get; set; }

        public DbSet<ProjectAssignment> ProjectAssignment { get; set; }
        public DbSet<Task> Tasks { get; set; }

        public DbSet<WeekSetting> WeekSettings { get; set; }
        public DbSet<TimeSheet> TimeSheets { get; set; }
        public DbSet<ChangeProjectRequests> ChangeProjectRequests { get; set; }

    }
}
