using System.Collections.Generic;
using System.Threading.Tasks;
using DAL.ViewModels;

namespace BLL.Services.CustomerServices
{
    public interface ICustomerServices
    {
        Task Create(CustomerVM customerVM);
        Task Delete(CustomerVM customerVM);
        Task Delete(int CustomerId);
        Task Edit(CustomerVM customerVM);
        Task<List<CustomerVM>> GetAll();
        Task<CustomerVM> GetById(int id);
    }
}
