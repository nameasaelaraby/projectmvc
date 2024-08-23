using System;
using System.ComponentModel.DataAnnotations;

namespace DAL.ViewModels
{
    public class ComplaintVM
    {
        public int ComplaintId { get; set; }

        [Required]
        [StringLength(500, ErrorMessage = "Description cannot be longer than 500 characters.")]
        public string Description { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime SubmissionDate { get; set; }

        [Required]
        public int CustomerId { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Status cannot be longer than 50 characters.")]
        public string Status { get; set; }

        // You can add additional properties if necessary, like Customer details
        // public string CustomerName { get; set; }
    }
}
