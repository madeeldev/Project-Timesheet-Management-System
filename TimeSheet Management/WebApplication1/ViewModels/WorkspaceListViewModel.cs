using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeSheetManagement.ViewModels
{
    public class WorkspaceListViewModel
    {
        public string WorkspaceName { get; set; }
        public DateTime DateCreated { get; set; }
        public int WorkspaceId { get; set; }
        public string Username { get; set; }
        public List<ProductivityViewModel> ProductivityList { get; set; }
    }
}
