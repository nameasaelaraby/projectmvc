 using System.Collections.Generic;
using System.Threading.Tasks;
using DAL.ViewModels;

namespace BLL.Services.BranchServices
{
    public interface IBranchServices
    {
        Task Create(BranchVM branchVM);
        Task Delete(BranchVM branchVM);
        void Delete(int id);
        Task DeleteEmployee(int employeeId);
        Task Edit(BranchVM branchVM);
        Task<List<BranchVM>> GetAll();
        Task<BranchVM> GetById(int id);
    }
}
