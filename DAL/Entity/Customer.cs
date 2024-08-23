using System.Collections.Generic;
using System.Diagnostics.Metrics;
namespace DAL.Entity
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public ICollection<Counter> Counters { get; set; }
        public ICollection<Complaint> Complaints { get; set; }
    }
}