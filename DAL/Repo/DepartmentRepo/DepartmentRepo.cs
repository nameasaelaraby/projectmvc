using DAL.database;
using DAL.Entity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.Repo.DepartmentRepo
{
    public class DepartmentRepo : IDepartmentRepo
    {
        private readonly DatabaseDbContext _db;

        public DepartmentRepo(DatabaseDbContext db)
        {
            _db = db;
        }

        public async Task Create(Department department)
        {
            _db.Departments.Add(department);
            await _db.SaveChangesAsync();
        }


        public async Task Edit(Department department)
        {
            _db.Departments.Update(department);
            await _db.SaveChangesAsync();
        }

        public async Task<List<Department>> GetAll()
        {
            return await _db.Departments.ToListAsync();
        }

        public async Task<Department> GetById(int id)
        {
            return await _db.Departments.FirstOrDefaultAsync(x => x.DepartmentId == id);
        }

        public async Task Delete(Department department)
        {
            _db.Departments.Remove(department);
            await _db.SaveChangesAsync();
        }
    }
}
