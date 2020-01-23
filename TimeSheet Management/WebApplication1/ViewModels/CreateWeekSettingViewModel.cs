using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TimeSheetManagement.ViewModels
{
    public class CreateWeekSettingViewModel
    {
        [Display(Name = "Start Day")]
        public DayOfWeek StartDay { get; set; }
        [Display(Name = "End Day")]
        public DayOfWeek EndDay { get; set; }
        [Display(Name = "Start Date")]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }
    }
}
