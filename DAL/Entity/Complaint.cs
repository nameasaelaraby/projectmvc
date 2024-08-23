using System;
namespace DAL.Entity
{
    public class Complaint
    {
        public int ComplaintId { get; set; }
        public string Description { get; set; }
        public DateTime SubmissionDate { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public string Status { get; set; }
    }
}
