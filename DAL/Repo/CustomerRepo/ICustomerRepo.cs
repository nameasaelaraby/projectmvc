using DAL.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL.Repo.CustomerRepo
{
    public interface ICustomerRepo
    {
        Task Create(Customer customer);
        Task Edit(Customer customer);
        Task<List<Customer>> GetAll();
        Task<Customer> GetById(int id);
        Task Delete(Customer customer);
    }
}
