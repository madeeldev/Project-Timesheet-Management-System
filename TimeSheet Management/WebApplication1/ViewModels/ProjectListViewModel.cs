using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeSheetManagement.Models;

namespace TimeSheetManagement.ViewModels
{
    public class ProjectListViewModel
    {
        public List<Project> ProjectsList { get; set; }
        public string SearchString { get; set; }
    }
}
