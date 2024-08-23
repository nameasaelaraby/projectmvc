using DAL.database;
using DAL.Entity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.Repo.BranchRepo
{
    public class BranchRepo : IBranchRepo
    {
        private readonly DatabaseDbContext _db;

        public BranchRepo(DatabaseDbContext db)
        {
            _db = db;
        }

        public async Task Create(Branch branch)
        {
            _db.Branches.Add(branch);
            await _db.SaveChangesAsync();
        }

        public async Task Edit(Branch branch)
        {
            _db.Branches.Update(branch);
            await _db.SaveChangesAsync();
        }

        public async Task<List<Branch>> GetAll()
        {
            return await _db.Branches.ToListAsync();
        }

        public async Task<Branch> GetById(int id)
        {
            return await _db.Branches.FirstOrDefaultAsync(x => x.BranchId == id);
        }

        public async Task Delete(Branch branch)
        {
            _db.Branches.Remove(branch);
            await _db.SaveChangesAsync();
        }
    }
}
