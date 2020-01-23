using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TimeSheetManagement.ViewModels
{
    public class ShowWeekSetting
    {
        public int WeekSettingId { get; set; }
        [Display(Name = "Start Day")]
        public string StartDay { get; set; }
        [Display(Name = "End Day")]
        public string EndDay { get; set; }
        [Display(Name = "Start Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTime StartDate { get; set; }
    }
}
