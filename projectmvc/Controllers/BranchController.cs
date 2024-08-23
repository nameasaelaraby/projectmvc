using Microsoft.AspNetCore.Mvc;
using BLL.Services.BranchServices; // Adjust the namespace if different
using DAL.ViewModels;
using System.Threading.Tasks;

namespace ProjectMvc.Controllers
{
    public class BranchController : Controller
    {
        private readonly IBranchServices _branchServices;

        public BranchController(IBranchServices branchServices)
        {
            _branchServices = branchServices;
        }

        // GET: Branch
        public async Task<IActionResult> Index()
        {
            var branches = await _branchServices.GetAll();
            return View(branches);
        }

        // GET: Branch/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var branch = await _branchServices.GetById(id);
            if (branch == null)
            {
                return NotFound();
            }
            return View(branch);
        }

        // GET: Branch/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Branch/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(BranchVM branchVM)
        {
            if (ModelState.IsValid)
            {
                await _branchServices.Create(branchVM);
                return RedirectToAction(nameof(Index));
            }
            return View(branchVM);
        }


        // GET: Branch/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var branch = await _branchServices.GetById(id);
            if (branch == null)
            {
                return NotFound();
            }

            return View(branch);
        }

        // POST: Branch/Edit
        [HttpPost]
        public async Task<IActionResult> Edit(BranchVM branchVM)
        {
            if (!ModelState.IsValid)
            {
                return View(branchVM);
            }

            await _branchServices.Edit(branchVM);

            TempData["Message"] = "Branch updated successfully.";
            return RedirectToAction(nameof(Index));
        }







       

            // GET: Branch/Delete/5
            public async Task<IActionResult> Delete(int id)
            {
                var branch = await _branchServices.GetById(id);
                if (branch == null)
                {
                    return NotFound();
                }
                return View(branch);
            }

            // POST: Branch/DeleteConfirmed
            [HttpPost]
            [ActionName("DeleteConfirmed")]
            public async Task<IActionResult> DeleteConfirmed(BranchVM branchVM)
            {
                if (branchVM == null)
                {
                    return NotFound();
                }

                await _branchServices.Delete(branchVM);

                TempData["Message"] = "Employee deleted successfully.";
                return RedirectToAction(nameof(Index));
            }
        }

    }



