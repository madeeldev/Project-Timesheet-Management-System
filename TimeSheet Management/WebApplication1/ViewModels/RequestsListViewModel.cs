using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeSheetManagement.ViewModels
{
    public class RequestsListViewModel
    {
        public string ProjectName { get; set; }
        public string ProjectDescription { get; set; }
        public string Status { get; set; }
        public string Member { get; set; }
        public int ProjectId { get; set; }
        public int RequestId { get; set; }
    }
}
