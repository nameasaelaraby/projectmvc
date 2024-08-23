using AutoMapper;
using DAL.database;
using DAL.Entity;
using DAL.ViewModels;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.Repo.ComplaintRepo
{
    public class ComplaintRepo : IComplaintRepo
    {
        private readonly DatabaseDbContext _db;
        public ComplaintRepo(DatabaseDbContext db)
        {
            _db = db;
        }

        public async Task Create(Complaint complaint)
        {
            _db.Complaints.Add(complaint);
            await _db.SaveChangesAsync();
        }

        public async Task Edit(Complaint complaint)
        {
            _db.Complaints.Update(complaint);
            await _db.SaveChangesAsync();
        }

        public async Task<List<Complaint>> GetAll()
        {
            return await Get();
        }

        private async Task<List<Complaint>> Get()
        {
            var data = await _db.Complaints.ToListAsync();
            return data;
        }

        public async Task<Complaint> GetById(int id)
        {
            var data = await _db.Complaints.Where(x => x.ComplaintId == id).FirstOrDefaultAsync();
            return data;
        }

        public async Task Delete(Complaint complaint)
        {
            _db.Complaints.Remove(complaint);
            await _db.SaveChangesAsync();
        }
    }
}
