using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeSheetManagement.ViewModels
{
    public class AcceptOrRejectTimesheetViewModel
    {
        public DateTime WeekStartDate { get; set; }
        public int TotalHours { get; set; }
        public int DevelopmentHours { get; set; }
        public int LearningHours { get; set; }
        public int MeetingHours { get; set; }
        public int MarketingHours { get; set; }
        public int DocumentationHours { get; set; }
    }
}
