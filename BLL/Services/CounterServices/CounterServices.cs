using AutoMapper;
using DAL.Entity;
using DAL.Repo.CounterRepo;
using DAL.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLL.Services.CounterServices
{
    public class CounterServices : ICounterServices
    {
        private readonly ICounterRepo _counterRepo;
        private readonly IMapper _mapper;

        public CounterServices(ICounterRepo counterRepo, IMapper mapper)
        {
            _counterRepo = counterRepo;
            _mapper = mapper;
        }

        public async Task Create(CounterVM counterVM)
        {
            var counter = _mapper.Map<Counter>(counterVM);
            await _counterRepo.Create(counter);
        }

        public async Task Delete(CounterVM counterVM)
        {
            var counter = _mapper.Map<Counter>(counterVM);
            await _counterRepo.Delete(counter);
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task Edit(CounterVM counterVM)
        {
            var counter = _mapper.Map<Counter>(counterVM);
            await _counterRepo.Edit(counter);
        }

        public async Task<List<CounterVM>> GetAll()
        {
            var data = await _counterRepo.GetAll();
            return _mapper.Map<List<CounterVM>>(data);
        }

        public async Task<CounterVM> GetById(int id)
        {
            var counter = await _counterRepo.GetById(id);
            return _mapper.Map<CounterVM>(counter);
        }
    }
}
