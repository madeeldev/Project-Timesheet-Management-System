using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplication1.Models;

namespace TimeSheetManagement.Models
{
    public partial class WorkSpace
    {
        [Key]
        public int WorkspaceId { get; set; }
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }

        [ForeignKey("ApplicationUser")]
        public string PmId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

    }
}
