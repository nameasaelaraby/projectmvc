using AutoMapper;
using DAL.database;
using DAL.Entity;
using DAL.ViewModels;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.Repo.CustomerRepo
{
    public class CustomerRepo : ICustomerRepo
    {
        private readonly DatabaseDbContext _db;
        public CustomerRepo(DatabaseDbContext db)
        {
            _db = db;
        }

        public async Task Create(Customer customer)
        {
            _db.Customers.Add(customer);
            await _db.SaveChangesAsync();
        }

        public async Task Edit(Customer customer)
        {
            _db.Customers.Update(customer);
            await _db.SaveChangesAsync();
        }

        public async Task<List<Customer>> GetAll()
        {
            return await Get();
        }

        private async Task<List<Customer>> Get()
        {
            var data = await _db.Customers.ToListAsync();
            return data;
        }

        public async Task<Customer> GetById(int id)
        {
            var data = await _db.Customers.Where(x => x.CustomerId == id).FirstOrDefaultAsync();
            return data;
        }

        public async Task Delete(Customer customer)
        {
            _db.Customers.Remove(customer);
            await _db.SaveChangesAsync();
        }

        public async Task Delete(int CustomerId)
        {
            var Customer = await _db.Employees.FindAsync(CustomerId);
            if (Customer == null)
            {
                throw new Exception("Employee not found");
            }

            _db.Employees.Remove(Customer);
            await _db.SaveChangesAsync();
        }


    }
}
