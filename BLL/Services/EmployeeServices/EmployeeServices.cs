using AutoMapper;
using DAL.Entity;
using DAL.Repo.EmployeeRepo;
using DAL.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLL.Services.EmployeeServices
{
    public class EmployeeServices : IEmployeeServices
    {
        private readonly IEmployeeRepo _employeeRepo;
        private readonly IMapper _mapper;

        public EmployeeServices(IEmployeeRepo employeeRepo, IMapper mapper)
        {
            _employeeRepo = employeeRepo;
            _mapper = mapper;
        }

        public async Task Create(EmployeeVM employeeVM)
        {
            var employee = _mapper.Map<Employee>(employeeVM);
            await _employeeRepo.Create(employee);
        }

        public async Task Delete(EmployeeVM employeeVM)
        {
            var employee = _mapper.Map<Employee>(employeeVM);
            await _employeeRepo.Delete(employee);
        }

        public async Task Delete(int employeeId)
        {
            var employee = await _employeeRepo.GetById(employeeId);
            if (employee != null)
            {
                _employeeRepo.Delete(employee);
            }
        }

        public async Task Edit(EmployeeVM employeeVM)
        {
            var employee = _mapper.Map<Employee>(employeeVM);
            await _employeeRepo.Edit(employee);
        }

        public async Task<List<EmployeeVM>> GetAll()
        {
            var data = await _employeeRepo.GetAll();
            return _mapper.Map<List<EmployeeVM>>(data);
        }

        public async Task<EmployeeVM> GetById(int id)
        {
            var employee = await _employeeRepo.GetById(id);
            return _mapper.Map<EmployeeVM>(employee);
        }
    }
}
