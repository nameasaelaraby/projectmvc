using System.Collections.Generic;
using System.Threading.Tasks;
using DAL.ViewModels;

namespace BLL.Services.EmployeeServices
{
    public interface IEmployeeServices
    {
        Task Create(EmployeeVM employeeVM);
        Task Delete(EmployeeVM employeeVM);
        Task Delete(int employeeId);
        Task Edit(EmployeeVM employeeVM);
        Task<List<EmployeeVM>> GetAll();
        Task<EmployeeVM> GetById(int id);
    }
}
