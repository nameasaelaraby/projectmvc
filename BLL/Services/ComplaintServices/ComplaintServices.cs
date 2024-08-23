using AutoMapper;
using DAL.Entity;
using DAL.Repo.ComplaintRepo;
using DAL.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLL.Services.ComplaintServices
{
    public class ComplaintServices : IComplaintServices
    {
        private readonly IComplaintRepo _complaintRepo;
        private readonly IMapper _mapper;

        public ComplaintServices(IComplaintRepo complaintRepo, IMapper mapper)
        {
            _complaintRepo = complaintRepo;
            _mapper = mapper;
        }

        public async Task Create(ComplaintVM complaintVM)
        {
            var complaint = _mapper.Map<Complaint>(complaintVM);
            await _complaintRepo.Create(complaint);
        }

        public async Task Delete(ComplaintVM complaintVM)
        {
            var complaint = _mapper.Map<Complaint>(complaintVM);
            await _complaintRepo.Delete(complaint);
        }

        public async Task Edit(ComplaintVM complaintVM)
        {
            var complaint = _mapper.Map<Complaint>(complaintVM);
            await _complaintRepo.Edit(complaint);
        }

        public async Task<List<ComplaintVM>> GetAll()
        {
            var data = await _complaintRepo.GetAll();
            return _mapper.Map<List<ComplaintVM>>(data);
        }

        public async Task<ComplaintVM> GetById(int id)
        {
            var complaint = await _complaintRepo.GetById(id);
            return _mapper.Map<ComplaintVM>(complaint);
        }
    }
}
