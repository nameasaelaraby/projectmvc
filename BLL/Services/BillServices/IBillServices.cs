using System.Collections.Generic;
using System.Threading.Tasks;
using DAL.ViewModels;

namespace BLL.Services.BillServices
{
    public interface IBillServices
    {
        Task Create(BillVM billVM);
        Task Delete(BillVM billVM);
        Task Edit(BillVM billVM);
        Task<List<BillVM>> GetAll();
        Task<BillVM> GetById(int id);
    }
}
