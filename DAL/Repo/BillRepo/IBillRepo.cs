using DAL.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL.Repo.BillRepo
{
    public interface IBillRepo
    {
        Task Create(Bill bill);
        Task Edit(Bill bill);
        Task<List<Bill>> GetAll();
        Task<Bill> GetById(int id);
        Task Delete(Bill bill);
    }
}
