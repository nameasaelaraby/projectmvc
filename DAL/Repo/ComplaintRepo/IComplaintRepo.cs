using DAL.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL.Repo.ComplaintRepo
{
    public interface IComplaintRepo
    {
        Task Create(Complaint complaint);
        Task Edit(Complaint complaint);
        Task<List<Complaint>> GetAll();
        Task<Complaint> GetById(int id);
        Task Delete(Complaint complaint);
    }
}
