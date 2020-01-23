using System;
using System.Collections.Generic;
using WebApplication1.Models;

namespace TimeSheetManagement.Models
{
    public partial class Week
    {
        public Week()
        {
            TimeSheet = new HashSet<TimeSheet>();
        }

        public int WeekId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Pmid { get; set; }

        public virtual ApplicationUser Pm { get; set; }
        public virtual ICollection<TimeSheet> TimeSheet { get; set; }
    }
}
