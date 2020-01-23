using System;
using System.Collections.Generic;
using WebApplication1.Models;

namespace TimeSheetManagement.Models
{
    public partial class Managers
    {
        public Managers()
        {
            InverseManager = new HashSet<Managers>();
        }

        public string EmployeeId { get; set; }
        public string ManagerId { get; set; }

        public virtual ApplicationUser Employee { get; set; }
        public virtual Managers Manager { get; set; }
        public virtual ICollection<Managers> InverseManager { get; set; }
    }
}
