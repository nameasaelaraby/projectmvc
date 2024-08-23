using System;
namespace DAL.Entity
{
    public class Counter
    {
        public int CounterId { get; set; }
        public string SerialNumber { get; set; }
        public double CurrentReading { get; set; }
        public DateTime ReadingDate { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}