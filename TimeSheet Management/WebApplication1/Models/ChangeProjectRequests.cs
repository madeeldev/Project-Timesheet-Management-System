﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace TimeSheetManagement.Models
{
    public class ChangeProjectRequests
    {
        [Key]
        public int ChangeProjectRequestId { get; set; }
        public string Status { get; set; }

        [ForeignKey("Project")]
        public int ProjectId { get; set; }
        public Project Project { get; set; }
        
        [ForeignKey("ApplicationUser")]
        public string IndividualId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}
