using AutoMapper;
using DAL.database;
using DAL.Entity;
using DAL.ViewModels;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.Repo.EmployeeRepo
{
    public class EmployeeRepo : IEmployeeRepo
    {
        private readonly DatabaseDbContext _db;
        public EmployeeRepo(DatabaseDbContext db)
        {
            _db = db;
        }

        public async Task Create(Employee employee)
        {
            _db.Employees.Add(employee);
            await _db.SaveChangesAsync();
        }

        public async Task Edit(Employee employee)
        {
            _db.Employees.Update(employee);
            await _db.SaveChangesAsync();
        }

        public async Task<List<Employee>> GetAll()
        {
            return await Get();
        }

        private async Task<List<Employee>> Get()
        {
            var data = await _db.Employees.ToListAsync();
            return data;
        }

        public async Task<Employee> GetById(int id)
        {
            var data = await _db.Employees.Where(x => x.EmployeeId == id).FirstOrDefaultAsync();
            return data;
        }

       

        public async Task Delete(Employee employee)
        {
            _db.Employees.Remove(employee);
            await _db.SaveChangesAsync();
        }

    }
}
