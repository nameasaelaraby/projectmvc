using System.Collections.Generic;
using System.Threading.Tasks;
using DAL.ViewModels;

namespace BLL.Services.ComplaintServices
{
    public interface IComplaintServices
    {
        Task Create(ComplaintVM complaintVM);
        Task Delete(ComplaintVM complaintVM);
        Task Edit(ComplaintVM complaintVM);
        Task<List<ComplaintVM>> GetAll();
        Task<ComplaintVM> GetById(int id);
    }
}
