using Microsoft.AspNetCore.Mvc;
using BLL.Services.EmployeeServices;
using DAL.ViewModels;

using System.Threading.Tasks;
using System.Collections.Generic;
using DAL.Entity;

namespace projectmvc.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeServices _employeeServices;

        public EmployeeController(IEmployeeServices employeeServices)
        {
            _employeeServices = employeeServices;
        }

        // GET: Employee
        public async Task<IActionResult> Index()
        {
            var employees = await _employeeServices.GetAll();
            return View(employees);
        }

        // GET: Employee/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var employee = await _employeeServices.GetById(id);
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }

        // GET: Employee/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Employee/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(EmployeeVM employeeVM)
        {
            if (ModelState.IsValid)
            {
                await _employeeServices.Create(employeeVM);
                return RedirectToAction(nameof(Index));
            }
            return View(employeeVM);
        }

        

        // GET: Employee/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var employee = await _employeeServices.GetById(id);
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }

        // POST: Employee/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int EmployeeId, EmployeeVM employeeVM)
        {
            if (EmployeeId != employeeVM.EmployeeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                await _employeeServices.Edit(employeeVM);
               
                return RedirectToAction(nameof(Index));
            }

            
            return View(employeeVM);
        }



        //[HttpPost]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var employee = await _employeeServices.GetById(id);
        //    if (employee == null)
        //    {
        //        return NotFound();
        //    }

        //    await _employeeServices.Delete(id);

        //    TempData["Message"] = "Employee has been successfully deleted.";
        //    return RedirectToAction("Index");
        //}


        // GET: Employee/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var employee = await _employeeServices.GetById(id);
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        // POST: Employee/DeleteConfirmed
        [HttpPost]
        [ActionName("DeleteConfirmed")]
        public async Task<IActionResult> DeleteConfirmed(EmployeeVM employeeVM)
        {
            if (employeeVM == null)
            {
                return NotFound();
            }

            await _employeeServices.Delete(employeeVM);

            TempData["Message"] = "Employee deleted successfully.";
            return RedirectToAction(nameof(Index));
        }




    }
}
