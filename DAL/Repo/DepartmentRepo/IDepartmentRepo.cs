using System.Collections.Generic;
using System.Threading.Tasks;
using DAL.Entity;

namespace DAL.Repo.DepartmentRepo
{
    public interface IDepartmentRepo
    {
        Task Create(Department department);
        Task Edit(Department department);
        Task<List<Department>> GetAll();
        Task<Department> GetById(int id);
        Task Delete(Department department);
    }
}
