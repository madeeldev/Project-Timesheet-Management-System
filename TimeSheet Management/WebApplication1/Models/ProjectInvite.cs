using System;
using System.Collections.Generic;
using WebApplication1.Models;

namespace TimeSheetManagement.Models
{
    public partial class ProjectInvite
    {
        public int ProjectId { get; set; }
        public string EmployeeId { get; set; }
        public string Status { get; set; }
        public int InviteId { get; set; }
        public DateTime InviteDate { get; set; }

        public virtual ApplicationUser Employee { get; set; }
        public virtual Project Project { get; set; }
    }
}
