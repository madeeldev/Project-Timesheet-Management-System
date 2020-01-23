
using System.ComponentModel.DataAnnotations;
namespace TimeSheetManagement.ViewModels
{
    public class CreateTaskViewModel
    {
        [Display(Name = "Task Name")]
        [Required]
        public string TaskName { get; set; }
    }
}
