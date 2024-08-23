using System;
using System.ComponentModel.DataAnnotations;
namespace DAL.ViewModels
{
    public class CounterVM
    {
        public int CounterId { get; set; }

        [Required(ErrorMessage = "Serial number is required")]
        [StringLength(50, ErrorMessage = "Serial number can't be longer than 50 characters")]
        public string SerialNumber { get; set; }

        [Required(ErrorMessage = "Current reading is required")]
        [Range(0, double.MaxValue, ErrorMessage = "Reading must be a positive number")]
        public double CurrentReading { get; set; }

        [Required(ErrorMessage = "Reading date is required")]
        public DateTime ReadingDate { get; set; }

        [Required(ErrorMessage = "Customer ID is required")]
        public int CustomerId { get; set; }
    }
}
