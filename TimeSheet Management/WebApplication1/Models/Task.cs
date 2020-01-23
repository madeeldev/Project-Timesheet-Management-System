using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TimeSheetManagement.Models
{
    public class Task
    {
        [Key]
        public int TaskId { get; set; }
        public string TaskName { get; set; }

        [ForeignKey("Workspace")]
        public int WorkspaceId { get; set; }
        public WorkSpace Workspace { get; set; }
    }
}
