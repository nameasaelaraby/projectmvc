using System.ComponentModel.DataAnnotations;
namespace DAL.ViewModels
{
    public class DepartmentVM
    {
        public int DepartmentId { get; set; }

        [Required(ErrorMessage = "Department name is required")]
        [StringLength(100, ErrorMessage = "Department name can't be longer than 100 characters")]
        public string DepartmentName { get; set; }
    }
}