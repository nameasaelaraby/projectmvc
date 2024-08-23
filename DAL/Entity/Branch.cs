using System.Collections.Generic;
namespace DAL.Entity
{
    public class Branch
    {
        public int BranchId { get; set; }
        public string BranchName { get; set; }
        public string BranchLocation { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}
