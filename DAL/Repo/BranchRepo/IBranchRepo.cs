using DAL.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL.Repo.BranchRepo
{
    public interface IBranchRepo
    {
        Task Create(Branch branch);
        Task Edit(Branch branch);
        Task<List<Branch>> GetAll();
        Task<Branch> GetById(int id);
        Task Delete(Branch branch);
    }
}
