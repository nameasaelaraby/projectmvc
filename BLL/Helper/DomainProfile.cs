using AutoMapper;
using DAL.Entity;
using DAL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Helper
{
    public class DomainProfile : Profile
    {
        public DomainProfile()
        {
            // Mapping for Employee
            CreateMap<Employee, EmployeeVM>()

               
                .ReverseMap()
                .ForMember(dest => dest.Department, opt => opt.Ignore());

            // Mapping for Department
            CreateMap<Department, DepartmentVM>()
                .ReverseMap();

            // Mapping for Customer
            CreateMap<Customer, CustomerVM>()
                .ReverseMap();

            // Mapping for Bill
            CreateMap<Bill, BillVM>()
                .ReverseMap();

            // Mapping for Complaint
            CreateMap<Complaint, ComplaintVM>()
                .ReverseMap();

            // Mapping for Branch
            CreateMap<Branch, BranchVM>()
                .ReverseMap();

            // Mapping for Counter
            CreateMap<Counter, CounterVM>()
                .ReverseMap();
        }
    }
}
