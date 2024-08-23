using System.ComponentModel.DataAnnotations;

namespace DAL.ViewModels
{
    public class CustomerVM
    {
        public int CustomerId { get; set; }

        [Required(ErrorMessage = "First Name is required")]
        [StringLength(100, ErrorMessage = "First Name can't be longer than 100 characters")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        [StringLength(100, ErrorMessage = "Last Name can't be longer than 100 characters")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Address is required")]
        [StringLength(250, ErrorMessage = "Address can't be longer than 250 characters")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Phone number is required")]
        [Phone(ErrorMessage = "Invalid phone number")]
        public string PhoneNumber { get; set; }
    }
}
