using System.ComponentModel.DataAnnotations;
namespace DAL.ViewModels
{

    public class BranchVM
    {
        public int BranchId { get; set; }

        [Required(ErrorMessage = "Branch name is required")]
        [StringLength(100, ErrorMessage = "Branch name can't be longer than 100 characters")]
        public string BranchName { get; set; }


        [Required(ErrorMessage = "Branch name is required")]
        [StringLength(100, ErrorMessage = "Branch name can't be longer than 100 characters")]
        public string BranchLocation { get; set; }


    }
}