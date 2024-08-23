using AutoMapper;
using DAL.Entity;
using DAL.Repo.DepartmentRepo;
using DAL.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLL.Services.DepartmentServices
{
    public class DepartmentServices : IDepartmentServices
    {
        private readonly IDepartmentRepo _departmentRepo;
        private readonly IMapper _mapper;

        public DepartmentServices(IDepartmentRepo departmentRepo, IMapper mapper)
        {
            _departmentRepo = departmentRepo;
            _mapper = mapper;
        }

        public async Task Create(DepartmentVM departmentVM)
        {
            var department = _mapper.Map<Department>(departmentVM);
            await _departmentRepo.Create(department);
        }

        public async Task Delete(DepartmentVM departmentVM)
        {
            var department = _mapper.Map<Department>(departmentVM);
            await _departmentRepo.Delete(department);
        }

        public async Task Edit(DepartmentVM departmentVM)
        {
            var department = _mapper.Map<Department>(departmentVM);
            await _departmentRepo.Edit(department);
        }

        public async Task<List<DepartmentVM>> GetAll()
        {
            var data = await _departmentRepo.GetAll();
            return _mapper.Map<List<DepartmentVM>>(data);
        }

        public async Task<DepartmentVM> GetById(int id)
        {
            var department = await _departmentRepo.GetById(id);
            return _mapper.Map<DepartmentVM>(department);
        }
    }
}
