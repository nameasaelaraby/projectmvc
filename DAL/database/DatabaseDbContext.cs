using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entity;
using DAL.ViewModels;

namespace DAL.database
{
    using Microsoft.EntityFrameworkCore;

    public class DatabaseDbContext : DbContext
    {
        public DatabaseDbContext(DbContextOptions<DatabaseDbContext> options) : base(options)
        {
        }

        // DbSets for your entities
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Counter> Counters { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<Complaint> Complaints { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Branch> Branches { get; set; }
    }

}
