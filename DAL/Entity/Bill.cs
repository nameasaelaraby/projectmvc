using System;
using System.Diagnostics.Metrics;

namespace DAL.Entity
{
    public class Bill
    {
        public int BillId { get; set; }
        public DateTime IssueDate { get; set; }
        public double AmountDue { get; set; }
        public DateTime DueDate { get; set; }
        public int CounterId { get; set; }
        public Counter Counter { get; set; }
    }
}