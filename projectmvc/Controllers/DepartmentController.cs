using Microsoft.AspNetCore.Mvc;
using BLL.Services.DepartmentServices; // Adjust the namespace if different
using DAL.ViewModels;
using System.Threading.Tasks;

namespace ProjectMvc.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentServices _departmentServices;

        public DepartmentController(IDepartmentServices departmentServices)
        {
            _departmentServices = departmentServices;
        }

        // GET: Department
        public async Task<IActionResult> Index()
        {
            var departments = await _departmentServices.GetAll();
            return View(departments);
        }

        // GET: Department/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var department = await _departmentServices.GetById(id);
            if (department == null)
            {
                return NotFound();
            }
            return View(department);
        }

        // GET: Department/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Department/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(DepartmentVM departmentVM)
        {
            if (ModelState.IsValid)
            {
                await _departmentServices.Create(departmentVM);
                return RedirectToAction(nameof(Index));
            }
            return View(departmentVM);
        }

        // GET: Department/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var department = await _departmentServices.GetById(id);
            if (department == null)
            {
                return NotFound();
            }
            return View(department);
        }

        // POST: Department/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, DepartmentVM departmentVM)
        {
            if (id != departmentVM.DepartmentId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                await _departmentServices.Edit(departmentVM);
                return RedirectToAction(nameof(Index));
            }

            return View(departmentVM);
        }

        // GET: Department/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var department = await _departmentServices.GetById(id);
            if (department == null)
            {
                return NotFound();
            }

            return View(department);
        }

        // POST: Department/DeleteConfirmed
        [HttpPost]
        [ActionName("DeleteConfirmed")]
        public async Task<IActionResult> DeleteConfirmed(DepartmentVM departmentVM)
        {
            if (departmentVM == null)
            {
                return NotFound();
            }

            await _departmentServices.Delete(departmentVM);

            TempData["Message"] = "Department deleted successfully.";
            return RedirectToAction(nameof(Index));
        }

    }
}
