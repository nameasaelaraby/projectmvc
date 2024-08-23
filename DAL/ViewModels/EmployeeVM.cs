using System.ComponentModel.DataAnnotations;
namespace DAL.ViewModels
{
    class lastEmp
    {
       // IEnumerable<SelectListItem> listdept {  get; set; }
    }
    public class EmployeeVM
    {
        public int EmployeeId { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(100, ErrorMessage = "Name can't be longer than 100 characters")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(100, ErrorMessage = "Name can't be longer than 100 characters")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Position is required")]
        [StringLength(100, ErrorMessage = "Position can't be longer than 100 characters")]
        public string Position { get; set; }

        [Required(ErrorMessage = "Department ID is required")]
        public int DepartmentId { get; set; }

        [Required(ErrorMessage = "Branch ID is required")]
        public int BranchId { get; set; }
    }
}
