using System.Collections.Generic;
using System.Threading.Tasks;
using DAL.ViewModels;

namespace BLL.Services.CounterServices
{
    public interface ICounterServices
    {
        Task Create(CounterVM counterVM);
        Task Delete(CounterVM counterVM);
        Task Edit(CounterVM counterVM);
        Task<List<CounterVM>> GetAll();
        Task<CounterVM> GetById(int id);
        Task Delete(int id);
    }
}
