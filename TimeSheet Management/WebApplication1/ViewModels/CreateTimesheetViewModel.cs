using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TimeSheetManagement.ViewModels
{
    public class CreateTimesheetViewModel
    {
        [Required]

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        [Required]
        public string Task { get; set; }
        [Display(Name = "Task Type")]
        [Required]
        public string TaskType { get; set; }
        [Display(Name = "Hours Spent")]
        public int HoursSpent { get; set; }
        public DateTime WeekStartDate { get; set; }
    }
}
