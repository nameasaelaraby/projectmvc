using DAL.database;
using DAL.Entity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.Repo.CounterRepo
{
    public class CounterRepo : ICounterRepo
    {
        private readonly DatabaseDbContext _db;

        public CounterRepo(DatabaseDbContext db)
        {
            _db = db;
        }

        public async Task Create(Counter counter)
        {
            _db.Counters.Add(counter);
            await _db.SaveChangesAsync();
        }

        public async Task Edit(Counter counter)
        {
            _db.Counters.Update(counter);
            await _db.SaveChangesAsync();
        }

        public async Task<List<Counter>> GetAll()
        {
            return await _db.Counters.ToListAsync();
        }

        public async Task<Counter> GetById(int id)
        {
            return await _db.Counters.FirstOrDefaultAsync(x => x.CounterId == id);
        }

        public async Task Delete(Counter counter)
        {
            _db.Counters.Remove(counter);
            await _db.SaveChangesAsync();
        }
    }
}
