using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TimeSheetManagement.ViewModels
{
    public class DisplayTimeSheet
    {
        public int TimeSheetId { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy/MM/dd}")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public string Task { get; set; }
        public string TaskType { get; set; }
        public int HoursSpent { get; set; }
        public string Status { get; set; }
    }
}
