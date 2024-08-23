using System.Collections.Generic;
using System.Threading.Tasks;
using DAL.Entity;

namespace DAL.Repo.CounterRepo
{
    public interface ICounterRepo
    {
        Task Create(Counter counter);
        Task Edit(Counter counter);
        Task<List<Counter>> GetAll();
        Task<Counter> GetById(int id);
        Task Delete(Counter counter);
    }
}
