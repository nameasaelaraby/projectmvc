using DAL.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL.Repo.EmployeeRepo
{
    public interface IEmployeeRepo
    {
        Task Create(Employee employee);
        Task Edit(Employee employee);
        Task<List<Employee>> GetAll();
        Task<Employee> GetById(int id);
        Task Delete(Employee employee);
    }
}
