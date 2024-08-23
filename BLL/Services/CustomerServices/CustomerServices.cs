using AutoMapper;
using DAL.Entity;
using DAL.Repo.CustomerRepo;
using DAL.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLL.Services.CustomerServices
{
    public class CustomerServices : ICustomerServices
    {
        private readonly ICustomerRepo _customerRepo;
        private readonly IMapper _mapper;

        public CustomerServices(ICustomerRepo customerRepo, IMapper mapper)
        {
            _customerRepo = customerRepo;
            _mapper = mapper;
        }

        public async Task Create(CustomerVM customerVM)
        {
            var customer = _mapper.Map<Customer>(customerVM);
            await _customerRepo.Create(customer);
        }

        public async Task Delete(CustomerVM customerVM)
        {
            var customer = _mapper.Map<Customer>(customerVM);
            await _customerRepo.Delete(customer);
        }

        public async Task Delete(int CustomerId)
        {
            var Customer = await _customerRepo.GetById(CustomerId);
            if (Customer != null)
            {
                _customerRepo.Delete(Customer);
            }
            
        }

        public async Task Edit(CustomerVM customerVM)
        {
            var customer = _mapper.Map<Customer>(customerVM);
            await _customerRepo.Edit(customer);
        }

        public async Task<List<CustomerVM>> GetAll()
        {
            var data = await _customerRepo.GetAll();
            return _mapper.Map<List<CustomerVM>>(data);
        }

        public async Task<CustomerVM> GetById(int id)
        {
            var customer = await _customerRepo.GetById(id);
            return _mapper.Map<CustomerVM>(customer);
        }
    }
}
