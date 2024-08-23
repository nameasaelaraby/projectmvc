using System;
using System.ComponentModel.DataAnnotations;

namespace DAL.ViewModels
{
    public class BillVM
    {
        public int BillId { get; set; }

        [Required(ErrorMessage = "Issue Date is required.")]
        [DataType(DataType.Date)]
        public DateTime IssueDate { get; set; }

        [Required(ErrorMessage = "Amount Due is required.")]
        
        public double AmountDue { get; set; }

        [Required(ErrorMessage = "Due Date is required.")]
        [DataType(DataType.Date)]
        public DateTime DueDate { get; set; }

        [Required(ErrorMessage = "Counter ID is required.")]
        public int CounterId { get; set; }

    }
}
