using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TimeSheetManagement.Models
{
    public partial class WeekSetting
    {
        [Key]
        public int WeekSettingId { get; set; }
        [Display(Name = "Start Day")]
        public string StartDay { get; set; }
        [Display(Name = "End Day")]
        public string EndDay { get; set; }
        [Display(Name = "Start Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTime StartDate { get; set; }

        [ForeignKey("WorkSpace")]
        public int WorkspaceId { get; set; }
        public WorkSpace WorkSpace { get; set; }
    }
}
