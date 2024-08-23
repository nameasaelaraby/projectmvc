using AutoMapper;
using DAL.Entity;
using DAL.Repo.BranchRepo;
using DAL.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLL.Services.BranchServices
{
    public class BranchServices : IBranchServices
    {
        private readonly IBranchRepo _branchRepo;
        private readonly IMapper _mapper;

        public BranchServices(IBranchRepo branchRepo, IMapper mapper)
        {
            _branchRepo = branchRepo;
            _mapper = mapper;
        }

        public async Task Create(BranchVM branchVM)
        {
            var branch = _mapper.Map<Branch>(branchVM);
            await _branchRepo.Create(branch);
        }

        public async Task Delete(BranchVM branchVM)
        {
            var branch = _mapper.Map<Branch>(branchVM);
            await _branchRepo.Delete(branch);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task DeleteEmployee(int employeeId)
        {
            throw new NotImplementedException();
        }

        public async Task Edit(BranchVM branchVM)
        {
            var branch = _mapper.Map<Branch>(branchVM);
            await _branchRepo.Edit(branch);
        }

        public async Task<List<BranchVM>> GetAll()
        {
            var data = await _branchRepo.GetAll();
            return _mapper.Map<List<BranchVM>>(data);
        }

        public async Task<BranchVM> GetById(int id)
        {
            var branch = await _branchRepo.GetById(id);
            return _mapper.Map<BranchVM>(branch);
        }
    }
}
