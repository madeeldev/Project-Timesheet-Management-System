using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeSheetManagement.Models;

namespace TimeSheetManagement.ViewModels
{
    public class InvitationRequestsViewModel
    {
        public string ProjectName { get; set; }
        public string ProjectDescription { get; set; }
        public string Status { get; set; }
        public int InvitationId { get; set; }
    }
}
