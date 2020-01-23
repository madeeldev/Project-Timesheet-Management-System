using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplication1.Models;

namespace TimeSheetManagement.Models
{
    public partial class TimeSheet
    {
        [Key]
        public int TimeSheetId { get; set; }
        public DateTime Date { get; set; }
        public string Task { get; set; }
        public string TaskType { get; set; }
        public int HoursSpent { get; set; }
        public string Status { get; set; }

        [ForeignKey("ApplicationUser")]
        public string EmployeeId { get; set; }
        public ApplicationUser ApplicationUser { get; set;}

        [ForeignKey("Project")]
        public int ProjectId { get; set; }
        public Project Project { get; set; }
    }
}
