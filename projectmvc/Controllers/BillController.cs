using Microsoft.AspNetCore.Mvc;
using BLL.Services.BillServices; // Adjust the namespace if different
using DAL.ViewModels;
using System.Threading.Tasks;
using DAL.Entity;

namespace projectmvc.Controllers
{
    public class BillController : Controller
    {
        private readonly IBillServices _billServices;

        public BillController(IBillServices billServices)
        {
            _billServices = billServices;
        }

        // GET: Bill
        public async Task<IActionResult> Index()
        {
            var bills = await _billServices.GetAll();
            return View(bills);
        }

        // GET: Bill/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var bill = await _billServices.GetById(id);
            if (bill == null)
            {
                return NotFound();
            }
            return View(bill);
        }

        // GET: Bill/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Bill/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(BillVM billVM)
        {
            if (ModelState.IsValid)
            {
                await _billServices.Create(billVM);
                return RedirectToAction(nameof(Index));
            }
            return View(billVM);
        }

        // GET: Bill/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var bill = await _billServices.GetById(id);
            if (bill == null)
            {
                return NotFound();
            }
            return View(bill);
        }

        // POST: Bill/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, BillVM billVM)
        {
            if (id != billVM.BillId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                await _billServices.Edit(billVM);
                return RedirectToAction(nameof(Index));
            }
            return View(billVM);
        }

        // GET: Branch/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var bill = await _billServices.GetById(id);
            if (bill == null)
            {
                return NotFound();
            }
            return View(bill);
        }

        // POST: Branch/DeleteConfirmed
        [HttpPost]
        [ActionName("DeleteConfirmed")]
        public async Task<IActionResult> DeleteConfirmed(BillVM billVM)
        {
            if (billVM == null)
            {
                return NotFound();
            }

            await _billServices.Delete(billVM);

            TempData["Message"] = "Employee deleted successfully.";
            return RedirectToAction(nameof(Index));
        }
    }
}
