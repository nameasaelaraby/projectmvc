using System.Collections.Generic;
using System.Threading.Tasks;
using DAL.ViewModels;

namespace BLL.Services.DepartmentServices
{
    public interface IDepartmentServices
    {
        Task Create(DepartmentVM departmentVM);
        Task Delete(DepartmentVM departmentVM);
        Task Edit(DepartmentVM departmentVM);
        Task<List<DepartmentVM>> GetAll();
        Task<DepartmentVM> GetById(int id);
    }
}
