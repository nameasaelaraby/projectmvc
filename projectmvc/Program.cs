using Microsoft.EntityFrameworkCore;
using BLL;
using BLL.Helper;
using BLL.Services.BranchServices;
using BLL.Services.ComplaintServices;
using BLL.Services.CounterServices;
using BLL.Services.CustomerServices;
using BLL.Services.EmployeeServices;
using DAL.database;
using DAL.Repo.BranchRepo;
using DAL.Repo.ComplaintRepo;
using DAL.Repo.CounterRepo;
using DAL.Repo.CustomerRepo;
using DAL.Repo.EmployeeRepo;
using DAL.database;
using DAL.Repo.DepartmentRepo;
using BLL.Services.DepartmentServices;
using BLL.Services.BillServices;
using DAL.Repo.BillRepo;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace projectmvc
{
    public class Program
    {
        public static void Main(string[] args)
        {




            var builder = WebApplication.CreateBuilder(args);
            var conn = builder.Configuration.GetConnectionString("DfulteConnection");

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            // Register DbContext
            builder.Services.AddDbContext<DatabaseDbContext>(options =>
            {
                options.UseSqlServer(conn);
                options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            });




            // Register AutoMapper
            builder.Services.AddAutoMapper(x => x.AddProfile(new DomainProfile()));

            // Register Repositories
            builder.Services.AddScoped<IBranchRepo, BranchRepo>();
            builder.Services.AddScoped<IComplaintRepo, ComplaintRepo>();
            builder.Services.AddScoped<ICounterRepo, CounterRepo>();
            builder.Services.AddScoped<ICustomerRepo, CustomerRepo>();
            builder.Services.AddScoped<IEmployeeRepo, EmployeeRepo>();
            builder.Services.AddScoped<IDepartmentRepo, DepartmentRepo>();
            builder.Services.AddScoped<IBillRepo, BillRepo>();


            // Register Services
            builder.Services.AddScoped<IBranchServices, BranchServices>();
            builder.Services.AddScoped<IComplaintServices, ComplaintServices>();
            builder.Services.AddScoped<ICounterServices, CounterServices>();
            builder.Services.AddScoped<ICustomerServices, CustomerServices>();
            builder.Services.AddScoped<IEmployeeServices, EmployeeServices>();
            builder.Services.AddScoped<IDepartmentServices, DepartmentServices>();
            builder.Services.AddScoped<IBillServices, BillServices>();


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();


            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=index}/{id?}");





            app.Run();
        }
    }
}
