using System.Collections.Generic;
namespace DAL.Entity
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public int BranchId { get; set; }
        public Branch Branch { get; set; }
    }
}
