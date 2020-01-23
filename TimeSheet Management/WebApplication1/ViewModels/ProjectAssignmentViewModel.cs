using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TimeSheetManagement.ViewModels
{
    public class ProjectAssignmentViewModel
    {
        [Display(Name = "Search Email")]
        [Required]
        public string SearchEmail { get; set; }
    }
}
